using Connect.Razor.Html;

namespace Connect.Razor.Html5
{
    /// <summary>
    /// Generate a standard HTML5 &lt;-- --&gt; tag for adding comments
    /// </summary>
    public class Comment : Tag
    {
        private const string Template = "<!-- {0} -->";

        public Comment(string content = null) : base(string.Format(Template, content))
        { }
    }
}
