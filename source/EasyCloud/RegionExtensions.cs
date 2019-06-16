using EasyCloud.Services;

namespace EasyCloud
{
    public static class RegionExtensions
    {
        public static ICognitiveService GetCognitiveService(this Region region, string cognitiveServiceKey) =>
            DefaultContainer.Get<ICognitiveServiceFactory>().CreateCognitiveService(region, cognitiveServiceKey);
    }
}
