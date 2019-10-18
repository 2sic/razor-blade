using System;
using ToSic.Razor.Blade;
using ToSic.Razor.Markup;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created 18.10.2019 17:57
//
// Each tag and attributes of it prepare code, and they return an object of the same type again
// to allow fluid chaining of the commands
// ****
// ****
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable UnusedMember.Global
namespace ToSic.Razor.Html5
{

    /// <summary>
    /// Generate a standard HTML5 &lt;a&gt; tag
    /// </summary>
    /// <returns>
    /// A A object with all the attributes available in that tag
    /// </returns>
    public partial class A : TagBase
    {
    
    /// <summary>
    /// Generate an &lt;a&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal A(object content = null) : base("a", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;a&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A A object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal A(params object[] content) : base("a", null, content)
    {
    }
    
    /// <summary>
    /// Set the download attribute on the &lt;a&gt; tag 
    /// </summary>
    /// <param name="value">what should be in download='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a A object to enable fluid command chaining</returns>
        public A Download(string value) => this.Attr("download", value);




    /// <summary>
    /// Set the href attribute on the &lt;a&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in href='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a A object to enable fluid command chaining</returns>
        public A Href(string value) => this.Attr("href", UriEncode(value));




    /// <summary>
    /// Set the hreflang attribute on the &lt;a&gt; tag 
    /// </summary>
    /// <param name="value">what should be in hreflang='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a A object to enable fluid command chaining</returns>
        public A Hreflang(string value) => this.Attr("hreflang", value);




    /// <summary>
    /// Set the media attribute on the &lt;a&gt; tag 
    /// </summary>
    /// <param name="value">what should be in media='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a A object to enable fluid command chaining</returns>
        public A Media(string value) => this.Attr("media", value);




    /// <summary>
    /// Set the ping attribute on the &lt;a&gt; tag 
    /// </summary>
    /// <param name="value">what should be in ping='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a A object to enable fluid command chaining</returns>
        public A Ping(string value) => this.Attr("ping", value);




    /// <summary>
    /// Set the rel attribute on the &lt;a&gt; tag 
    /// </summary>
    /// <param name="value">what should be in rel='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a A object to enable fluid command chaining</returns>
        public A Rel(string value) => this.Attr("rel", value);




    /// <summary>
    /// Set the target attribute on the &lt;a&gt; tag 
    /// </summary>
    /// <param name="value">what should be in target='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a A object to enable fluid command chaining</returns>
        public A Target(string value) => this.Attr("target", value);




    /// <summary>
    /// Set the type attribute on the &lt;a&gt; tag 
    /// </summary>
    /// <param name="value">what should be in type='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a A object to enable fluid command chaining</returns>
        public A Type(string value) => this.Attr("type", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;link&gt; tag
    /// </summary>
    /// <returns>
    /// A Link object with all the attributes available in that tag
    /// </returns>
    public partial class Link : TagBase
    {
    
    /// <summary>
    /// Generate an &lt;link&gt; tag with optional contents
    /// </summary>
    
    internal Link() : base("link", new TagOptions { Close = false })
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;link&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Link object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Link(params object[] content) : base("link", new TagOptions { Close = false }, content)
    {
    }
    
    /// <summary>
    /// Set the crossorigin attribute on the &lt;link&gt; tag 
    /// </summary>
    /// <param name="value">what should be in crossorigin='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Link object to enable fluid command chaining</returns>
        public Link Crossorigin(string value) => this.Attr("crossorigin", value);




    /// <summary>
    /// Set the href attribute on the &lt;link&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in href='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Link object to enable fluid command chaining</returns>
        public Link Href(string value) => this.Attr("href", UriEncode(value));




    /// <summary>
    /// Set the hreflang attribute on the &lt;link&gt; tag 
    /// </summary>
    /// <param name="value">what should be in hreflang='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Link object to enable fluid command chaining</returns>
        public Link Hreflang(string value) => this.Attr("hreflang", value);




    /// <summary>
    /// Set the media attribute on the &lt;link&gt; tag 
    /// </summary>
    /// <param name="value">what should be in media='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Link object to enable fluid command chaining</returns>
        public Link Media(string value) => this.Attr("media", value);




    /// <summary>
    /// Set the rel attribute on the &lt;link&gt; tag 
    /// </summary>
    /// <param name="value">what should be in rel='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Link object to enable fluid command chaining</returns>
        public Link Rel(string value) => this.Attr("rel", value);




    /// <summary>
    /// Set the type attribute on the &lt;link&gt; tag 
    /// </summary>
    /// <param name="value">what should be in type='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Link object to enable fluid command chaining</returns>
        public Link Type(string value) => this.Attr("type", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;nav&gt; tag
    /// </summary>
    /// <returns>
    /// A Nav object with all the attributes available in that tag
    /// </returns>
    public partial class Nav : TagBase
    {
    
    /// <summary>
    /// Generate an &lt;nav&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Nav(object content = null) : base("nav", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;nav&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Nav object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Nav(params object[] content) : base("nav", null, content)
    {
    }
    
    }
}
