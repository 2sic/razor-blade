#if NET451
using IHtmlString = System.Web.IHtmlString;
using HtmlString = System.Web.HtmlString;
#else
using IHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;
using HtmlString = Microsoft.AspNetCore.Html.HtmlString;
using HtmlEncoder = System.Text.Encodings.Web.HtmlEncoder;
#endif
//using ToSic.Razor.Markup;
using System.IO;


namespace ToSic.Razor.Markup
{
    public partial class TagBase: IHtmlString
    {

#if NET451
        /// <summary>
        /// This is the serialization for the old-style asp.net razor
        /// </summary>
        /// <returns></returns>
        public string ToHtmlString() => ToString();
#else

        /// <inheritdoc />
        public void WriteTo(TextWriter writer, HtmlEncoder encoder)
        {
            if (writer == null)
                throw new System.ArgumentNullException(nameof(writer));
            writer.Write(ToString());
        }
#endif


        #region .Open and .Close

        public HtmlString TagStart => new HtmlString(TagBuilder.Open(TagName, TagAttributes, TagOptions));
        public HtmlString TagEnd => new HtmlString(TagBuilder.Close(TagName));

        #endregion
    }
}
