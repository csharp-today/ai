using EasyCloud;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LucidCode;
using EasyCloud.Services.Tokens;
using Shouldly;

namespace EasyCloudTest.Services.Tokens
{
    [TestClass]
    public class AccessTokenProviderFactoryTest : TestBase
    {
        [DataTestMethod]
        [DataRow(Region.WestEurope)]
        [DataRow(Region.NorthEurope)]
        public void Get_The_Same_Provider_Instance(Region region) => LucidTest
            .Arrange(() => Get<AccessTokenProviderFactory>())
            .Act(factory => new
            {
                Provider1 = factory.GetProvider(region),
                Provider2 = factory.GetProvider(region)
            })
            .Assert(providers => providers.Provider1.ShouldBe(providers.Provider2));
    }
}
