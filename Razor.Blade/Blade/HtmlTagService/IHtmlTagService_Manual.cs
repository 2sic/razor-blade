using ToSic.Razor.Html5;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Blade
{
    public partial interface IHtmlTagService
    {
        /// <summary>
        /// Create a HTML comment with something inside. 
        /// </summary>
        /// <param name="content">optional content to place within the tag - usually a string</param>
        /// <returns>HtmlString of the tag, so you can use it directly with @HtmlTag.Comment(...) in your razor</returns>
        Comment Comment(string content = null);

        /// <summary>
        /// Generate an attribute for use in a tag
        /// </summary>
        /// <param name="name">attribute name</param>
        /// <param name="value">attribute value</param>
        /// <param name="options">optional configuration regarding quotes and encoding</param>
        /// <returns>HtmlString so you can use &lt;div @Tag.Attr("myid", "5930")&gt; in your code</returns>
        Attribute Attr(string name, string value, AttributeOptions options = null);

        /// <summary>
        /// Generate an attribute for use in a tag
        /// </summary>
        /// <param name="name">attribute name</param>
        /// <param name="value">attribute value object - will be serialized to json</param>
        /// <param name="options">optional configuration regarding quotes and encoding</param>
        /// <returns>HtmlString so you can use &lt;div @Tag.Attr("myid", 5930)&gt; in your code</returns>
        Attribute Attr(string name, object value = null, AttributeOptions options = null);

        /// <summary>
        /// Create a generic html tag for a specific name.
        /// We recommend to use the normal tag overloads instead.
        /// So Tag.Img(...) is better than Tag.Custom("Img") because it's preconfigured to self-close, encode the src etc.
        /// <seealso cref="RawHtml"/>
        /// </summary>
        /// <param name="name">tag name</param>
        /// <param name="content">optional content to place within the tag - can be a string or other tags</param>
        /// <returns>HtmlString of the tag, so you can use it directly with @TagBase.TagStart(...) in your razor</returns>
        TagCustom Custom(string name, params object[] content);

        /// <summary>
        /// Simple tag creator for raw source code which doesn't have another tag around it.
        ///
        /// Mainly used in function which want to return content which should then be put into html directly
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        TagCustom RawHtml(params object[] content);

        /// <summary>
        /// Simple tag creator for tags inside it - the wrapper doesn't exist.
        /// Mainly used in function which want to return content which should then be put into html directly
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <remarks>Added in v03.08</remarks>
        TagList TagList(params object[] content);
    }
}
