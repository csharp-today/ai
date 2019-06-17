namespace EasyCloud.Services.TextToSpeech
{
    public class Voice
    {
        public Locale Locale { get; }
        public string Language { get; }
        public Gender Gender { get; }
        public string ServiceName { get; }

        public Voice(Locale locale, string language, Gender gender, string serviceName) =>
            (Locale, Language, Gender, ServiceName) = (locale, language, gender, serviceName);
    }
}
