using Connect.Razor.Blade;

namespace Connect.Razor.Html5
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
        internal MetaOg(string property = null, string content = null)
        {
            if(property != null) Property(property);
            if(content != null) Content(content);
        }
        public MetaOg Property(string value) => this.Attr("property", value);
        public new MetaOg Content(string value) => this.Attr("content", value);
   }
    
}
