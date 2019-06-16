namespace EasyCloud.Services
{
    public interface ICognitiveServiceFactory
    {
        ICognitiveService CreateCognitiveService(Region region, string cognitiveServiceKey);
    }
}
