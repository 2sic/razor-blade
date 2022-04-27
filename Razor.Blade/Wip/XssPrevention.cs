using System;
using ToSic.Razor.Internals;

namespace ToSic.Razor.Wip
{
    /// <summary>
    /// TODO: WIP
    /// https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html
    /// https://cheatsheetseries.owasp.org/cheatsheets/DotNet_Security_Cheat_Sheet.html#a7-cross-site-scripting-xss
    /// </summary>
    public class XssPrevention
    {
        /// <summary>
        /// Output Encoding for "JSON-LD Contexts"
        /// https://w3c.github.io/json-ld-syntax/#restrictions-for-contents-of-json-ld-script-elements
        /// https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html#output-encoding-for-javascript-contexts
        /// Authors should avoid using character sequences in scripts embedded in HTML which may be confused with a
        /// comment-open, script-open, comment-close, or script-close.
        /// Partial encode < and > characters with the \uXXXX unicode encoding format (X = Integer).
        /// </summary>
        /// <param name="unsafeJsonLd"></param>
        /// <returns></returns>
        public static string JsonLdScriptEncoding(string unsafeJsonLd) => unsafeJsonLd
            .Replace("<!--", "<", @"\u003C", StringComparison.OrdinalIgnoreCase)
            .Replace("<script", "<", @"\u003C", StringComparison.OrdinalIgnoreCase)
            .Replace("-->", ">", @"\u003E", StringComparison.OrdinalIgnoreCase)
            .Replace("</script", "<", @"\u003C", StringComparison.OrdinalIgnoreCase);

        ///// <summary>
        ///// Output Encoding for "HTML Contexts"
        ///// https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html#output-encoding-for-html-contexts
        ///// Convert & to &amp;
        ///// Convert < to &lt;
        ///// Convert > to &gt;
        ///// Convert " to &quot;
        ///// Convert ' to &#x27;
        ///// Convert / to &#x2F;
        ///// </summary>
        ///// <param name="unsafeHtml"></param>
        ///// <returns></returns>
        //internal static string HtmlEntityEncoding(string unsafeHtml) => unsafeHtml
        //    .Replace("&", "&amp;") // TODO: encode & only in case that unsafeHtml is not already entity encoded
        //    .Replace("<", "&lt;")
        //    .Replace(">", "&gt;")
        //    .Replace("\"", "&quot;")
        //    .Replace("'", "&apos;");

        ///// <summary>
        ///// TODO: Output Encoding for "HTML Attribute Contexts"
        ///// https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html#output-encoding-for-html-attribute-contexts
        ///// Except for alphanumeric characters, encode all characters with the
        ///// HTML Entity &#xHH; format, including spaces. (HH = Hex Value)
        ///// </summary>
        ///// <param name="unsafeAttributeValue"></param>
        ///// <returns></returns>
        //internal static string HtmlAttributeEncoding(string unsafeAttributeValue) => unsafeAttributeValue;

        ///// <summary>
        ///// TODO: Output Encoding for "URL Contexts"
        ///// https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html#output-encoding-for-url-contexts
        ///// Standard percent encoding. URL encoding should only be used to encode parameter values,
        ///// not the entire URL or path fragments of a URL.
        ///// </summary>
        ///// <param name="unsafeParameterValue"></param>
        ///// <returns></returns>
        //internal static string UrlParameterEncoding(string unsafeParameterValue) => unsafeParameterValue;

        ///// <summary>
        ///// TODO: Output Encoding for "JavaScript Contexts"
        ///// https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html#output-encoding-for-javascript-contexts
        ///// Except for alphanumeric characters, encode all characters with the
        ///// \uXXXX unicode encoding format (X = Integer).
        ///// </summary>
        ///// <param name="unsafeJavaScript"></param>
        ///// <returns></returns>
        //internal static string JavaScriptEncoding(string unsafeJavaScript) => unsafeJavaScript;

        ///// <summary>
        ///// TODO: Output Encoding for "CSS Contexts"
        ///// https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html#output-encoding-for-css-contexts
        ///// CSS encoding supports \XX and \XXXXXX. Using a two character encode can cause problems if
        ///// the next character continues the encode sequence. There are two solutions:
        ///// (a) Add a space after the CSS encode (will be ignored by the CSS parser)
        ///// (b) use the full amount of CSS encoding possible by zero padding the value.
        ///// </summary>
        ///// <param name="unsafeCss"></param>
        ///// <returns></returns>
        //internal static string CssHexEncoding(string unsafeCss) => unsafeCss;
    }
}
