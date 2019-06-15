namespace EasyCloud.Services
{
    internal class CognitiveService : ICognitiveService
    {
        private readonly string _key;

        public Region Region { get; }

        public CognitiveService(Region region, string key) => (Region, _key) = (region, key);
    }
}
