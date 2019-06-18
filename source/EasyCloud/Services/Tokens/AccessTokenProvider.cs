using System.Net.Http;
using System.Threading.Tasks;

namespace EasyCloud.Services.Tokens
{
    public class AccessTokenProvider : IAccessTokenProvider
    {
        private readonly string _url;

        internal AccessTokenProvider(Region region) =>
            _url = $"https://{region.ToString().ToLower()}.api.cognitive.microsoft.com/sts/v1.0/issueToken";

        public async Task<string> GetAccessTokenAsync(string key)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", key);
            var result = await client.PostAsync(_url, null);
            var accessToken = await result.Content.ReadAsStringAsync();
            return accessToken;
        }
    }
}
