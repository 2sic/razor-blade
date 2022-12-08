using ToSic.Razor.Markup;
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
        internal ScriptJsonLd(string content)
            // https://w3c.github.io/json-ld-syntax/#restrictions-for-contents-of-json-ld-script-elements
            // Authors should avoid using character sequences in scripts embedded in HTML which may be confused
            // with a comment-open, script-open, comment-close, or script-close.
            : base(XssPrevention.JsonLdScriptEncoding(content))
            => InitAttributes(() =>
            {
                Type("application/ld+json");
            });

        /// <summary>
        /// Create a JsonLd Script tag and automatically json-serialize the object inside it
        /// </summary>
        /// <param name="content">an object which will be json serialized</param>
        internal ScriptJsonLd(object content)
            : this(Internals.Html.ToJsonOrErrorMessage(content)) {}

        private ScriptJsonLd(ScriptJsonLd original, CloneChanges changes) : base(original, changes) { }

        internal override Script CwC(CloneChanges changes) => new ScriptJsonLd(this, changes);

    }

    public partial class Script
    {
        /// <summary>
        /// Very special internal overload to allow Icons to replicate
        /// </summary>
        protected Script(ScriptJsonLd original, CloneChanges changes) : base(original, changes) { }

        protected Script(string jsonLd): base("script", content: jsonLd) { }
    }
}
