# 1. Speech Inference Environment Setup

Here provides a setup for speech inference using a predefined Conda environment. Follow the steps below to set up and activate the environment.

## Prerequisites

- **Anaconda/Miniconda**: Make sure you have Anaconda or Miniconda installed on your system. If not, you can download and install it from the official website: [Anaconda Download](https://www.anaconda.com/download/success).
  - **Manually Add Anaconda to System Environment Variables**
    1. **Locate Your Anaconda Installation Path:**
       - Common default installation paths are:
         - For 64-bit systems: `C:\ProgramData\Anaconda3` or `C:\Users\<YourUsername>\Anaconda3`
         - For 32-bit systems: `C:\ProgramData\Anaconda2` or `C:\Users\<YourUsername>\Anaconda2`
    2. **Add the Path to Environment Variables:**
       - Open the **Settings** by pressing `Win + I` or by clicking on the Start menu and selecting "Settings."
       - In the Settings window, navigate to **System > About**.
       - Scroll down and click on **Advanced system settings** under the "Related settings" section on the right.
       - Click the "Environment Variables" button in the System Properties window that appears.
       - In the "System variables" section, find the `Path` variable and click "Edit."
       - In the window that pops up, click "New" and add the following paths:
         - `<Your Anaconda Installation Path>`
         - `<Your Anaconda Installation Path>\Scripts`
         - `<Your Anaconda Installation Path>\Library\bin`
       - Ensure these paths are added to the `Path` variable and click "OK" to save the changes.


## Environment Setup

To set up the environment for speech inference, follow these steps:

1. **Navigate to the directory containing the `.yml` file**  
   Open your terminal and change to the directory where the `speech_recognition_env.yml` file is located:

   ```bash
   cd path\to\yml\file
   ```
2. **Create the Conda environment**
   Create a new Conda environment using the .yml file. The environment will be created in the current directory under the name speech_recognition_env:

   ```bash
   conda env create -f speech_recognition_env.yml --prefix ./speech_recognition_env
   ```
3. **Activate the Conda environment**
   Once the environment is created, activate it with the following command:

   ```bash
   conda activate ./speech_recognition_env
   ```
## Usage
After activating the environment, you can run your speech inference scripts and tools as needed. Make sure to keep the environment activated while working with speech-related tasks.

## Deactivation
When you are done, you can deactivate the environment with:

   ```bash
   conda deactivate
   ```
## Removing the Environment
If you need to remove the environment for any reason, use the following command:
```bash
conda env remove --prefix ./speech_recognition_env
```

# 2. Speech Inference Models
Since this application works offline, you need to manually download the models. The required models are:
- **Distil-Whisper Model**: For speech-to-text inference. Reference: [Distil-Whisper](https://huggingface.co/distil-whisper/distil-medium.en)
- **Fine-tuned BERT-NER Model**: For named entity recognition (NER). It was trained from [BERT-base-NER](https://huggingface.co/dslim/bert-base-NER).

## Download the models
- Distil-Whisper model can be downloaded from [OneDrive-distil-whisper](https://liveuclac-my.sharepoint.com/:f:/g/personal/zczqlz8_ucl_ac_uk/EjaXEImTHjdBpFdY7Pc6KVsBbV2Bk5ZMKE9BD-zfS2f9EA?e=CHlIPW).
- NER model can be downloaded from [OneDrive-NER](https://liveuclac-my.sharepoint.com/:f:/g/personal/zczqlz8_ucl_ac_uk/ElPXHll5vghCt0XxEkY4fwIB0dMTP1ouwQKB04nr_bMXsw?e=uWA2VF).

## Setup Instructions
Once you have downloaded the model files from OneDrive:
1. **Extract the downloaded folder** to your local machine.
2. **Place the models in the application’s directory**:
    - Move the model's folder to the **same path** as the application's executable file for the application to detect the models automatically.
    
    Example structure:
    ```
    ./HoloRepository.exe
    ./distil_whisper_model/ (place the distil-whisper model files here)
    ./NER_model/ (place the fine-tuned BERT-NER model files here)
    ```
3. **Running the Application**:
   Simply double-click the executable file `HoloRepository.exe` to launch the application. It will automatically load the downloaded models and perform speech-to-text inference followed by NER extraction. No internet connection is required once the models are in place.


# 3. Change the Database Setting

Create a new database, restore the database using the file provided and change the parameters of connection string in DatabaseConnection.cs to your own.

The code to restore the file into your database is:

```bash
pg_restore --host=localhost --port=5432 --username=postgres --dbname=yourDBname --verbose "the\path\to\the\file "
```

# 4. Change the directory path to the Organ Slices

Change the directoryPath in the AddOrganSlice.cs to the path accessing the pictures stored in your computer.



