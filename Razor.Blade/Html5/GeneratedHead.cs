using System;
using Connect.Razor.Blade;
using Connect.Razor.Html;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created 17.10.2019 20:47
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
namespace Connect.Razor.Html5
{

    /// <summary>
    /// Generate a standard HTML5 &lt;base&gt; tag
    /// </summary>
    /// <returns>
    /// A Base object with all the attributes available in that tag
    /// </returns>
    public partial class Base : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;base&gt; tag with optional contents
    /// </summary>
    
    internal Base() : base("base", new TagOptions { Close = false })
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;base&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Base object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Base(params object[] content) : base("base", new TagOptions { Close = false }, content)
    {
    }
    
    /// <summary>
    /// Set the href attribute on the &lt;base&gt; tag
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <returns>a Base object to enable fluid command chaining</returns>
        public Base Href(string value) => this.AttrUrl("href", value);




    /// <summary>
    /// Set the target attribute on the &lt;base&gt; tag
    /// </summary>
    /// <param name="value">what should be in target='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Base object to enable fluid command chaining</returns>
        public Base Target(string value) => this.Attr("target", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;head&gt; tag
    /// </summary>
    /// <returns>
    /// A Head object with all the attributes available in that tag
    /// </returns>
    public partial class Head : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;head&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Head(object content = null) : base("head", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;head&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Head object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Head(params object[] content) : base("head", null, content)
    {
    }
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;meta&gt; tag
    /// </summary>
    /// <returns>
    /// A Meta object with all the attributes available in that tag
    /// </returns>
    public partial class Meta : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;meta&gt; tag with optional contents
    /// </summary>
    
    internal Meta() : base("meta", new TagOptions { Close = false })
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;meta&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Meta object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Meta(params object[] content) : base("meta", new TagOptions { Close = false }, content)
    {
    }
    
    /// <summary>
    /// Set the charset attribute on the &lt;meta&gt; tag
    /// </summary>
    /// <param name="value">what should be in charset='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Meta object to enable fluid command chaining</returns>
        public Meta Charset(string value) => this.Attr("charset", value);




    /// <summary>
    /// Set the content attribute on the &lt;meta&gt; tag
    /// </summary>
    /// <param name="value">what should be in content='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Meta object to enable fluid command chaining</returns>
        public Meta Content(string value) => this.Attr("content", value);




    /// <summary>
    /// Set the http-equiv attribute on the &lt;meta&gt; tag
    /// </summary>
    /// <param name="value">what should be in http-equiv='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Meta object to enable fluid command chaining</returns>
        public Meta HttpEquiv(string value) => this.Attr("http-equiv", value);




    /// <summary>
    /// Set the name attribute on the &lt;meta&gt; tag
    /// </summary>
    /// <param name="value">what should be in name='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Meta object to enable fluid command chaining</returns>
        public Meta Name(string value) => this.Attr("name", value);




    }
}
