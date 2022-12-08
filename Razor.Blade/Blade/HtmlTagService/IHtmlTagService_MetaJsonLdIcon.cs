using ToSic.Razor.Html5;

namespace ToSic.Razor.Blade
{
    public partial interface IHtmlTagService
    {
        /// <summary>
        /// Generate a open-graph Meta tag.
        /// </summary>
        /// <remarks>
        /// Important: This is a specialized meta tag.
        /// The API to create it is different from most tags, as it has name/content parameters. 
        /// </remarks>
        /// <param name="property"></param>
        /// <param name="content"></param>
        MetaOg MetaOg(string property = null, string content = null);

        /// <summary>
        /// Create a JsonLd Script 
        /// </summary>
        /// <param name="json">the contents in the tag, usually JSON</param>
        ScriptJsonLd ScriptJsonLd(string json);

        /// <summary>
        /// Create a JsonLd Script tag and automatically json-serialize the object inside it
        /// </summary>
        /// <param name="obj">an object which will be json serialized</param>
        ScriptJsonLd ScriptJsonLd(object obj);

        Icon Icon(string path, string rel = null, int size = Html5.Icon.SizeUndefined, string type = null);
    }
}
