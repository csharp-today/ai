using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using System.IO;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace AI.TextToSpeech.PoC
{
    public class Program
    {
        public static async Task Main()
        {
            var accessToken = await GetAccessToken();

            var voices = new[] { "ZiraRUS", "JessaRUS", "BenjaminRUS", "Jessa24kRUS", "Guy24kRUS" };
            foreach (var voice in voices)
            {
                Console.WriteLine("Voice EN " + voice);
                await SpeakEn(accessToken, voice);
            }

            Console.WriteLine("Voice PL PaulinaRUS");
            await Speak(accessToken, "pl-PL", "PaulinaRUS", "Podsumujmy ten program. Jest świetny!");
        }

        private static async Task<string> GetAccessToken()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", config["AzureKey"]);
            var uriBuilder = new UriBuilder("https://westeurope.api.cognitive.microsoft.com/sts/v1.0/issueToken");
            var result = await client.PostAsync(uriBuilder.Uri.AbsoluteUri, null);
            var accessToken = await result.Content.ReadAsStringAsync();

            return accessToken;
        }

        private static async Task Speak(string accessToken, string lang, string voice, string text)
        {
            var host = @"https://westeurope.tts.speech.microsoft.com/cognitiveservices/v1";
            var body = $@"<speak version='1.0' xmlns='https://www.w3.org/2001/10/synthesis' xml:lang='en-US'>
              <voice name='Microsoft Server Speech Text to Speech Voice ({lang}, {voice})'>" +
              text + "</voice></speak>";

            using var client2 = new HttpClient();
            using var request = new HttpRequestMessage();
            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(host);
            request.Content = new StringContent(body, Encoding.UTF8, "application/ssml+xml");
            request.Headers.Add("Authorization", "Bearer " + accessToken);
            request.Headers.Add("Connection", "Keep-Alive");
            request.Headers.Add("User-Agent", "AI.TextToSpeech.PoC");
            request.Headers.Add("X-Microsoft-OutputFormat", "riff-24khz-16bit-mono-pcm");

            using var response = await client2.SendAsync(request);
            response.EnsureSuccessStatusCode();

            using var dataStream = await response.Content.ReadAsStreamAsync();
            using var fileStream = new FileStream(@"sample.wav", FileMode.Create, FileAccess.Write, FileShare.Write);
            await dataStream.CopyToAsync(fileStream).ConfigureAwait(false);
            fileStream.Close();

            Process.Start(@"powershell", $@"-c (New-Object Media.SoundPlayer 'sample.wav').PlaySync();").WaitForExit();
        }

        private static Task SpeakEn(string accessToken, string voice) => Speak(accessToken, "en-US", voice, "Let's summarize this program. It's awesome!");
    }
}
