using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoloRepository
{
    public static class GlobalEventManager
    {
        public static event Action<string>? OnGlobalTranscriptionReceived;

        public static void RaiseTranscriptionEvent(string transcription)
        {
            OnGlobalTranscriptionReceived?.Invoke(transcription);
        }
    }

}
