namespace ToSic.Razor.Markup
{
    public partial class TagBase
    {
        /// <summary>
        /// All attributes of this tag
        /// </summary>
        /// <remarks>Set may only be called once, on ApplyChanges</remarks>
        /// <inheritdoc/>
        public AttributeList TagAttributes { get; private set; } // = new AttributeList();
    }
}
