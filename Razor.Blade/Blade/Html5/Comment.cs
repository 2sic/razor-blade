using Connect.Razor.Blade.HtmlTags;

namespace Connect.Razor.Blade.Html5
{
    /// <summary>
    /// Generate a standard HTML5 &lt;-- --&gt; tag for adding comments
    /// </summary>
    public class Comment : HtmlTags.Tag
    {
        private const string Template = "<!-- {0} -->";

        public Comment(string content = null) : base(string.Format(Template, content))
        { }
    }
}
