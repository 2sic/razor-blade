using ToSic.Razor.Internals.Documentation;
#if NETFRAMEWORK
using IHtmlString = System.Web.IHtmlString;
#else
using IHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;
#endif

namespace ToSic.Razor.Markup
{
    /// <summary>
    /// Adding 2023-06-01 to better re-use in inheriting systems such as 2sxc.
    /// </summary>
    [PrivateApi]
    public interface IRawHtmlString: IHtmlString
    {
    }
}
