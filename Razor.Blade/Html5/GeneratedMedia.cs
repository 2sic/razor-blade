using System;
using Connect.Razor.Blade;
using Connect.Razor.Html;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created 17.10.2019 21:44
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
    /// Generate a standard HTML5 &lt;audio&gt; tag
    /// </summary>
    /// <returns>
    /// A Audio object with all the attributes available in that tag
    /// </returns>
    public partial class Audio : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;audio&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Audio(object content = null) : base("audio", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;audio&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Audio object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Audio(params object[] content) : base("audio", null, content)
    {
    }
    
    /// <summary>
    /// Set the autoplay attribute on the &lt;audio&gt; tag 
    /// </summary>
    /// <param name="value">what should be in autoplay='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Audio object to enable fluid command chaining</returns>
        public Audio Autoplay(string value) => this.Attr("autoplay", value);




    /// <summary>
    /// Activate the autoplay attribute on the &lt;audio&gt; tag
    /// </summary>
    /// <returns>a Audio object to enable fluid command chaining</returns>
        public Audio Autoplay() => this.Attr("autoplay");


    /// <summary>
    /// Set the controls attribute on the &lt;audio&gt; tag 
    /// </summary>
    /// <param name="value">what should be in controls='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Audio object to enable fluid command chaining</returns>
        public Audio Controls(string value) => this.Attr("controls", value);




    /// <summary>
    /// Activate the controls attribute on the &lt;audio&gt; tag
    /// </summary>
    /// <returns>a Audio object to enable fluid command chaining</returns>
        public Audio Controls() => this.Attr("controls");


    /// <summary>
    /// Set the loop attribute on the &lt;audio&gt; tag 
    /// </summary>
    /// <param name="value">what should be in loop='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Audio object to enable fluid command chaining</returns>
        public Audio Loop(string value) => this.Attr("loop", value);




    /// <summary>
    /// Activate the loop attribute on the &lt;audio&gt; tag
    /// </summary>
    /// <returns>a Audio object to enable fluid command chaining</returns>
        public Audio Loop() => this.Attr("loop");


    /// <summary>
    /// Set the muted attribute on the &lt;audio&gt; tag 
    /// </summary>
    /// <param name="value">what should be in muted='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Audio object to enable fluid command chaining</returns>
        public Audio Muted(string value) => this.Attr("muted", value);




    /// <summary>
    /// Activate the muted attribute on the &lt;audio&gt; tag
    /// </summary>
    /// <returns>a Audio object to enable fluid command chaining</returns>
        public Audio Muted() => this.Attr("muted");


    /// <summary>
    /// Set the preload attribute on the &lt;audio&gt; tag 
    /// </summary>
    /// <param name="value">what should be in preload='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Audio object to enable fluid command chaining</returns>
        public Audio Preload(string value) => this.Attr("preload", value);




    /// <summary>
    /// Set the src attribute on the &lt;audio&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in src='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Audio object to enable fluid command chaining</returns>
        public Audio Src(string value) => this.Attr("src", UriEncode(value));




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;source&gt; tag
    /// </summary>
    /// <returns>
    /// A Source object with all the attributes available in that tag
    /// </returns>
    public partial class Source : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;source&gt; tag with optional contents
    /// </summary>
    
    internal Source() : base("source", new TagOptions { Close = false })
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;source&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Source object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Source(params object[] content) : base("source", new TagOptions { Close = false }, content)
    {
    }
    
    /// <summary>
    /// Set the src attribute on the &lt;source&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in src='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Source object to enable fluid command chaining</returns>
        public Source Src(string value) => this.Attr("src", UriEncode(value));




    /// <summary>
    /// Set the srcset attribute on the &lt;source&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in srcset='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Source object to enable fluid command chaining</returns>
        public Source Srcset(string value) => this.Attr("srcset", UriEncodeSrcSet(value), ",");




    /// <summary>
    /// Add another name/number pair to the srcset attribute on the &lt;source&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="name">image name</param>
    /// <param name="multiplier">what the images is for - numbers below 8 are used for resolution densities, larger numbers for pixel widths</param>  
    /// <returns>a Source object to enable fluid command chaining</returns>
        public Source Srcset(string name, int multiplier) => this.Attr("srcset", UriEncode(name) + " " + multiplier + (multiplier > 8 ? "w" : "x"), ",");


    /// <summary>
    /// Set the media attribute on the &lt;source&gt; tag 
    /// </summary>
    /// <param name="value">what should be in media='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Source object to enable fluid command chaining</returns>
        public Source Media(string value) => this.Attr("media", value);




    /// <summary>
    /// Set the sizes attribute on the &lt;source&gt; tag 
    /// </summary>
    /// <param name="value">what should be in sizes='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Source object to enable fluid command chaining</returns>
        public Source Sizes(string value) => this.Attr("sizes", value);




    /// <summary>
    /// Set the type attribute on the &lt;source&gt; tag 
    /// </summary>
    /// <param name="value">what should be in type='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Source object to enable fluid command chaining</returns>
        public Source Type(string value) => this.Attr("type", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;track&gt; tag
    /// </summary>
    /// <returns>
    /// A Track object with all the attributes available in that tag
    /// </returns>
    public partial class Track : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;track&gt; tag with optional contents
    /// </summary>
    
    internal Track() : base("track", new TagOptions { Close = false })
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;track&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Track object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Track(params object[] content) : base("track", new TagOptions { Close = false }, content)
    {
    }
    
    /// <summary>
    /// Set the default attribute on the &lt;track&gt; tag 
    /// </summary>
    /// <param name="value">what should be in default='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Track object to enable fluid command chaining</returns>
        public Track Default(string value) => this.Attr("default", value);




    /// <summary>
    /// Activate the default attribute on the &lt;track&gt; tag
    /// </summary>
    /// <returns>a Track object to enable fluid command chaining</returns>
        public Track Default() => this.Attr("default");


    /// <summary>
    /// Set the kind attribute on the &lt;track&gt; tag 
    /// </summary>
    /// <param name="value">what should be in kind='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Track object to enable fluid command chaining</returns>
        public Track Kind(string value) => this.Attr("kind", value);




    /// <summary>
    /// Set the label attribute on the &lt;track&gt; tag 
    /// </summary>
    /// <param name="value">what should be in label='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Track object to enable fluid command chaining</returns>
        public Track Label(string value) => this.Attr("label", value);




    /// <summary>
    /// Set the src attribute on the &lt;track&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in src='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Track object to enable fluid command chaining</returns>
        public Track Src(string value) => this.Attr("src", UriEncode(value));




    /// <summary>
    /// Set the srclang attribute on the &lt;track&gt; tag 
    /// </summary>
    /// <param name="value">what should be in srclang='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Track object to enable fluid command chaining</returns>
        public Track Srclang(string value) => this.Attr("srclang", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;video&gt; tag
    /// </summary>
    /// <returns>
    /// A Video object with all the attributes available in that tag
    /// </returns>
    public partial class Video : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;video&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Video(object content = null) : base("video", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;video&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Video object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Video(params object[] content) : base("video", null, content)
    {
    }
    
    /// <summary>
    /// Set the autoplay attribute on the &lt;video&gt; tag 
    /// </summary>
    /// <param name="value">what should be in autoplay='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Autoplay(string value) => this.Attr("autoplay", value);




    /// <summary>
    /// Activate the autoplay attribute on the &lt;video&gt; tag
    /// </summary>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Autoplay() => this.Attr("autoplay");


    /// <summary>
    /// Set the controls attribute on the &lt;video&gt; tag 
    /// </summary>
    /// <param name="value">what should be in controls='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Controls(string value) => this.Attr("controls", value);




    /// <summary>
    /// Activate the controls attribute on the &lt;video&gt; tag
    /// </summary>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Controls() => this.Attr("controls");


    /// <summary>
    /// Set the height attribute on the &lt;video&gt; tag 
    /// </summary>
    /// <param name="value">what should be in height='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Height(string value) => this.Attr("height", value);


    /// <summary>
    /// Set the height attribute on the &lt;video&gt; tag 
    /// </summary>
    /// <param name="value">what should be in height='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Height(int value) => this.Attr("height", value);


    /// <summary>
    /// Set the loop attribute on the &lt;video&gt; tag 
    /// </summary>
    /// <param name="value">what should be in loop='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Loop(string value) => this.Attr("loop", value);




    /// <summary>
    /// Activate the loop attribute on the &lt;video&gt; tag
    /// </summary>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Loop() => this.Attr("loop");


    /// <summary>
    /// Set the muted attribute on the &lt;video&gt; tag 
    /// </summary>
    /// <param name="value">what should be in muted='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Muted(string value) => this.Attr("muted", value);




    /// <summary>
    /// Activate the muted attribute on the &lt;video&gt; tag
    /// </summary>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Muted() => this.Attr("muted");


    /// <summary>
    /// Set the poster attribute on the &lt;video&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in poster='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Poster(string value) => this.Attr("poster", UriEncode(value));




    /// <summary>
    /// Set the preload attribute on the &lt;video&gt; tag 
    /// </summary>
    /// <param name="value">what should be in preload='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Preload(string value) => this.Attr("preload", value);




    /// <summary>
    /// Set the src attribute on the &lt;video&gt; tag 
    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars
    /// </summary>
    /// <param name="value">what should be in src='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Src(string value) => this.Attr("src", UriEncode(value));




    /// <summary>
    /// Set the width attribute on the &lt;video&gt; tag 
    /// </summary>
    /// <param name="value">what should be in width='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Width(string value) => this.Attr("width", value);


    /// <summary>
    /// Set the width attribute on the &lt;video&gt; tag 
    /// </summary>
    /// <param name="value">what should be in width='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Video object to enable fluid command chaining</returns>
        public Video Width(int value) => this.Attr("width", value);


    }
}
