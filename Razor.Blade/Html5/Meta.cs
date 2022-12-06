using ToSic.Razor.Blade;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Html5
{
    public partial class Meta
    {
        public Meta(string name = null, string content = null): this()
        {
            if(name != null) Name(name);
            if (content != null) Content(content);
        }

        private Meta(Meta original, ChildTags children = null, AttributeList attributes = null, TagOptions options = null)
            : base(original, children, attributes, options) { }

        /// <inheritdoc />
        internal override Meta CwC(ChildTags children = null, AttributeList attributes = null, TagOptions options = null) 
            => new Meta(this, children, attributes, options);
    }

    public class MetaOg : Meta
    {
        public const string Prefix = "og:";

        public MetaOg(string property = null, string content = null)
        {
            if(property != null) Property(property);
            if(content != null) Content(content);
        }
        public MetaOg Property(string value)
        {
            if (!value.ToLowerInvariant().StartsWith(Prefix))
                value = Prefix + value;
            return Attr("property", value) as MetaOg;
        }

        public new MetaOg Content(string value) 
            => Attr("content", value) as MetaOg;
   }
    
}
