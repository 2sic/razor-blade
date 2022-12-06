using ToSic.Razor.Blade;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Html5
{
    public partial class Abbr
    {
        internal Abbr(bool fluid, object content, string title) : this(fluid, content)
        {
            this.Title(title);
        }
    }

    public partial class Bdo
    {
        internal Bdo(bool fluid, object content, string direction) : this(fluid, content)
        {
            Dir(direction);
        }

    }

    public partial class Img
    {
        internal Img(bool fluid, string src, int width = -1, int height = -1) : this(fluid)
        {
            Src(src);
            if (height > -1) Height(height);
            if (width > -1) Width(width);
        }

    }

    public partial class A
    {
        internal A(bool fluid, string href, string target = null) : this(fluid)
        {
            Href(href);
            if (target != null) Target(target);
        }
    }

    // ReSharper disable once InconsistentNaming
    public partial class Iframe
    {
        internal Iframe(bool fluid, string src, int width = -1, int height = -1) : this(fluid)
        {
            Src(src);
            if (height > -1) Height(height);
            if (width > -1) Width(width);
        }
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;source&gt; tag,
    /// initialized with src and optionally type
    /// </summary>
    internal class MediaSource : Source
    {
        internal MediaSource(bool fluid, string src, string type = null) : base(fluid)
        {
            Src(src);
            if (type != null) Type(type);
        }
    }
    internal class PictureSource : Source
    {
        /// <summary>
        /// Generate a standard HTML5 &lt;source&gt; tag,
        /// initialized with srcset and optionally media, sizes and type
        /// </summary>
        internal PictureSource(bool fluid, string srcset, string media = null, string sizes = null, string type = null) : base(fluid)
        {
            Srcset(srcset);
            if (media != null) Media(media);
            if (sizes != null) Sizes(sizes);
            if (type != null) Type(type);
        }
    }

}
