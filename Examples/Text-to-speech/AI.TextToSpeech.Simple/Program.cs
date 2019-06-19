using EasyCloud;
using EasyCloud.WindowsOnly;
using System.Threading.Tasks;

namespace AI.TextToSpeech.Simple
{
    public class Program
    {
        public static Task Main() => Region.WestEurope
            .GetCognitiveService("put-cognitive-service-key-here")
            .SpeakEnglishWomanAsync("Hello World!")
            .SpeakEnglishManAsync("Hello World!")
            .SpeakPolishAsync("Witaj świecie!");
    }
}
