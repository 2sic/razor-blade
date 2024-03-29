using System;
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.Razor.Markup;
using ToSic.Razor.Internals;
using ToSic.Razor.Internals.Documentation;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created 20.2.2023. 13:35
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
    /// Generate a standard HTML5 &lt;embed&gt; tag
    /// </summary>
    /// <returns>
    /// A Embed object with all the attributes available in that tag
    /// </returns>
    public partial class Embed : Tag<Embed>
    {
    
    /// <summary>
    /// Generate an &lt;embed&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Embed(object content = null) : base("embed", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;embed&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Embed object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Embed(params object[] content) : base("embed", null, content)
    {
    }
    private Embed(Embed original, CloneChanges changes) : base(original, changes) { }
    internal override Embed CwC(CloneChanges changes) => new Embed(this, changes);
    
    /// <summary>
    /// Set the height attribute on the &lt;embed&gt; tag 
    /// </summary>
    /// <param name="value">what should be in height='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Embed object to enable fluid command chaining</returns>
        public Embed Height(string value) => this.Attr("height", value);


    /// <summary>
    /// Set the height attribute on the &lt;embed&gt; tag 
    /// </summary>
    /// <param name="value">what should be in height='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Embed object to enable fluid command chaining</returns>
        public Embed Height(int value) => this.Attr("height", value);


    /// <summary>
    /// Set the src attribute on the &lt;embed&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in src='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Embed object to enable fluid command chaining</returns>
        public Embed Src(string value) => this.Attr("src", UriHelpers.UriEncode(value));




    /// <summary>
    /// Set the type attribute on the &lt;embed&gt; tag 
    /// </summary>
    /// <param name="value">what should be in type='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Embed object to enable fluid command chaining</returns>
        public Embed Type(string value) => this.Attr("type", value);




    /// <summary>
    /// Set the width attribute on the &lt;embed&gt; tag 
    /// </summary>
    /// <param name="value">what should be in width='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Embed object to enable fluid command chaining</returns>
        public Embed Width(string value) => this.Attr("width", value);


    /// <summary>
    /// Set the width attribute on the &lt;embed&gt; tag 
    /// </summary>
    /// <param name="value">what should be in width='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Embed object to enable fluid command chaining</returns>
        public Embed Width(int value) => this.Attr("width", value);


    }

    /// <summary>
    /// Generate a standard HTML5 &lt;noscript&gt; tag
    /// </summary>
    /// <returns>
    /// A Noscript object with all the attributes available in that tag
    /// </returns>
    public partial class Noscript : Tag<Noscript>
    {
    
    /// <summary>
    /// Generate an &lt;noscript&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Noscript(object content = null) : base("noscript", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;noscript&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Noscript object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Noscript(params object[] content) : base("noscript", null, content)
    {
    }
    private Noscript(Noscript original, CloneChanges changes) : base(original, changes) { }
    internal override Noscript CwC(CloneChanges changes) => new Noscript(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;object&gt; tag
    /// </summary>
    /// <returns>
    /// A Object object with all the attributes available in that tag
    /// </returns>
    public partial class Object : Tag<Object>
    {
    
    /// <summary>
    /// Generate an &lt;object&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Object(object content = null) : base("object", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;object&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Object object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Object(params object[] content) : base("object", null, content)
    {
    }
    private Object(Object original, CloneChanges changes) : base(original, changes) { }
    internal override Object CwC(CloneChanges changes) => new Object(this, changes);
    
    /// <summary>
    /// Set the data attribute on the &lt;object&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in data='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Object object to enable fluid command chaining</returns>
        public Object Data(string value) => this.Attr("data", UriHelpers.UriEncode(value));




    /// <summary>
    /// Set the form attribute on the &lt;object&gt; tag 
    /// </summary>
    /// <param name="value">what should be in form='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Object object to enable fluid command chaining</returns>
        public Object Form(string value) => this.Attr("form", value);




    /// <summary>
    /// Set the height attribute on the &lt;object&gt; tag 
    /// </summary>
    /// <param name="value">what should be in height='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Object object to enable fluid command chaining</returns>
        public Object Height(string value) => this.Attr("height", value);


    /// <summary>
    /// Set the height attribute on the &lt;object&gt; tag 
    /// </summary>
    /// <param name="value">what should be in height='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Object object to enable fluid command chaining</returns>
        public Object Height(int value) => this.Attr("height", value);


    /// <summary>
    /// Set the name attribute on the &lt;object&gt; tag 
    /// </summary>
    /// <param name="value">what should be in name='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Object object to enable fluid command chaining</returns>
        public Object Name(string value) => this.Attr("name", value);




    /// <summary>
    /// Set the type attribute on the &lt;object&gt; tag 
    /// </summary>
    /// <param name="value">what should be in type='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Object object to enable fluid command chaining</returns>
        public Object Type(string value) => this.Attr("type", value);




    /// <summary>
    /// Set the usemap attribute on the &lt;object&gt; tag 
    /// </summary>
    /// <param name="value">what should be in usemap='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Object object to enable fluid command chaining</returns>
        public Object Usemap(string value) => this.Attr("usemap", value);




    /// <summary>
    /// Set the width attribute on the &lt;object&gt; tag 
    /// </summary>
    /// <param name="value">what should be in width='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Object object to enable fluid command chaining</returns>
        public Object Width(string value) => this.Attr("width", value);


    /// <summary>
    /// Set the width attribute on the &lt;object&gt; tag 
    /// </summary>
    /// <param name="value">what should be in width='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Object object to enable fluid command chaining</returns>
        public Object Width(int value) => this.Attr("width", value);


    }

    /// <summary>
    /// Generate a standard HTML5 &lt;param&gt; tag
    /// </summary>
    /// <returns>
    /// A Param object with all the attributes available in that tag
    /// </returns>
    public partial class Param : Tag<Param>
    {
    
    /// <summary>
    /// Generate an &lt;param&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Param(object content = null) : base("param", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;param&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Param object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Param(params object[] content) : base("param", null, content)
    {
    }
    private Param(Param original, CloneChanges changes) : base(original, changes) { }
    internal override Param CwC(CloneChanges changes) => new Param(this, changes);
    
    /// <summary>
    /// Set the name attribute on the &lt;param&gt; tag 
    /// </summary>
    /// <param name="value">what should be in name='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Param object to enable fluid command chaining</returns>
        public Param Name(string value) => this.Attr("name", value);




    /// <summary>
    /// Set the value attribute on the &lt;param&gt; tag 
    /// </summary>
    /// <param name="value">what should be in value='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Param object to enable fluid command chaining</returns>
        public Param Value(string value) => this.Attr("value", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;script&gt; tag
    /// </summary>
    /// <returns>
    /// A Script object with all the attributes available in that tag
    /// </returns>
    public partial class Script : Tag<Script>
    {
    
    /// <summary>
    /// Generate an &lt;script&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Script(object content = null) : base("script", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;script&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Script object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Script(params object[] content) : base("script", null, content)
    {
    }
    private Script(Script original, CloneChanges changes) : base(original, changes) { }
    internal override Script CwC(CloneChanges changes) => new Script(this, changes);
    
    /// <summary>
    /// Set the async attribute on the &lt;script&gt; tag 
    /// </summary>
    /// <param name="value">what should be in async='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Script object to enable fluid command chaining</returns>
        public Script Async(string value) => this.Attr("async", value);




    /// <summary>
    /// Activate the async attribute on the &lt;script&gt; tag
    /// </summary>
    /// <returns>a Script object to enable fluid command chaining</returns>
        public Script Async() => this.Attr("async");


    /// <summary>
    /// Set the charset attribute on the &lt;script&gt; tag 
    /// </summary>
    /// <param name="value">what should be in charset='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Script object to enable fluid command chaining</returns>
        public Script Charset(string value) => this.Attr("charset", value);




    /// <summary>
    /// Set the defer attribute on the &lt;script&gt; tag 
    /// </summary>
    /// <param name="value">what should be in defer='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Script object to enable fluid command chaining</returns>
        public Script Defer(string value) => this.Attr("defer", value);




    /// <summary>
    /// Activate the defer attribute on the &lt;script&gt; tag
    /// </summary>
    /// <returns>a Script object to enable fluid command chaining</returns>
        public Script Defer() => this.Attr("defer");


    /// <summary>
    /// Set the src attribute on the &lt;script&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in src='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Script object to enable fluid command chaining</returns>
        public Script Src(string value) => this.Attr("src", UriHelpers.UriEncode(value));




    /// <summary>
    /// Set the type attribute on the &lt;script&gt; tag 
    /// </summary>
    /// <param name="value">what should be in type='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Script object to enable fluid command chaining</returns>
        public Script Type(string value) => this.Attr("type", value);




    }
}
