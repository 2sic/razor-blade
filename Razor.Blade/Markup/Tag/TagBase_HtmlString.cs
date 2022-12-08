
namespace ToSic.Razor.Markup
{
    public partial class TagBase: RawHtmlString
    {
        #region .Open and .Close

        public RawHtmlString TagStart => new RawHtmlString(TagBuilder.Open(TagName, TagAttributes, TagOptions));

        public RawHtmlString TagEnd => new RawHtmlString(TagBuilder.Close(TagName));

        #endregion
    }
}
