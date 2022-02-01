#if NETFRAMEWORK
using IHtmlString = System.Web.IHtmlString;
#else
using IHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;
using HtmlEncoder = System.Text.Encodings.Web.HtmlEncoder;
#endif
using System.Collections.Generic;

namespace ToSic.Razor.Markup
{
    public class AttributeList: AttributeListBase, IHtmlString
    {
        public AttributeList(AttributeOptions options = null): base(options) { }

        public AttributeList(IEnumerable<KeyValuePair<string, string>> attributes, AttributeOptions options = null)
            : base(attributes, options)  { }
        
        public AttributeList(IEnumerable<KeyValuePair<string, object>> attributes, AttributeOptions options = null)
            :base(attributes, options) { }


        #region ToString and ToHtml for all interfaces

#if NETFRAMEWORK
        /// <summary>
        /// This is the serialization for the old-style asp.net razor
        /// </summary>
        /// <returns></returns>
        public string ToHtmlString() => ToString();
#else

        /// <inheritdoc />
        public void WriteTo(System.IO.TextWriter writer, HtmlEncoder encoder)
        {
            if (writer == null)
                throw new System.ArgumentNullException(nameof(writer));
            writer.Write(ToString());
        }
#endif

        #endregion
    }
}
