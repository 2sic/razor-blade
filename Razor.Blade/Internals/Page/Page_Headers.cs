using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Internals.Page
{
    public partial class Page
    {
        /// <inheritdoc />
        public void AddToHead(TagBase tag) => Add(tag);

        /// <inheritdoc />
        public void AddToHead(string html)
        {
            if (string.IsNullOrWhiteSpace(html)) return;
            AddToHead(Tag.Custom(html));
        }

        /// <inheritdoc />
        public void AddMeta(string name, string content) => AddToHead(new Meta(name, content));

        private void Add(TagBase tag, string identifier = null)
        {
            if (tag == null) return;
            Headers.Add(new HeadChange {ChangeMode = GetMode(ChangeModes.Append), Tag = tag, ReplacementIdentifier = identifier});
        }
    }
}
