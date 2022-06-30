namespace ToSic.Razor.Markup
{
    /// <summary>
    /// An empty tag just containing more tags - like a <see cref="TagCustom"/> but explicitly meant to not be a tag itself
    /// </summary>
    public class TagList: TagCustom
    {
        #region Constructors

        //public TagList(TagOptions options = null) : base(null, options) { }

        //public TagList(object content, TagOptions options = null) : base(null, content, options) { }

        public TagList(TagOptions options, object[] content) : base(null, options, content) { }

        #endregion

    }
}
