﻿namespace ToSic.Razor.Blade
{
    /// <summary>
    /// Basic tools to generate attributes and tags here, probably also move "Wrap" to this
    /// </summary>
    partial class Tags
    {
        /// <summary>
        /// Create an html tag for a specific name, optionally self self-closing (if specified in the options)
        /// </summary>
        /// <param name="name">tag name</param>
        /// <param name="content">optional content to place within the tag - can be a string or other tags</param>
        /// <returns>HtmlString of the tag, so you can use it directly with @TagBase.Open(...) in your razor</returns>
        public static Markup.TagBase Tag(string name, object content = null)
            => new Markup.TagBase(name, content);

    }
}
