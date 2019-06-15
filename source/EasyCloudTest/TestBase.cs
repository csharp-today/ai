using Ninject;
using Ninject.MockingKernel.NSubstitute;
using System;

namespace EasyCloudTest
{
    public class TestBase : IDisposable
    {
        protected NSubstituteMockingKernel Kernel { get; } = new NSubstituteMockingKernel();
        public void Dispose() => Kernel.Dispose();
        protected T Get<T>() => Kernel.Get<T>();
    }
}
