using System.Collections.Generic;
using System.Linq;

namespace EasyCloud.Services.TextToSpeech
{
    public static class TtsVoices
    {
        public static readonly IEnumerable<Voice> All;
        public static readonly TtsNaturalVoices Natural = new TtsNaturalVoices();
        public static readonly TtsStandardVoices Standard = new TtsStandardVoices();

        static TtsVoices() => All = Natural.All.Concat(Standard.All).ToArray();
    }
}
