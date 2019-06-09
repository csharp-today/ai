using EasyCloud.Services;

namespace EasyCloud
{
    public static class RegionExtensions
    {
        public static ICognitiveService GetCognitiveService(this Region region, string cognitiveServiceKey) => new CognitiveService(region, cognitiveServiceKey);
    }
}
