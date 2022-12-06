
using ToSic.Razor.Blade;

namespace ToSic.Razor.Markup
{
    /// <summary>
    /// A generic tag object - used to create any kind of tag
    /// </summary>
    public partial class TagBase : ITag
    {
        #region Constructors
        private TagBase() { }

        protected internal TagBase(string name = null, TagOptions options = null)
        {
            TagOptions = options;
            if (name?.Contains("<") ?? false)
                TagOverride = name;
            else
                TagName = name;
        }

        protected internal TagBase(string name, TagOptions options, params object[] content) : this(name, options)
        {
            if(content?.Length > 0)
                TagChildren.Replace(content);
        }
        #endregion

        internal static TagBase Text(string text)
            => new TagBase { TagOverride = text };

        /// <inheritdoc/>
        public string TagName { get; }

        /// <summary>
        /// TagBase serialization options, like what quotes to use
        /// If null, will use defaults
        /// </summary>
        internal TagOptions TagOptions;

        private TagOptions RealOptions => TagOptions.UseOrCreate(TagOptions);

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
        public override string ToString() => ToString(RealOptions);

        internal string ToString(TagOptions options)
            => TagOverride
               ?? TagBuilder.Tag(TagName, TagAttributes, TagContents, options);

    }
}
