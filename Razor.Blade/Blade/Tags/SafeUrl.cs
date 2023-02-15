using ToSic.Razor.Internals;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Blade
{
    public partial class Tags
    {
        /// <summary>
        /// Convert URLs into a safe format, to properly escape spaces, umlauts, etc.
        /// Important for images etc. which may have special characters
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static RawHtmlString SafeUrl(string url) => new RawHtmlString(UriHelpers.UriEncode(url));
    }
}
