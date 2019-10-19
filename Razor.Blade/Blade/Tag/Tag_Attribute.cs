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

        #region Disabled for now - not sure if this is a useful API to publish

        ///// <summary>
        ///// Create a string for rendering a set of attributes
        ///// </summary>
        ///// <param name="attributes">An enumerable of key/value pairs, usually a dictionary</param>
        ///// <param name="options">optional configuration regarding quotes and encoding</param>
        ///// <returns>HtmlString so you can use @Tag.Attributes(...) in your code</returns>
        //public static AttributeList Attributes(IEnumerable<KeyValuePair<string, string>> attributes, AttributeOptions options = null) 
        //    => new AttributeList(attributes, options);


        ///// <summary>
        ///// Create a string for rendering a set of attributes
        ///// </summary>
        ///// <param name="attributes">An enumerable of key/value pairs, usually a dictionary. Objects will be serialized to json</param>
        ///// <param name="options">optional configuration regarding quotes and encoding</param>
        ///// <returns>HtmlString so you can use @Tag.Attributes(...) in your code</returns>
        //public static AttributeList Attributes(IEnumerable<KeyValuePair<string, object>> attributes, AttributeOptions options = null)
        //    => new AttributeList(attributes, options);

        #endregion
    }
}
