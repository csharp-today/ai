using System.Threading.Tasks;

namespace EasyCloud.Services.TextToSpeech
{
    public interface ISpeechAudioGetter
    {
        Task<byte[]> GetSpeechAudio(string accessToken, SpeechSynthesisMarkupLanguage ssml, Audio audio);
    }
}
