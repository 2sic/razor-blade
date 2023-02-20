using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ToSic.Razor.Blade;

namespace ToSic.Razor.StartUp
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
            services.TryAddTransient<IScrub, ScrubImplementation>();
            services.TryAddTransient<IHtmlTagsService, HtmlTagsServiceImplementation>();
            return services;
        }

        // 2022-12-06 2dm - removed in v4, not used in 2sxc any more
        ///// <summary>
        ///// Special helper class to register startup stuff from the hosting application
        /////
        ///// ATM just important because .net standard 2 doesn't have a built in ToJson method
        ///// so the environment must provide it at startup.
        /////
        ///// This is not needed for .net Framework or .net Core 5+
        ///// </summary>
        //[PrivateApi("Probably not used any more... will be deprecated soon")]
        //private static void RegisterToJson(Func<object, string> toJsonFunc)
        //{
        //    Html.ObjToJsonString = toJsonFunc;
        //}
    }
}
