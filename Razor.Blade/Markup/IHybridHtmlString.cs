#if NETFRAMEWORK
using ToSic.Razor.Internals.Documentation;
using IHtmlString = System.Web.IHtmlString;
#else
using IHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;
#endif

namespace ToSic.Razor.Markup
{
    /// <summary>
    /// Adding 2023-06-01 to better re-use in 2sxc
    /// </summary>
    [PrivateApi]
    public interface IHybridHtmlString: IHtmlString
    {
    }
}
