namespace ToSic.Razor.Html5
{
    public partial class Abbr
    {
        internal Abbr(object content, string title) : this(content) =>
            InitAttributes(() =>
            {
                this.Title(title);
            });
    }

    public partial class Bdo
    {
        internal Bdo(object content, string direction) : this(content) =>
            InitAttributes(() =>
            {
                Dir(direction);
            });

    }

    public partial class Img
    {
        internal Img(string src, int width = -1, int height = -1) : this() =>
            InitAttributes(() =>
            {
                Src(src);
                if (height > -1) Height(height);
                if (width > -1) Width(width);
            });

    }

    public partial class A
    {
        internal A(string href, string target = null) : this() =>
            InitAttributes(() =>
            {
                Href(href);
                if (target != null) Target(target);
            });
    }

    // ReSharper disable once InconsistentNaming
    public partial class Iframe
    {
        internal Iframe(string src, int width = -1, int height = -1): this() =>
            InitAttributes(() =>
            {
                Src(src);
                if (height > -1) Height(height);
                if (width > -1) Width(width);

            });
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;source&gt; tag,
    /// initialized with src and optionally type
    /// </summary>
    internal class MediaSource : Source
    {
        internal MediaSource(string src, string type = null) =>
            InitAttributes(() =>
            {
                Src(src);
                if (type != null) Type(type);
            });
    }
    internal class PictureSource : Source
    {
        /// <summary>
        /// Generate a standard HTML5 &lt;source&gt; tag,
        /// initialized with srcset and optionally media, sizes and type
        /// </summary>
        internal PictureSource(string srcset, string media = null, string sizes = null, string type = null) =>
            InitAttributes(() =>
            {
                Srcset(srcset);
                if (media != null) Media(media);
                if (sizes != null) Sizes(sizes);
                if (type != null) Type(type);
            });
    }

}
