
using ToSic.Razor.Blade;

namespace ToSic.Razor.Markup
{
    /// <summary>
    /// A generic tag object - used to create any kind of tag
    /// </summary>
    public partial class TagBase : ITag
    {
        #region Constructors

        public bool TagIsReadOnly { get; set; } = false;

        private TagBase(): this(null, null) { }

        protected internal TagBase(TagBase original = null,
            string name = null,
            string tagOverride = null,
            ChildTags children = null,
            AttributeList attributes = null,
            TagOptions options = null)
        {
            // TagOptions is allowed to be null
            TagOptions = options ?? original?.TagOptions;

            // TagOverride is allowed to be null
            TagOverride = tagOverride ?? original?.TagOverride;

            // Only set the name, if TagOverride is null - as it shouldn't both exist
            if (TagOverride == null)
            {
                if (name?.Contains("<") ?? false)
                    TagOverride = name;
                else
                    TagName = name ?? original?.TagName;
            }

            // Children and Attributes may never be null
            TagChildren = children ?? original?.TagChildren ?? new ChildTags();
            TagAttributes = attributes ?? original?.TagAttributes ?? new AttributeList();
        }

        #endregion

        #region Changes

        protected void ApplyChanges(CloneChanges changes)
        {
            if (changes.Options != null) TagOptions = changes.Options;
            if (changes.Attributes != null) TagAttributes = changes.Attributes;
            if (changes.Children != null) TagChildren = changes.Children;

        }

        #endregion

        internal static TagBase Text(string text)
            => new TagBase { TagOverride = text };

        /// <inheritdoc/>
        public string TagName { get; }

        /// <summary>
        /// TagBase serialization options, like what quotes to use
        /// If null (allowed), will use defaults.
        /// </summary>
        /// <remarks>Set may only be called once, on ApplyChanges</remarks>
        internal virtual TagOptions TagOptions { get; private set; }

        /// <summary>
        /// Helper to ensure that both strings/tags can be passed around and added to list
        /// </summary>
        /// <param name="child"></param>
        /// <returns></returns>
        internal static TagBase EnsureTag(object child)
        {
            if (IsStringOrHtmlString(child, out var s)) return Text(s);
            if (child is TagBase tag) return tag;
            return new TagBase();
        }

        /// <summary>
        /// Gets the HTML encoded value.
        /// </summary>
        public override string ToString() => ToString(TagOptions);

        internal string ToString(TagOptions optionsOrNull)
            => TagOverride ?? TagBuilder.Tag(TagName, TagAttributes, TagContents, optionsOrNull);

    }
}
