using System.Collections.Generic;

namespace EasyCloud.Services.TextToSpeech
{
    // Imported from: https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/language-support#text-to-speech
    public class TtsNaturalVoices
    {
        public readonly IEnumerable<Voice> All;
        
        internal TtsNaturalVoices() => All = new[]
        {
            de_DE_KatjaNeural, en_US_GuyNeural, en_US_JessaNeural, it_IT_ElsaNeural, zh_CN_XiaoxiaoNeural
        };

        public readonly Voice de_DE_KatjaNeural = new Voice(Locale.de_DE, "German (Germany)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (de-DE, KatjaNeural)");
        public readonly Voice en_US_GuyNeural = new Voice(Locale.en_US, "English (US)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (en-US, GuyNeural)");
        public readonly Voice en_US_JessaNeural = new Voice(Locale.en_US, "English (US)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-US, JessaNeural)");
        public readonly Voice it_IT_ElsaNeural = new Voice(Locale.it_IT, "Italian (Italy)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (it-IT, ElsaNeural)");
        public readonly Voice zh_CN_XiaoxiaoNeural = new Voice(Locale.zh_CN, "Chinese (Mainland)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (zh-CN, XiaoxiaoNeural)");
    }
}
