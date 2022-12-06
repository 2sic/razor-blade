#if NETFRAMEWORK
using HtmlString = System.Web.HtmlString;
#else
using HtmlString = Microsoft.AspNetCore.Html.HtmlString;
#endif


namespace ToSic.Razor.Markup
{
    public partial class TagBase: ToHtmlHybridBase
    {
        #region .Open and .Close

        public HtmlString TagStart => new HtmlString(TagBuilder.Open(TagName, TagAttributes, TagOptions));

        public HtmlString TagEnd => new HtmlString(TagBuilder.Close(TagName));

        #endregion
    }
}
