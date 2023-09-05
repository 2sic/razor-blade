using ToSic.Razor.Html5;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Blade
{
    public partial class HtmlTagsServiceImplementation
    {
        /// <inheritdoc />
        public Comment Comment(string content = null) => new Comment(content);

        /// <inheritdoc />
        public Attribute Attr(string name, string value, AttributeOptions options = null)
            => new Attribute(name, value, options ?? AttributeOptions.StandaloneOptions);

        /// <inheritdoc />
        public Attribute Attr(string name, object value = null, AttributeOptions options = null)
            => new Attribute(name, value, options ?? AttributeOptions.StandaloneOptions);

        /// <inheritdoc />
        public TagCustom Custom(string name, params object[] content)
            => new TagCustom(name, options: null, content: content);

        /// <inheritdoc />
        public TagCustom RawHtml(params object[] content)
            => new TagList(options: null, content);

        /// <inheritdoc />
        public TagList TagList(params object[] content)
            => new TagList(options: null, content);
    }
}
