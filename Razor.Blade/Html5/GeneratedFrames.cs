using ToSic.Razor.Markup;

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
    /// Generate a standard HTML5 &lt;iframe&gt; tag
    /// </summary>
    /// <returns>
    /// A Iframe object with all the attributes available in that tag
    /// </returns>
    public partial class Iframe : Tag<Iframe>
    {
    
    /// <summary>
    /// Generate an &lt;iframe&gt; tag with optional contents
    /// </summary>
    
    internal Iframe() : base("iframe", new TagOptions(close: false))
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;iframe&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Iframe object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Iframe(params object[] content) : base("iframe", new TagOptions(close: false), content)
    {
    }
    private Iframe(Iframe original, CloneChanges changes) : base(original, changes) { }
    internal override Iframe CwC(CloneChanges changes) => new Iframe(this, changes);
    
    /// <summary>
    /// Set the height attribute on the &lt;iframe&gt; tag 
    /// </summary>
    /// <param name="value">what should be in height='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Iframe object to enable fluid command chaining</returns>
        public Iframe Height(string value) => this.Attr("height", value);


    /// <summary>
    /// Set the height attribute on the &lt;iframe&gt; tag 
    /// </summary>
    /// <param name="value">what should be in height='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Iframe object to enable fluid command chaining</returns>
        public Iframe Height(int value) => this.Attr("height", value);


    /// <summary>
    /// Set the name attribute on the &lt;iframe&gt; tag 
    /// </summary>
    /// <param name="value">what should be in name='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Iframe object to enable fluid command chaining</returns>
        public Iframe Name(string value) => this.Attr("name", value);




    /// <summary>
    /// Set the sandbox attribute on the &lt;iframe&gt; tag 
    /// </summary>
    /// <param name="value">what should be in sandbox='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Iframe object to enable fluid command chaining</returns>
        public Iframe Sandbox(string value) => this.Attr("sandbox", value);




    /// <summary>
    /// Set the src attribute on the &lt;iframe&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in src='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Iframe object to enable fluid command chaining</returns>
        public Iframe Src(string value) => this.Attr("src", UriEncode(value));




    /// <summary>
    /// Set the srcdoc attribute on the &lt;iframe&gt; tag 
    /// </summary>
    /// <param name="value">what should be in srcdoc='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Iframe object to enable fluid command chaining</returns>
        public Iframe Srcdoc(string value) => this.Attr("srcdoc", value);




    /// <summary>
    /// Set the width attribute on the &lt;iframe&gt; tag 
    /// </summary>
    /// <param name="value">what should be in width='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Iframe object to enable fluid command chaining</returns>
        public Iframe Width(string value) => this.Attr("width", value);


    /// <summary>
    /// Set the width attribute on the &lt;iframe&gt; tag 
    /// </summary>
    /// <param name="value">what should be in width='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Iframe object to enable fluid command chaining</returns>
        public Iframe Width(int value) => this.Attr("width", value);


    }
}
