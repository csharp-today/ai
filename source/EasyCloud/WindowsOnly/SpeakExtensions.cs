using EasyCloud.Services;
using EasyCloud.Services.TextToSpeech;
using System.Threading.Tasks;

namespace EasyCloud.WindowsOnly
{
    public static class SpeakExtensions
    {
        public static async Task<ICognitiveService> SpeakAsync(this ICognitiveService service, Voice voice, string text)
        {
            await service.TextToSpeech(voice, text, TtsAudios.Wav.Riff16khz16bitMonoPcm).PlayWavAsync();
            return service;
        }

        public static async Task<ICognitiveService> SpeakAsync(this Task<ICognitiveService> serviceTask, Voice voice, string text) =>
            await (await serviceTask).SpeakAsync(voice, text);

        public static Task<ICognitiveService> SpeakEnglishManAsync(this ICognitiveService service, string text) =>
            service.SpeakAsync(TtsVoices.Natural.en_US_GuyNeural, text);

        public static async Task<ICognitiveService> SpeakEnglishManAsync(this Task<ICognitiveService> serviceTask, string text) =>
            await (await serviceTask).SpeakEnglishManAsync(text);

        public static Task<ICognitiveService> SpeakEnglishWomanAsync(this ICognitiveService service, string text) =>
            service.SpeakAsync(TtsVoices.Natural.en_US_JessaNeural, text);

        public static async Task<ICognitiveService> SpeakEnglishWomanAsync(this Task<ICognitiveService> serviceTask, string text) =>
            await (await serviceTask).SpeakEnglishWomanAsync(text);

        public static Task<ICognitiveService> SpeakPolishAsync(this ICognitiveService service, string text) =>
            service.SpeakAsync(TtsVoices.Standard.pl_PL_PaulinaRUS, text);

        public static async Task<ICognitiveService> SpeakPolishAsync(this Task<ICognitiveService> serviceTask, string text) =>
            await (await serviceTask).SpeakPolishAsync(text);
    }
}
