#if NET40
using IHtmlString = System.Web.IHtmlString;
using HtmlString = System.Web.HtmlString;
#else
using IHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;
using HtmlString = Microsoft.AspNetCore.Html.HtmlString;
#endif
using ToSic.Razor.Markup;

namespace ToSic.Razor.Markup
{
    /// <summary>
    /// Standardizes what Tag-objects can do - valid for all Html and Svg tags.
    /// </summary>
    public interface ITag
    {
        /// <summary>
        /// All attributes of this tag
        /// </summary>
        AttributeList TagAttributes { get; }

        /// <summary>
        /// The tag name
        /// </summary>
        string TagName { get; }

        /// <summary>
        /// Gets the HTML encoded value.
        /// </summary>
        string ToString();

        #region .Open and .Close

        HtmlString TagStart {get; }
        HtmlString TagEnd { get; }
        #endregion
    }
}
