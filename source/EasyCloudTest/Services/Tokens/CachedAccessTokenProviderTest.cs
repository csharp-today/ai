using EasyCloud.Services.Tokens;
using EasyCloud.Time;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Shouldly;
using System;
using System.Threading.Tasks;

namespace EasyCloudTest.Services.Tokens
{
    [TestClass]
    public class CachedAccessTokenProviderTest : TestBase
    {
        [TestMethod]
        public async Task Call_Base_Provider_Once()
        {
            // Arrange
            var baseProvider = Get<IAccessTokenProvider>();

            const string ExpectedKey = "someKey", ExpectedToken = "token";
            int callCount = 0;
            baseProvider.GetAccessTokenAsync(ExpectedKey).Returns(callInfo =>
            {
                callCount++;
                return ExpectedToken;
            });

            // Act
            var cachedProvider = GetCachedProvider();
            var token1 = await cachedProvider.GetAccessTokenAsync(ExpectedKey);
            var token2 = await cachedProvider.GetAccessTokenAsync(ExpectedKey);

            // Assert
            token1.ShouldBe(ExpectedToken);
            token2.ShouldBe(ExpectedToken);
            callCount.ShouldBe(1);
        }

        [TestMethod]
        public async Task Call_Base_Provider_Twice_After_Expiration()
        {
            // Arrange
            var baseProvider = Get<IAccessTokenProvider>();

            const string ExpectedKey = "someKey", ExpectedToken = "token";
            int callCount = 0;
            baseProvider.GetAccessTokenAsync(ExpectedKey).Returns(callInfo =>
            {
                callCount++;
                return ExpectedToken;
            });

            var timeProvider = Get<ITimeProvider>();
            timeProvider.GetTime().Returns(DateTime.Now.AddDays(-1));

            // Act
            var cachedProvider = GetCachedProvider();
            var token1 = await cachedProvider.GetAccessTokenAsync(ExpectedKey);
            timeProvider.GetTime().Returns(DateTime.Now);
            var token2 = await cachedProvider.GetAccessTokenAsync(ExpectedKey);

            // Assert
            token1.ShouldBe(ExpectedToken);
            token2.ShouldBe(ExpectedToken);
            callCount.ShouldBe(2);
        }

        [TestMethod]
        public async Task Call_Base_Provider_Twice_For_Different_Keys()
        {
            // Arrange
            var baseProvider = Get<IAccessTokenProvider>();

            const string ExpectedToken = "token";
            int callCount = 0;
            baseProvider.GetAccessTokenAsync(null).ReturnsForAnyArgs(callInfo =>
            {
                callCount++;
                return ExpectedToken;
            });

            // Act
            var cachedProvider = GetCachedProvider();
            var token1 = await cachedProvider.GetAccessTokenAsync("key1");
            var token2 = await cachedProvider.GetAccessTokenAsync("key2");

            // Assert
            token1.ShouldBe(ExpectedToken);
            token2.ShouldBe(ExpectedToken);
            callCount.ShouldBe(2);
        }

        private CachedAccessTokenProvider GetCachedProvider() => new CachedAccessTokenProvider(Get<IAccessTokenProvider>(), Get<ITimeProvider>());
    }
}
