using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    public class ScrubBase: DiTestsBase
    {
        /// <inheritdoc />
        protected override void RegisterServices(ServiceCollection services)
        {
            services.TryAddTransient<IScrub, Scrub>();
        }
    }
}
