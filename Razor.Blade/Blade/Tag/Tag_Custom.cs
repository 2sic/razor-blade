namespace ToSic.Razor.Blade
{
    // Basic tools to generate attributes and tags here, probably also move "Wrap" to this
    partial class Tag
    {
        /// <summary>
        /// Create a generic html tag for a specific name.
        /// We recommend to use the normal tag overloads instead.
        /// So Tag.Img(...) is better than Tag.Custom("Img") because it's preconfigured to self-close, encode the src etc.
        /// </summary>
        /// <param name="name">tag name</param>
        /// <param name="content">optional content to place within the tag - can be a string or other tags</param>
        /// <returns>HtmlString of the tag, so you can use it directly with @TagBase.TagStart(...) in your razor</returns>
        public static Markup.TagCustom Custom(string name, params object[] content)
            => new Markup.TagCustom(name, content);

    }
}
