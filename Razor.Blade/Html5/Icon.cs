using ToSic.Razor.Blade;
using ToSic.Razor.Internals.Mime;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Html5
{
    /// <summary>
    /// Generate a standard HTML5 &lt;link&gt; tag with properties an icon needs
    /// </summary>
    public class Icon : Link
    {
        internal const int SizeUndefined = 0;
        internal const string RelIcon = "icon";
        internal const string RootFavicon = "/favicon.ico";
        internal const string RelShortcut = "shortcut icon";
        internal const string RelApple = "apple-touch-icon";

        /// <summary>
        /// Generate an icon 
        /// </summary>
        /// <param name="path">path to the icon</param>
        /// <param name="rel">relationship term like 'icon' or 'shortcut icon'</param>
        /// <param name="size">size parameter</param>
        /// <param name="type">mime type</param>
        /// <returns></returns>
        internal Icon(string path, string rel = null, int size = SizeUndefined, string type = null)
        {
            // override empty attributes
            TagOptions = new TagOptions(new AttributeOptions {KeepEmpty = false}) {Close = false};

            Rel(rel ?? RelIcon);
            Sizes(size == SizeUndefined ? "" : $"{size}x{size}");
            Type(type ?? Mime.DetectImageMime(path));
            Href(path);
        }

        public Icon Sizes(string value) => this.Attr("sizes", value, null);

    }
}
