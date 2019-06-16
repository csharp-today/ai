using EasyCloud;
using EasyCloud.Services;
using EasyCloud.Services.Tokens;
using LucidCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Shouldly;

namespace EasyCloudTest.Services
{
    [TestClass]
    public class CognitiveServiceTest : TestBase
    {
        [DataTestMethod]
        [DataRow(Region.WestEurope)]
        [DataRow(Region.NorthEurope)]
        public void AccessToken_From_AccessTokenProvider(Region region) => LucidTest
            .DefineExpected("expectedAccessToken")
            .Arrange(token =>
            {
                const string Key = "serviceKey";
                var provider = Get<ICachedAccessTokenProvider>();
                provider.GetAccessTokenAsync(Key).Returns(token);
                Get<IAccessTokenProviderFactory>().GetProvider(region).Returns(provider);
                return Key;
            })
            .Act(key => GetService(region, key).GetAccessTokenAsync().Result)
            .Assert((expectedToken, token) => token.ShouldBe(expectedToken));

        [DataTestMethod]
        [DataRow(Region.WestEurope)]
        [DataRow(Region.NorthEurope)]
        public void Get_Proper_Region(Region expectedRegion) => LucidTest
            .Act(() => GetService(expectedRegion, null))
            .Assert(service => service.Region.ShouldBe(expectedRegion));

        private ICognitiveService GetService(Region region, string key) =>
            Get<CognitiveServiceFactory>().CreateCognitiveService(region, key);
    }
}
