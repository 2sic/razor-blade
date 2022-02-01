using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ToSic.Razor.Blade
{
    /// <summary>
    /// StartUp code to register default services provided by RazorBlade
    /// </summary>
    public static class StartUp
    {
        public static IServiceCollection AddRazorBlade(this IServiceCollection services)
        {
            services.TryAddTransient<IScrub, Scrub>();
            return services;
        }
    }
}
