using ToSic.Razor.Html5;

namespace ToSic.Razor.Internals.Page
{
    public partial class Page
    {
        /// <inheritdoc />
        public void AddOpenGraph(string property, string content) => AddToHead(new MetaOg(property, content));

    }
}
