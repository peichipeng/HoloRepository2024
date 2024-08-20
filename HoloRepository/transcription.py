import torch
from transformers import AutoModelForTokenClassification, AutoTokenizer, AutoProcessor, AutoModelForSpeechSeq2Seq, pipeline
import speech_recognition as sr
import queue
import threading
import time
import numpy as np
import noisereduce as nr
import sys
import json
import traceback
import os
from dateutil import parser
import re

device = "cuda:0" if torch.cuda.is_available() else "cpu"
torch_dtype = torch.float16 if torch.cuda.is_available() else torch.float32

# Load Whisper model
whisper_model_id = "distil-whisper/distil-medium.en"
whisper_model = AutoModelForSpeechSeq2Seq.from_pretrained(
    whisper_model_id, torch_dtype=torch_dtype, low_cpu_mem_usage=True, use_safetensors=True
)
whisper_model.to(device)
processor = AutoProcessor.from_pretrained(whisper_model_id)

# Load custom NER model
ner_model_path = "./NER_model"

try:
    ner_model = AutoModelForTokenClassification.from_pretrained(ner_model_path)
    ner_tokenizer = AutoTokenizer.from_pretrained(ner_model_path)
    ner_pipeline = pipeline('ner', model=ner_model, tokenizer=ner_tokenizer)
except Exception as e:
    print(f"Error loading NER model: {e}", file=sys.stderr, flush=True)
    traceback.print_exc(file=sys.stderr)
    sys.exit(1)

q = queue.Queue()
is_ner_active = False
is_transcription_paused = False

def audio_callback(recognizer, audio):
    """This is called (from a separate thread) for each audio block."""
    try:
        audio_data = np.frombuffer(audio.get_raw_data(), np.int16).astype(np.float32) / 32768.0
        q.put(audio_data)
    except Exception as e:
        print(f"Error processing audio: {e}", file=sys.stderr, flush=True)

def pad_mel_features(mel_features, target_length=3000):
    """Pad mel features to the target length with -1.0 and create an attention mask."""
    pad_width = target_length - mel_features.shape[-1]
    attention_mask = np.ones(mel_features.shape[-1])

    if pad_width > 0:
        mel_features = np.pad(mel_features, ((0, 0), (0, pad_width)), mode='constant', constant_values=-1.0)
        attention_mask = np.pad(attention_mask, (0, pad_width), mode='constant', constant_values=0)

    return mel_features, attention_mask

def transcribe_audio():
    """Continuously fetch audio from the queue and run transcription."""
    try:
        while True:
            if is_transcription_paused:
                time.sleep(0.1)
                continue

            audio_block = q.get()
            if len(audio_block) > 0:
                audio_block = audio_block.flatten()
                reduced_noise_audio = nr.reduce_noise(y=audio_block, sr=16000)

                if np.mean(np.abs(reduced_noise_audio)) < 0.01:
                    continue
                
                inputs = processor(reduced_noise_audio, sampling_rate=16000, return_tensors="pt", padding=True)

                if 'input_features' in inputs:
                    input_features = inputs['input_features'].squeeze().cpu().numpy()

                    # Pad the input features to the required length and create attention mask
                    input_features, attention_mask = pad_mel_features(input_features)
                    input_features = torch.tensor(input_features).unsqueeze(0).to(device, torch_dtype)
                    attention_mask = torch.tensor(attention_mask).unsqueeze(0).to(device, torch_dtype)

                    with torch.no_grad():
                        generated_ids = whisper_model.generate(input_features, attention_mask=attention_mask, max_new_tokens=128)
                    transcription = processor.batch_decode(generated_ids, skip_special_tokens=True)[0]
                    print(transcription, flush=True)              

                    if is_ner_active:
                        ner_result = perform_ner(transcription)
                        ner_result = format_ner_result(ner_result)

                        ner_result_json = json.dumps(ner_result)
                        print(f"NER Result: {ner_result_json}", flush=True)
                        print(f"MessageBox: {ner_result_json}", flush=True)
                else:
                    print("Error: 'input_features' not found in inputs", flush=True)
    except Exception as e:
        print(f"Error in transcribe_audio: {e}", file=sys.stderr, flush=True)
        traceback.print_exc(file=sys.stderr)

def perform_ner(text):
    """Perform Named Entity Recognition on the given text."""
    try:
        ner_results = ner_pipeline(text)
        print(f"NER Results: {ner_results}", flush=True)
        return ner_results
    except Exception as e:
        print(f"Error in perform_ner: {e}", file=sys.stderr, flush=True)
        traceback.print_exc(file=sys.stderr)
        return []

def format_ner_result(ner_results):
    """Format NER results for WinForm."""
    try:
        formatted_result = {"ID": "", "DoD": "", "Age": "", "Cause_of_Death": ""}
        for entity in ner_results:
            if entity['entity'].endswith("ID"):
                formatted_result["ID"] += entity['word'] + " "
            elif entity['entity'].endswith("DoD"):
                formatted_result["DoD"] += entity['word']
            elif entity['entity'].endswith("Age"):
                formatted_result["Age"] += entity['word'] + " "
            elif entity['entity'].endswith("Cause_of_Death"):
                formatted_result["Cause_of_Death"] += entity['word'] + " "

        formatted_result = {key: value.replace('#', '').strip() for key, value in formatted_result.items()}

        formatted_result["ID"] = re.sub(r'\D', '', formatted_result["ID"])

        formatted_result["DoD"] = process_date(formatted_result["DoD"])

        return formatted_result
    
    except Exception as e:
        print(f"Error in format_ner_result: {e}", file=sys.stderr, flush=True)
        traceback.print_exc(file=sys.stderr)
        return {"ID": "", "DoD": "", "Age": "", "Cause_of_Death": ""}

def process_date(date_str):
    """Process date string to DD/MM/YYYY format."""
    try:
        date_str = preprocess_date_string(date_str)

        date_str = fix_year_format(date_str)

        date = parser.parse(date_str)

        return date.strftime("%d/%m/%Y")
    except Exception as e:
        print(f"Error in process_date: {e}", file=sys.stderr, flush=True)
        traceback.print_exc(file=sys.stderr)
        return date_str

def preprocess_date_string(date_str):
    date_str = re.sub(r'(\d+)(th|st|nd|rd)', r'\1', date_str, flags=re.IGNORECASE)

    date_str = re.sub(r',', '', date_str)

    date_str = re.sub(r'\b(?:first|second|third|fourth|fifth|sixth|seventh|eighth|ninth|tenth|eleventh|twelfth|thirteenth|fourteenth|fifteenth|sixteenth|seventeenth|eighteenth|nineteenth|twentieth|twenty[- ]first|twenty[- ]second|twenty[- ]third|twenty[- ]fourth|twenty[- ]fifth|twenty[- ]sixth|twenty[- ]seventh|twenty[- ]eighth|twenty[- ]ninth|thirtieth|thirty[- ]first)\b(?: of)?\b', convert_ordinal_to_number, date_str, flags=re.IGNORECASE)

    return date_str

def fix_year_format(date_str):
    """Fixes the year format to ensure it is a continuous four-digit number."""
    return re.sub(r'(\d{2})\s(\d{2})', r'\1\2', date_str)

def convert_ordinal_to_number(match):
    """Convert ordinal numbers to numeric form."""
    ordinal_dict = {
        'first': '1', 'second': '2', 'third': '3', 'fourth': '4', 'fifth': '5',
        'sixth': '6', 'seventh': '7', 'eighth': '8', 'ninth': '8', 'tenth': '10',
        'eleventh': '11', 'twelfth': '12', 'thirteenth': '13', 'fourteenth': '14',
        'fifteenth': '15', 'sixteenth': '16', 'seventeenth': '17', 'eighteenth': '18',
        'nineteenth': '19', 'twentieth': '20', 'twenty first': '21', 'twenty second': '22',
        'twenty third': '23', 'twenty fourth': '24', 'twenty fifth': '25', 'twenty sixth': '26',
        'twenty seventh': '27', 'twenty eighth': '28', 'twenty ninth': '29', 'thirtieth': '30',
        'thirty first': '31'
    }

    return ordinal_dict[match.group(0).lower().replace(' of', '').replace('-', '')]

def start_transcription():
    global stop_listening
    recognizer = sr.Recognizer()
    mic = sr.Microphone(sample_rate=16000)
    try:
        with mic as source:
            recognizer.adjust_for_ambient_noise(source)
        stop_listening = recognizer.listen_in_background(mic, audio_callback)
    except Exception as e:
        print(f"Error starting transcription: {e}", file=sys.stderr, flush=True)
        traceback.print_exc(file=sys.stderr)

def stop_transcription():
    global stop_listening
    try:
        stop_listening(wait_for_stop=False)
    except Exception as e:
        print(f"Error stopping transcription: {e}", file=sys.stderr, flush=True)
        traceback.print_exc(file=sys.stderr)

def start_ner():
    global is_ner_active
    is_ner_active = True
    print("MessageBox: NER started", flush=True)

def stop_ner():
    global is_ner_active
    is_ner_active = False
    print("MessageBox: NER stopped", flush=True)

if __name__ == "__main__":
    try:
        transcription_thread = threading.Thread(target=transcribe_audio)
        transcription_thread.daemon = True
        transcription_thread.start()

        while True:
            line = sys.stdin.readline().strip()
            if line == "start_transcription":
                try:
                    start_transcription()
                except Exception as e:
                    print(f"Error starting transcription: {e}", flush=True)
            elif line == "stop_transcription":
                try:
                    stop_transcription()
                except Exception as e:
                    print(f"Error stopping transcription: {e}", flush=True)
            elif line == "start_ner":
                start_ner()
            elif line == "stop_ner":
                stop_ner()
            else:
                print("Unknown command", flush=True)
    except Exception as e:
        print(f"Error in main script: {e}", file=sys.stderr, flush=True)
        traceback.print_exc(file=sys.stderr)
