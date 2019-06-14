using System.Threading.Tasks;

namespace EasyCloud.Services
{
    public interface IAccessTokenProvider
    {
        Task<string> GetAccessTokenAsync(string key);
    }
}
