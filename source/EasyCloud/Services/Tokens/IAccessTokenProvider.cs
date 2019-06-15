using System.Threading.Tasks;

namespace EasyCloud.Services.Tokens
{
    public interface IAccessTokenProvider
    {
        Task<string> GetAccessTokenAsync(string key);
    }
}
