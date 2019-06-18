using EasyCloud.Services;
using EasyCloud.Services.TextToSpeech;
using EasyCloud.Services.Tokens;
using EasyCloud.Time;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EasyCloud
{
    internal class DefaultContainer
    {
        private static readonly Lazy<IServiceProvider> _provider = new Lazy<IServiceProvider>(GetProvider);
        private static readonly Lazy<IServiceCollection> _services = new Lazy<IServiceCollection>(GetServices);

        internal static IServiceCollection Services => _services.Value;

        public static T Get<T>() => _provider.Value
            .GetService<T>() ?? throw new Exception($"Can't create object of type: {typeof(T)}");

        internal static object Get(Type type) => _provider.Value
            .GetService(type) ?? throw new Exception($"Can't create object of type: {type}");

        private static IServiceProvider GetProvider() => Services.BuildServiceProvider();

        private static IServiceCollection GetServices() => new ServiceCollection()
            .AddSingleton<IAccessTokenProviderFactory, AccessTokenProviderFactory>()
            .AddTransient<ICognitiveServiceFactory, CognitiveServiceFactory>()
            .AddTransient<ISpeechAudioGetter, SpeechAudioGetter>()
            .AddTransient<ITextToSpeechConverter, TextToSpeechConverter>()
            .AddTransient<ITimeProvider, TimeProvider>();
    }
}
