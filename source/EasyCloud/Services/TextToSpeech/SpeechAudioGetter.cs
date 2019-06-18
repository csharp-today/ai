using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EasyCloud.Services.TextToSpeech
{
    public class SpeechAudioGetter : ISpeechAudioGetter
    {
        private readonly string _url;

        public SpeechAudioGetter(Region region) =>
            _url = @$"https://{region.ToString().ToLower()}.tts.speech.microsoft.com/cognitiveservices/v1";

        public async Task<byte[]> GetSpeechAudio(string accessToken, SpeechSynthesisMarkupLanguage ssml, Audio audio)
        {
            using var calient = new HttpClient();
            using var request = new HttpRequestMessage();
            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(_url);
            request.Content = new StringContent(ssml.ToXml(), Encoding.UTF8, "application/ssml+xml");
            request.Headers.Add("Authorization", "Bearer " + accessToken);
            request.Headers.Add("Connection", "Keep-Alive");
            request.Headers.Add("User-Agent", nameof(EasyCloud));
            request.Headers.Add("X-Microsoft-OutputFormat", audio.Name);

            using var response = await calient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
