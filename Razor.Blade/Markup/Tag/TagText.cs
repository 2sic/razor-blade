namespace ToSic.Razor.Markup
{
    public class TagText: Tag<TagText>
    {
        public TagText(string text) : base(true, tagOverride: text) { }

        private TagText(TagText original, CloneChanges changes) : base(original, changes) { }

        /// <inheritdoc />
        internal override TagText CwC(CloneChanges changes) => new TagText(this, changes);
    }
}
