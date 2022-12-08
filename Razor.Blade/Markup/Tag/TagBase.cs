using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Markup
{
    /// <summary>
    /// A generic tag object - used to create any kind of tag
    /// </summary>
    public abstract partial class TagBase : ITag
    {
        #region Constructors

        internal const bool DefaultTagIsImmutable = true;

        /// <summary>
        /// Special: Determines if the object is immutable.
        /// If this is true (new mode), then any call to adding attributes or content will return a _new_ object.
        /// If it is false (classic mode) then any call to change something actually changes the current object and returns it.
        /// </summary>
        [InternalApi_DoNotUse_MayChangeWithoutNotice]
        public bool IsImmutable { get; internal set; } = DefaultTagIsImmutable;

        protected internal TagBase(TagBase original = null,
            string name = null,
            string tagOverride = null,
            TagChildren children = null,
            object[] content = null,
            Attributes attributes = null,
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
            TagChildren = content != null
                ? new TagChildren(this, content)
                : children ?? original?.TagChildren ?? new TagChildren(this);
            TagAttributes = attributes ?? original?.TagAttributes ?? new Attributes();
        }

        #endregion

        #region Custom Processing of new Content

        protected virtual object PreProcessNewChild(object newChild) => newChild;

        #endregion

        #region Changes

        protected void ApplyChanges(CloneChanges changes)
        {
            if (changes.Options != null) TagOptions = changes.Options;
            if (changes.Attributes != null) TagAttributes = changes.Attributes;
            if (changes.Children != null) TagChildren = changes.Children;
        }

        #endregion

        /// <inheritdoc/>
        public string TagName { get; }

        /// <summary>
        /// TagBase serialization options, like what quotes to use
        /// If null (allowed), will use defaults.
        /// </summary>
        internal virtual TagOptions TagOptions { get; private set; }

        /// <summary>
        /// Helper to ensure that both strings/tags can be passed around and added to list
        /// </summary>
        /// <param name="child"></param>
        /// <returns></returns>
        [PrivateApi]
        internal static TagBase EnsureTag(object child) =>
            IsStringOrHtmlString(child, out var s) 
                ? new TagText(s) 
                : child as TagBase; // returns the child or null

        /// <summary>
        /// Gets the HTML encoded value.
        /// </summary>
        public override string ToString() => ToString(TagOptions);

        [PrivateApi]
        internal string ToString(TagOptions optionsOrNull)
            => TagOverride ?? TagBuilder.Tag(TagName, TagAttributes, TagChildren.ToString(), optionsOrNull);

    }
}
