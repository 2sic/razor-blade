using ToSic.Razor.Interfaces;

namespace ToSic.Razor.Markup
{
    public partial class TagBase
    {
        /// <summary>
        /// All attributes of this tag
        /// </summary>
        /// <inheritdoc cref="ITag"/>
        public AttributeList TagAttributes { get; } = new AttributeList();
    }
}
