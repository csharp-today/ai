using EasyCloud.Time;
using System;
using System.Threading.Tasks;

namespace EasyCloud.Services.Tokens
{
    public class CachedAccessTokenProvider : IAccessTokenProvider
    {
        private readonly IAccessTokenProvider _accessTokenProvider;
        private readonly ITimeProvider _timeProvider;

        private string _token;
        private DateTime _tokenExpiration;

        public CachedAccessTokenProvider(IAccessTokenProvider baseProvider, ITimeProvider timeProvider) =>
            (_accessTokenProvider, _timeProvider) = (baseProvider, timeProvider);

        public async Task<string> GetAccessTokenAsync(string key)
        {
            if (_tokenExpiration < _timeProvider.GetTime())
            {
                _token = null;
            }

            if (_token is null)
            {
                // Token is valid for 1h, let's keep 5 min margin
                _tokenExpiration = _timeProvider.GetTime().AddMinutes(55);
                _token = await _accessTokenProvider.GetAccessTokenAsync(key);
            }

            return _token;
        }
    }
}
