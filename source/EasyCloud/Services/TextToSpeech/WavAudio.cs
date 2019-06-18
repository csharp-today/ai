namespace EasyCloud.Services.TextToSpeech
{
    public class WavAudio
    {
        public readonly Audio Raw8khz8bitMonoMulaw = new Audio("raw-8khz-8bit-mono-mulaw");
        public readonly Audio Raw16khz16bitMonoPcm = new Audio("raw-16khz-16bit-mono-pcm");
        public readonly Audio Raw24khz16bitMonoPcm = new Audio("raw-24khz-16bit-mono-pcm");
        public readonly Audio Riff8khz8bitMonoAlaw = new Audio("riff-8khz-8bit-mono-alaw");
        public readonly Audio Riff8khz8bitMonoMulaw = new Audio("riff-8khz-8bit-mono-mulaw");
        public readonly Audio Riff16khz16bitMonoPcm = new Audio("riff-16khz-16bit-mono-pcm");
        public readonly Audio Riff24khz16bitMonoPcm = new Audio("riff-24khz-16bit-mono-pcm");
    }
}
