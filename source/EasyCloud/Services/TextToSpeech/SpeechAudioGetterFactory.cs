namespace EasyCloud.Services.TextToSpeech
{
    public class SpeechAudioGetterFactory : ISpeechAudioGetterFactory
    {
        public ISpeechAudioGetter CreateSpeechAudioGetter(Region region) => new SpeechAudioGetter(region);
    }
}
