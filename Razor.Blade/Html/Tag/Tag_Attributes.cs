using ToSic.Razor.Html;

namespace ToSic.Razor.Html
{
    public partial class Tag
    {
        /// <summary>
        /// All attributes of this tag
        /// </summary>
        public AttributeList TagAttributes { get; } = new AttributeList();
    }
}
