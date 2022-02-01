using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ToSic.Razor.Blade
{
    /// <summary>
    /// StartUp code to register default services provided by RazorBlade
    /// </summary>
    public static class StartUp
    {
        /// <summary>
        /// Use this in your StartUp to add the default RazorBlade services to the DependencyInjection
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRazorBlade(this IServiceCollection services)
        {
            services.TryAddTransient<IScrub, Scrub>();
            return services;
        }
    }
}
