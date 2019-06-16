using EasyCloud.Services.Tokens;

namespace EasyCloud.Services
{
    internal class CognitiveServiceFactory : ICognitiveServiceFactory
    {
        private readonly IAccessTokenProviderFactory _accessTokenProviderFactory;

        public CognitiveServiceFactory(IAccessTokenProviderFactory accessTokenProviderFactory) =>
            _accessTokenProviderFactory = accessTokenProviderFactory;

        public ICognitiveService CreateCognitiveService(Region region, string cognitiveServiceKey) =>
            new CognitiveService(_accessTokenProviderFactory, region, cognitiveServiceKey);
    }
}
