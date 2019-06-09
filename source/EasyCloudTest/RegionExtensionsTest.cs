using EasyCloud;
using LucidCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace EasyCloudTest
{
    [TestClass]
    public class RegionExtensionsTest
    {
        [DataTestMethod]
        [DataRow(Region.WestEurope)]
        [DataRow(Region.NorthEurope)]
        public void Get_Cognitive_Service(Region expectedRegion) => LucidTest
            .Act(() => expectedRegion.GetCognitiveService("key"))
            .Assert(service =>
            {
                service.ShouldNotBeNull();
                service.Region.ShouldBe(expectedRegion);
            });
    }
}
