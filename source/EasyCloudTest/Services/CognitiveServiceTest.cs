using EasyCloud;
using EasyCloud.Services;
using EasyCloud.Services.TextToSpeech;
using EasyCloud.Services.Tokens;
using LucidCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Shouldly;
using System.Linq;

namespace EasyCloudTest.Services
{
    [TestClass]
    public class CognitiveServiceTest : TestBase
    {
        [DataTestMethod]
        [DataRow(Region.WestEurope)]
        [DataRow(Region.NorthEurope)]
        public void AccessToken_From_AccessTokenProvider(Region region) => LucidTest
            .DefineExpected("expectedAccessToken")
            .Arrange(token =>
            {
                const string Key = "serviceKey";
                var provider = Get<ICachedAccessTokenProvider>();
                provider.GetAccessTokenAsync(Key).Returns(token);
                Get<IAccessTokenProviderFactory>().GetProvider(region).Returns(provider);
                return Key;
            })
            .Act(key => GetService(region, key).GetAccessTokenAsync().Result)
            .Assert((expectedToken, token) => token.ShouldBe(expectedToken));

        [TestMethod]
        public void Call_TextToSpeech() => LucidTest
            .DefineExpected(new byte[] { 123 })
            .Arrange(data =>
            {
                const string Text = "some text";
                var audio = TtsAudios.Wav.Riff16khz16bitMonoPcm;
                var voice = TtsVoices.Standard.pl_PL_PaulinaRUS;

                Get<ITextToSpeechConverter>()
                    .GetSpeechAudioAsync(Arg.Any<ICognitiveService>(), Text, voice, audio)
                    .Returns(data);

                return new
                {
                    Audio = audio,
                    Service = GetService(Region.WestEurope, ""),
                    Text,
                    Voice = voice
                };
            })
            .Act(param => param.Service.TextToSpeech(param.Voice, param.Text, param.Audio).Result)
            .Assert((expectedData, data) => data.ShouldBe(expectedData));

        [TestMethod]
        public void Call_TextToSpeech_With_Default_Audio() => LucidTest
            .DefineExpected(new byte[] { 123 })
            .Arrange(data => Get<ITextToSpeechConverter>()
                .GetSpeechAudioAsync(Arg.Any<ICognitiveService>(), Arg.Any<string>(), Arg.Any<Voice>(), TtsAudios.Mp3.Audio16khz64kbitrateMono)
                .Returns(data))
            .Act(_ => GetService(Region.WestEurope, "").TextToSpeech(TtsVoices.All.First(), "").Result)
            .Assert((expectedData, data) => data.ShouldBe(expectedData));

        [DataTestMethod]
        [DataRow(Region.WestEurope)]
        [DataRow(Region.NorthEurope)]
        public void Get_Proper_Region(Region expectedRegion) => LucidTest
            .Act(() => GetService(expectedRegion, null))
            .Assert(service => service.Region.ShouldBe(expectedRegion));

        private ICognitiveService GetService(Region region, string key) =>
            Get<CognitiveServiceFactory>().CreateCognitiveService(region, key);
    }
}
