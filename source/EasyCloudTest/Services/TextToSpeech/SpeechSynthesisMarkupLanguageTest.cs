using EasyCloud.Services.TextToSpeech;
using LucidCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace EasyCloudTest.Services.TextToSpeech
{
    [TestClass]
    public class SpeechSynthesisMarkupLanguageTest
    {
        const Locale ExpectedLocale = Locale.pl_PL;
        const string ExpectedXml = "<speak version='1.0' xmlns='https://www.w3.org/2001/10/synthesis' " +
            "xml:lang='pl-PL'><voice name='" + VoiceName + "'>" + Text + "</voice></speak>";
        const string Text = "TEXT";
        const string VoiceName = "VOICE-NAME";

        [TestMethod]
        public void Expected_Xml() => LucidTest
            .Arrange(() => new Voice(ExpectedLocale, "", Gender.Female, VoiceName))
            .Act(voice => new SpeechSynthesisMarkupLanguage(voice, Text))
            .Assert(ssml =>
            {
                ssml.ToXml().ShouldBe(ExpectedXml);
                ssml.ToString().ShouldBe(ExpectedXml);
            });
    }
}
