using ToSic.Razor.Html5;

namespace ToSic.Razor.Blade
{
    public partial class HtmlTagsServiceImplementation
    {
        /// <inheritdoc />
        public MetaOg MetaOg(string property = null, string content = null) => new MetaOg(property, content);

        /// <inheritdoc />
        public ScriptJsonLd ScriptJsonLd(string json) => new ScriptJsonLd(json);

        /// <inheritdoc />
        public ScriptJsonLd ScriptJsonLd(object obj) => new ScriptJsonLd(obj);

        /// <inheritdoc />
        public Icon Icon(string path, string rel = null, int size = Html5.Icon.SizeUndefined, string type = null) => new Icon(path,rel,size,type);
    }
}
