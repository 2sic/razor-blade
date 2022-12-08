using ToSic.Razor.Internals.Mime;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Html5
{
    /// <summary>
    /// Generate a standard HTML5 `link` tag with properties an icon needs
    /// </summary>
    public class Icon : Link
    {
        public const int SizeUndefined = 0;
        public static readonly string RelIcon = "icon";
        public static readonly string RootFavicon = "/favicon.ico";
        public static readonly string RelShortcut = "shortcut icon";
        public static readonly string RelApple = "apple-touch-icon";

        internal override TagOptions TagOptions => new TagOptions(attributeOptions: new AttributeOptions(keepEmpty: false), close: false);

        /// <summary>
        /// Generate an icon 
        /// </summary>
        /// <param name="path">path to the icon</param>
        /// <param name="rel">relationship term like 'icon' or 'shortcut icon'</param>
        /// <param name="size">size parameter</param>
        /// <param name="type">mime type</param>
        /// <returns></returns>
        public Icon(string path, string rel = null, int size = SizeUndefined, string type = null) =>
            InitAttributes(() =>
            {
                Rel(rel ?? RelIcon);
                Sizes(size == SizeUndefined ? "" : $"{size}x{size}");
                Type(type ?? Mime.DetectImageMime(path));
                Href(path);
            });

        /// <summary>
        /// Set icon `sizes` attribute
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Icon Sizes(string value) => this.Attr("sizes", value, null) as Icon;

        private Icon(Icon original, CloneChanges changes) : base(original, changes) { }

        internal override Link CwC(CloneChanges changes) => new Icon(this, changes);

    }

    public partial class Link
    {
        /// <summary>
        /// Very special internal overload to allow Icons to replicate
        /// </summary>
        protected Link(Icon original, CloneChanges changes) : base(original, changes) { }
    }
}
