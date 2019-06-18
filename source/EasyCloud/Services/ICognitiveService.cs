using EasyCloud.Services.TextToSpeech;
using System.Threading.Tasks;

namespace EasyCloud.Services
{
    public interface ICognitiveService
    {
        Region Region { get; }
        Task<string> GetAccessTokenAsync();
        Task<byte[]> TextToSpeech(Voice voice, string text);
        Task<byte[]> TextToSpeech(Voice voice, string text, Audio audio);
    }
}
