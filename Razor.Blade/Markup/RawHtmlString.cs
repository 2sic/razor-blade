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
    /// Cross platform (.net core and framework) HTML string implementation
    /// </summary>
    [PrivateApi]
    public class RawHtmlString: IRawHtmlString
    {
        /// <summary>
        /// Constructor to provide initial value.
        /// </summary>
        /// <param name="value"></param>
        public RawHtmlString(string value) => _value = value;

        /// <summary>
        /// Constructor with empty initial value.
        /// Mainly used when overriding this class, and probably never using _value.
        /// </summary>
        protected RawHtmlString() => _value = "";
        private readonly string _value;

        /// <summary>
        /// Standard ToString overload - used when concatenating strings.
        ///
        /// This is also the method used for any other integration, so overwrite this if you need to change the behavior.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => _value;

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

        public static bool IsStringOrHtmlString(object original, out string asString)
        {
            asString = null;
            if (original is null) return false;
            if (original is string strOriginal)
            {
                asString = strOriginal;
                return true;
            }

            if (original is IHtmlString)
            {
                asString = original.ToString();
                return true;
            }

            return false;
        }
    }

}
