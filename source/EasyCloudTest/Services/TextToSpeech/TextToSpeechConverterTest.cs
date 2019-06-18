using EasyCloud;
using EasyCloud.Services;
using EasyCloud.Services.TextToSpeech;
using LucidCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Shouldly;

namespace EasyCloudTest.Services.TextToSpeech
{
    [TestClass]
    public class TextToSpeechConverterTest : TestBase
    {
        [DataTestMethod]
        [DataRow(Region.WestEurope, "accessToken", "my text")]
        [DataRow(Region.NorthEurope, "otherToken", "more text")]
        public void Call_SpeechAudioGetter(Region region, string token, string text) => LucidTest
            .DefineExpected(() => new
            {
                ExpectedAudio = TtsAudios.Wav.Raw16khz16bitMonoPcm,
                ExpectedData = new byte[] { 123 },
                ExpectedVoice = TtsVoices.Standard.pl_PL_PaulinaRUS
            })
            .Arrange(expectedData =>
            {
                var cognitiveService = Get<ICognitiveService>();
                cognitiveService.Region.Returns(region);
                cognitiveService.GetAccessTokenAsync().Returns(token);

                var audioGetter = Get<ISpeechAudioGetter>();
                audioGetter.GetSpeechAudioAsync(region, token, Arg.Any<SpeechSynthesisMarkupLanguage>(), expectedData.ExpectedAudio)
                    .Returns(callInfo =>
                    {
                        var ssml = callInfo.Arg<SpeechSynthesisMarkupLanguage>();
                        if (ssml?.Text == text && ssml?.Voice == expectedData.ExpectedVoice)
                        {
                            return expectedData.ExpectedData;
                        }
                        return null;
                    });

                return new
                {
                    Audio = expectedData.ExpectedAudio,
                    CognitiveService = cognitiveService,
                    Converter = new TextToSpeechConverter(audioGetter),
                    Voice = expectedData.ExpectedVoice
                };
            })
            .Act(param => param.Converter.GetSpeechAudioAsync(param.CognitiveService, text, param.Voice, param.Audio).Result)
            .Assert((expectedData, data) => data.ShouldBe(expectedData.ExpectedData));
    }
}
