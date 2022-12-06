
using ToSic.Razor.Markup;

namespace ToSic.Razor.Html5
{
    /// <summary>
    /// Generate a standard HTML5 &lt;-- --&gt; tag for adding comments
    /// </summary>
    public class Comment : ToSic.Razor.Markup.Tag<Comment>
    {
        private const string Template = "<!-- {0} -->";

        internal Comment(string content = null) : base(string.Format(Template, content))
        { }

        private Comment(Comment original, CloneChanges changes) : base(original, changes) { }

        internal override Comment CwC(CloneChanges changes) => new Comment(this, changes);
    }
}
