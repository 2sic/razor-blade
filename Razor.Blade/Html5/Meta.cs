using ToSic.Razor.Markup;

namespace ToSic.Razor.Html5
{
    public partial class Meta
    {
        internal Meta(string name = null, string content = null): this()
        {
            if (name != null) Name(name);
            if (content != null) Content(content);
        }

        /// <summary>
        /// Very special internal overload to allow MetaOg to replicate
        /// </summary>
        protected Meta(MetaOg original, CloneChanges changes) : base(original, changes) { }

    }

    public class MetaOg : Meta
    {
        public const string Prefix = "og:";

        public MetaOg(string property = null, string content = null)
        {
            if(property != null) Property(property);
            if(content != null) Content(content);
        }

        private MetaOg(MetaOg original, CloneChanges changes) : base(original, changes) { }

        // TODO: THIS MUST RETURN THE SAME BASE TYPE AS
        // THE ORIGINAL - TEST/VERIFY IF THE FINAL CONVERSION ENDS UP WORKING
        // SINCE THE real CwC return a T-type
        internal override Meta CwC(CloneChanges changes) => new MetaOg(this, changes);

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
