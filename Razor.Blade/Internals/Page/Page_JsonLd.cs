using ToSic.Razor.Html5;

namespace ToSic.Razor.Internals.Page
{
    public partial class Page
    {
        /// <inheritdoc />
        public void AddJsonLd(string jsonString)
            => AddToHead(new ScriptJsonLd(jsonString));

        /// <inheritdoc />
        public void AddJsonLd(object jsonObject)
            => AddToHead(new ScriptJsonLd(jsonObject));

    }
}
