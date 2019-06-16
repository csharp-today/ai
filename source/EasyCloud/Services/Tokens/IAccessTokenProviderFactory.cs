namespace EasyCloud.Services.Tokens
{
    public interface IAccessTokenProviderFactory
    {
        ICachedAccessTokenProvider GetProvider(Region region);
    }
}
