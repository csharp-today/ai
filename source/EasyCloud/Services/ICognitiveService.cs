using System.Threading.Tasks;

namespace EasyCloud.Services
{
    public interface ICognitiveService
    {
        Region Region { get; }
        Task<string> GetAccessTokenAsync();
    }
}
