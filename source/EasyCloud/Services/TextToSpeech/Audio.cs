namespace EasyCloud.Services.TextToSpeech
{
    public class Audio
    {
        public string Name { get; }
        internal Audio(string name) => Name = name;
        public override string ToString() => Name;
    }
}
