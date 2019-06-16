using EasyCloud.Time;
using System.Collections.Generic;

namespace EasyCloud.Services.Tokens
{
    internal class AccessTokenProviderFactory : IAccessTokenProviderFactory
    {
        private readonly object _locker = new object();
        private readonly IDictionary<Region, ICachedAccessTokenProvider> _providers = new Dictionary<Region, ICachedAccessTokenProvider>();
        private readonly ITimeProvider _timeProvider;

        public AccessTokenProviderFactory(ITimeProvider timeProvider) => _timeProvider = timeProvider;

        public ICachedAccessTokenProvider GetProvider(Region region)
        {
            if (!_providers.ContainsKey(region))
            {
                lock (_locker)
                {
                    if (!_providers.ContainsKey(region))
                    {
                        _providers.Add(region, new CachedAccessTokenProvider(new AccessTokenProvider(region), _timeProvider));
                    }
                }
            }

            return _providers[region];
        }
    }
}
