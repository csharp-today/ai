namespace EasyCloud.Services.TextToSpeech
{
    public class SpeechSynthesisMarkupLanguage
    {
        public string Text { get; }
        public Voice Voice { get; }

        public SpeechSynthesisMarkupLanguage(Voice voice, string text) => (Voice, Text) = (voice, text);

        public string ToXml() => $"<speak version='1.0' xmlns='https://www.w3.org/2001/10/synthesis' " +
            $"xml:lang='{Voice.Locale.ToString().Replace("_", "-")}'>" +
            $"<voice name='{Voice.ServiceName}'>{Text}</voice></speak>";

        public override string ToString() => ToXml();
    }
}
