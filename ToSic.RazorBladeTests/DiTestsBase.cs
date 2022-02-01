using System;
using Microsoft.Extensions.DependencyInjection;
using ToSic.Razor.Blade;

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

        protected virtual void RegisterServices(IServiceCollection services)
        {
            services.AddRazorBlade();
        }
        private readonly IServiceProvider _serviceProvider;

        protected T GetService<T>() where T : class
            => _serviceProvider.GetRequiredService<T>();
    }
}