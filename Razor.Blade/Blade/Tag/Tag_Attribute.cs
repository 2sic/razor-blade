using ToSic.Razor.Markup;

namespace ToSic.Razor.Blade
{
    // Basic tools to generate attributes and tags here
    partial class Tag
    {
        /// <summary>
        /// Generate an attribute for use in a tag
        /// </summary>
        /// <param name="name">attribute name</param>
        /// <param name="value">attribute value</param>
        /// <param name="options">optional configuration regarding quotes and encoding</param>
        /// <returns>HtmlString so you can use &lt;div @Tag.Attr("myid", "5930")&gt; in your code</returns>
        public static Attribute Attr(string name, string value, AttributeOptions options = null)
            => new Attribute(name, value, options);

        /// <summary>
        /// Generate an attribute for use in a tag
        /// </summary>
        /// <param name="name">attribute name</param>
        /// <param name="value">attribute value object - will be serialized to json</param>
        /// <param name="options">optional configuration regarding quotes and encoding</param>
        /// <returns>HtmlString so you can use &lt;div @Tag.Attr("myid", 5930)&gt; in your code</returns>
        public static Attribute Attr(string name, object value = null, AttributeOptions options = null)
            => new Attribute(name, value, options);

    }
}
