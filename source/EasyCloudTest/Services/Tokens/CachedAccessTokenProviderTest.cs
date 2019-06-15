﻿using EasyCloud.Services.Tokens;
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
            var token1 = await Get<CachedAccessTokenProvider>().GetAccessTokenAsync(ExpectedKey);
            var token2 = await Get<CachedAccessTokenProvider>().GetAccessTokenAsync(ExpectedKey);

            // Assert
            token1.ShouldBe(ExpectedToken);
            token2.ShouldBe(ExpectedToken);
            callCount.ShouldBe(1);
        }

        [TestMethod]
        public async Task Call_Base_Provider_Twice()
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
            var token1 = await Get<CachedAccessTokenProvider>().GetAccessTokenAsync(ExpectedKey);
            timeProvider.GetTime().Returns(DateTime.Now);
            var token2 = await Get<CachedAccessTokenProvider>().GetAccessTokenAsync(ExpectedKey);

            // Assert
            token1.ShouldBe(ExpectedToken);
            token2.ShouldBe(ExpectedToken);
            callCount.ShouldBe(2);
        }
    }
}
