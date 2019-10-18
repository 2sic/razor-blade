namespace ToSic.Razor.Markup
{
    public partial class TagBase
    {
        /// <summary>
        /// All attributes of this tag
        /// </summary>
        public AttributeList TagAttributes { get; } = new AttributeList();
    }
}
