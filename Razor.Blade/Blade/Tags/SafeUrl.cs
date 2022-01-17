#if NET451
//using IHtmlString = System.Web.IHtmlString;
using HtmlString = System.Web.HtmlString;
#else
//using IHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;
using HtmlString = Microsoft.AspNetCore.Html.HtmlString;
//using HtmlEncoder = System.Text.Encodings.Web.HtmlEncoder;
#endif
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
        public static HtmlString SafeUrl(string url) => new HtmlString(TagBase.UriEncode(url));
    }
}
