#if NETFRAMEWORK
using IHtmlString = System.Web.IHtmlString;
#else
using IHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;
using HtmlEncoder = System.Text.Encodings.Web.HtmlEncoder;
#endif
using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Markup
{
    /// <summary>
    /// ToString and ToHtml for all interfaces
    /// </summary>
    [PrivateApi]
    public abstract class ToHtmlHybridBase: IHtmlString
    {
#if NETFRAMEWORK
        /// <summary>
        /// This is the serialization for the old-style asp.net razor
        /// </summary>
        /// <returns></returns>
        [PrivateApi]
        public string ToHtmlString() => ToString();
#else

        /// <inheritdoc />
        [PrivateApi]
        public void WriteTo(System.IO.TextWriter writer, HtmlEncoder encoder)
        {
            if (writer == null) throw new System.ArgumentNullException(nameof(writer));
            writer.Write(ToString());
        }
#endif
    }
}
