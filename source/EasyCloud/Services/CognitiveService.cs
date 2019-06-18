using EasyCloud.Services.Tokens;
using System;
using System.Threading.Tasks;

namespace EasyCloud.Services
{
    internal class CognitiveService : ICognitiveService
    {
        private readonly Lazy<ICachedAccessTokenProvider> _cachedAccessTokenProvider;
        private readonly string _key;

        public Region Region { get; }

        internal CognitiveService(IAccessTokenProviderFactory accessTokenProviderFactory, Region region, string key)
        {
            (Region, _key) = (region, key);
            _cachedAccessTokenProvider = new Lazy<ICachedAccessTokenProvider>(() =>
                accessTokenProviderFactory.GetProvider(Region));
        }

        public Task<string> GetAccessTokenAsync() => _cachedAccessTokenProvider.Value.GetAccessTokenAsync(_key);
    }
}
