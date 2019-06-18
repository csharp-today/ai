using System.Threading.Tasks;

namespace EasyCloud.Services.TextToSpeech
{
    public interface ISpeechAudioGetter
    {
        Task<byte[]> GetSpeechAudioAsync(Region region, string accessToken, SpeechSynthesisMarkupLanguage ssml, Audio audio);
    }
}
