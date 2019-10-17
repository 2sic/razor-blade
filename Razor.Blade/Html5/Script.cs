namespace ToSic.Razor.Html5
{
    /// <summary>
    /// Special tag for generating JsonLd markup
    /// </summary>
    public class ScriptJsonLd : Script
    {
        /// <summary>
        /// Create a JsonLd Script-Tag 
        /// </summary>
        /// <param name="content">the contents in the tag</param>
        internal ScriptJsonLd(string content)
        {
            Type("application/ld+json");
            TagContents = content;
        }

        /// <summary>
        /// Create a JsonLd Script tag and automatically json-serialize the object inside it
        /// </summary>
        /// <param name="content">an object which will be json serialized</param>
        internal ScriptJsonLd(object content)
            : this(ToSic.Razor.Internals.Html.ToJsonOrErrorMessage(content)) {}
    }
}
