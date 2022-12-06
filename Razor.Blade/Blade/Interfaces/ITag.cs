#if NETFRAMEWORK
using HtmlString = System.Web.HtmlString;
#else
using HtmlString = Microsoft.AspNetCore.Html.HtmlString;
#endif
using System.Collections.Generic;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Blade
{
    /// <summary>
    /// Standardizes what Tag-objects can do - valid for all Html and Svg tags.
    /// </summary>
    public interface ITag: IEnumerable<ITag>
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
