using EasyCloud.Services.TextToSpeech;
using EasyCloud.Services.Tokens;

namespace EasyCloud.Services
{
    internal class CognitiveServiceFactory : ICognitiveServiceFactory
    {
        private readonly IAccessTokenProviderFactory _accessTokenProviderFactory;
        private readonly ITextToSpeechConverter _textToSpeechConverter;

        public CognitiveServiceFactory(IAccessTokenProviderFactory accessTokenProviderFactory, ITextToSpeechConverter textToSpeechConverter) =>
            (_accessTokenProviderFactory, _textToSpeechConverter) = (accessTokenProviderFactory, textToSpeechConverter);

        public ICognitiveService CreateCognitiveService(Region region, string cognitiveServiceKey) =>
            new CognitiveService(_accessTokenProviderFactory, _textToSpeechConverter, region, cognitiveServiceKey);
    }
}
