
namespace ToSic.Razor.Markup
{
    public partial class TagBase: DotNetHtmlString
    {
        #region .Open and .Close

        public DotNetHtmlString TagStart => new DotNetHtmlString(TagBuilder.Open(TagName, TagAttributes, TagOptions));

        public DotNetHtmlString TagEnd => new DotNetHtmlString(TagBuilder.Close(TagName));

        #endregion
    }
}
