using System;
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.Razor.Markup;
using ToSic.Razor.Internals.Documentation;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created 07.12.2022 00:28
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
    /// Generate a standard HTML5 &lt;base&gt; tag
    /// </summary>
    /// <returns>
    /// A Base object with all the attributes available in that tag
    /// </returns>
    public partial class Base : Tag<Base>
    {
    
    /// <summary>
    /// Generate an &lt;base&gt; tag with optional contents
    /// </summary>
    
    internal Base() : base("base", new TagOptions(close: false))
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;base&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Base object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Base(params object[] content) : base("base", new TagOptions(close: false), content)
    {
    }
    private Base(Base original, CloneChanges changes) : base(original, changes) { }
    internal override Base CwC(CloneChanges changes) => new Base(this, changes);
    
    /// <summary>
    /// Set the href attribute on the &lt;base&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in href='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Base object to enable fluid command chaining</returns>
        public Base Href(string value) => this.Attr("href", UriEncode(value));




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
    public partial class Head : Tag<Head>
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
    private Head(Head original, CloneChanges changes) : base(original, changes) { }
    internal override Head CwC(CloneChanges changes) => new Head(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;meta&gt; tag
    /// </summary>
    /// <returns>
    /// A Meta object with all the attributes available in that tag
    /// </returns>
    public partial class Meta : Tag<Meta>
    {
    
    /// <summary>
    /// Generate an &lt;meta&gt; tag with optional contents
    /// </summary>
    
    internal Meta() : base("meta", new TagOptions(close: false))
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;meta&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Meta object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Meta(params object[] content) : base("meta", new TagOptions(close: false), content)
    {
    }
    private Meta(Meta original, CloneChanges changes) : base(original, changes) { }
    internal override Meta CwC(CloneChanges changes) => new Meta(this, changes);
    
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
