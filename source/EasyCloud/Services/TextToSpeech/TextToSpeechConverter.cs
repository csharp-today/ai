using System.Threading.Tasks;

namespace EasyCloud.Services.TextToSpeech
{
    public class TextToSpeechConverter : ITextToSpeechConverter
    {
        private readonly ISpeechAudioGetter _speechAudioGetter;

        public TextToSpeechConverter(ISpeechAudioGetter speechAudioGetter) => _speechAudioGetter = speechAudioGetter;

        public async Task<byte[]> GetSpeechAudioAsync(ICognitiveService cognitiveService, string text, Voice voice, Audio audio)
        {
            var tokenTask = cognitiveService.GetAccessTokenAsync();
            var ssml = new SpeechSynthesisMarkupLanguage(voice, text);
            return await _speechAudioGetter.GetSpeechAudioAsync(cognitiveService.Region, await tokenTask, ssml, audio);
        }
    }
}
