using System;
using Microsoft.Extensions.DependencyInjection;

namespace ToSic.RazorBladeTests
{
    public abstract class DiTestsBase
    {
        protected DiTestsBase()
        {
            var collection = new ServiceCollection();
            RegisterServices(collection);
            _serviceProvider = collection.BuildServiceProvider();
        }

        protected abstract void RegisterServices(ServiceCollection services);
        private IServiceProvider _serviceProvider;

        protected T GetService<T>() => _serviceProvider.GetRequiredService<T>();
    }
}