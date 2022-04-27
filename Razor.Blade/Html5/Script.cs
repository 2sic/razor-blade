using ToSic.Razor.Wip;

namespace ToSic.Razor.Html5
{
    /// <summary>
    /// Special tag for generating JsonLd markup
    /// </summary>
    public class ScriptJsonLd : Script
    {
        /// <summary>
        /// Create a JsonLd Script-TagBase 
        /// </summary>
        /// <param name="content">the contents in the tag</param>
        public ScriptJsonLd(string content)
        {
            Type("application/ld+json");
            // https://w3c.github.io/json-ld-syntax/#restrictions-for-contents-of-json-ld-script-elements
            // Authors should avoid using character sequences in scripts embedded in HTML which may be confused
            // with a comment-open, script-open, comment-close, or script-close.
            TagContents = XssPrevention.JsonLdScriptEncoding(content);
        }

        /// <summary>
        /// Create a JsonLd Script tag and automatically json-serialize the object inside it
        /// </summary>
        /// <param name="content">an object which will be json serialized</param>
        public ScriptJsonLd(object content)
            : this(ToSic.Razor.Internals.Html.ToJsonOrErrorMessage(content)) {}
    }
}
