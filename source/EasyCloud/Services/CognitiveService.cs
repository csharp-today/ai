using EasyCloud.Services.TextToSpeech;
using EasyCloud.Services.Tokens;
using System;
using System.Threading.Tasks;

namespace EasyCloud.Services
{
    internal class CognitiveService : ICognitiveService
    {
        private readonly Lazy<ICachedAccessTokenProvider> _cachedAccessTokenProvider;
        private readonly string _key;
        private readonly ITextToSpeechConverter _textToSpeechConverter;

        public Region Region { get; }

        internal CognitiveService(IAccessTokenProviderFactory accessTokenProviderFactory, ITextToSpeechConverter textToSpeechConverter, Region region, string key)
        {
            (_textToSpeechConverter, Region, _key) = (textToSpeechConverter, region, key);
            _cachedAccessTokenProvider = new Lazy<ICachedAccessTokenProvider>(() =>
                accessTokenProviderFactory.GetProvider(Region));
        }

        public Task<string> GetAccessTokenAsync() => _cachedAccessTokenProvider.Value.GetAccessTokenAsync(_key);

        public Task<byte[]> TextToSpeech(Voice voice, string text) => TextToSpeech(voice, text, TtsAudios.Mp3.Audio16khz64kbitrateMono);

        public Task<byte[]> TextToSpeech(Voice voice, string text, Audio audio) => _textToSpeechConverter.GetSpeechAudioAsync(this, text, voice, audio);
    }
}
