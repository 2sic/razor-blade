namespace ToSic.Razor.Blade
{
    // Basic tools to generate attributes and tags here, probably also move "Wrap" to this
    partial class Tag
    {
        /// <summary>
        /// Create a generic html tag for a specific name.
        /// We recommend to use the normal tag overloads instead.
        /// So Tag.Img(...) is better than Tag.Custom("Img") because it's preconfigured to self-close, encode the src etc.
        /// <seealso cref="RawHtml"/>
        /// </summary>
        /// <param name="name">tag name</param>
        /// <param name="content">optional content to place within the tag - can be a string or other tags</param>
        /// <returns>HtmlString of the tag, so you can use it directly with @TagBase.TagStart(...) in your razor</returns>
        public static Markup.TagCustom Custom(string name, params object[] content)
            => new Markup.TagCustom(name, content);

        /// <summary>
        /// Simple tag creator for raw source code which doesn't have another tag around it.
        ///
        /// Mainly used in function which want to return content which should then be put into html directly
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static Markup.TagCustom RawHtml(params object[] content)
            => new Markup.TagList(content);

        /// <summary>
        /// Simple tag creator for tags inside it - the wrapper doesn't exist.
        /// Mainly used in function which want to return content which should then be put into html directly
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <remarks>Added in v03.08</remarks>
        public static Markup.TagList TagList(params object[] content)
            => new Markup.TagList(content);
    }
}
