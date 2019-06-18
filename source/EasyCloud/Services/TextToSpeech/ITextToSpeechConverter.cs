using System.Threading.Tasks;

namespace EasyCloud.Services.TextToSpeech
{
    public interface ITextToSpeechConverter
    {
        Task<byte[]> GetSpeechAudioAsync(ICognitiveService cognitiveService, string text, Voice voice, Audio audio);
    }
}
