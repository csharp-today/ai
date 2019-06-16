using EasyCloud;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;

namespace EasyCloudTest
{
    [TestClass]
    public class DefaultContainerTest
    {
        [TestMethod]
        public void Test_Container()
        {
            foreach (var serviceDescription in DefaultContainer.Services)
            {
                TestService(serviceDescription.ServiceType);
            }
        }

        private void TestService(Type type) => DefaultContainer.Get(type).ShouldNotBeNull();
    }
}
