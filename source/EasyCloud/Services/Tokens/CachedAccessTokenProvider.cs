using EasyCloud.Time;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyCloud.Services.Tokens
{
    public class CachedAccessTokenProvider : IAccessTokenProvider
    {
        private readonly IAccessTokenProvider _accessTokenProvider;
        private readonly IDictionary<string, (string token, DateTime expiration)> _cache = new Dictionary<string, (string, DateTime)>();
        private readonly ITimeProvider _timeProvider;

        public CachedAccessTokenProvider(IAccessTokenProvider baseProvider, ITimeProvider timeProvider) =>
            (_accessTokenProvider, _timeProvider) = (baseProvider, timeProvider);

        public async Task<string> GetAccessTokenAsync(string key)
        {
            if (_cache.ContainsKey(key)
                && _cache[key].expiration < _timeProvider.GetTime())
            {
                _cache.Remove(key);
            }

            if (!_cache.ContainsKey(key))
            {
                // Token is valid for 1h, let's keep 5 min margin
                var expiration = _timeProvider.GetTime().AddMinutes(55);
                var token = await _accessTokenProvider.GetAccessTokenAsync(key);
                _cache.Add(key, (token, expiration));
            }

            return _cache[key].token;
        }
    }
}
