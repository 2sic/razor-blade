using ToSic.Razor.Blade;

namespace ToSic.Razor.Html5
{
    public partial class Meta
    {
        internal Meta(string name = null, string content = null): this()
        {
            if(name != null) Name(name);
            if (content != null) Content(content);
        }
    }

    public class MetaOg : Meta
    {
        public const string Prefix = "og:";

        internal MetaOg(string property = null, string content = null)
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
