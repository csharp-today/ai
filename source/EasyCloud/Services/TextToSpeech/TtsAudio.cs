namespace EasyCloud.Services.TextToSpeech
{
    // Imported from https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/rest-text-to-speech#audio-outputs
    public static class TtsAudio
    {
        public static readonly Mp3Audio Mp3 = new Mp3Audio();
        public static readonly WavAudio Wav = new WavAudio();
    }
}
