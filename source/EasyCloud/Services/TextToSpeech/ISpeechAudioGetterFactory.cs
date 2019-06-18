namespace EasyCloud.Services.TextToSpeech
{
    public interface ISpeechAudioGetterFactory
    {
        ISpeechAudioGetter CreateSpeechAudioGetter(Region region);
    }
}
