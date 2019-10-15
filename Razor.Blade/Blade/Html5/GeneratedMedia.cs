using System;
using Connect.Razor.Blade.HtmlTags;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created 16.10.2019 00:54
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
namespace Connect.Razor.Blade.Html5
{

  /// <summary>
  /// Generate a standard HTML5 &lt;audio&gt; tag
  /// </summary>
public partial class Audio : Tag
{

  /// <summary>
  /// Generate an &lt;audio&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Audio(object content = null) : base("audio", content)
  {
  }

  /// <summary>
  /// Generate an &lt;audio&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Audio(params object[] content) : base("audio", null, content)
  {
  }

  /// <summary>
  /// Set the autoplay attribute on the &lt;audio&gt; tag
  /// </summary>
  /// <param name="value">what should be autoplay attribute</param>
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
  /// <param name="value">what should be controls attribute</param>
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
  /// <param name="value">what should be loop attribute</param>
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
  /// <param name="value">what should be muted attribute</param>
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
  /// <param name="value">what should be preload attribute</param>
  /// <returns>a Audio object to enable fluid command chaining</returns>
      public Audio Preload(string value) => this.Attr("preload", value);




  /// <summary>
  /// Set the src attribute on the &lt;audio&gt; tag
  /// </summary>
  /// <param name="value">what should be src attribute</param>
  /// <returns>a Audio object to enable fluid command chaining</returns>
      public Audio Src(string value) => this.Attr("src", value);




}

  /// <summary>
  /// Generate a standard HTML5 &lt;source&gt; tag
  /// </summary>
public partial class Source : Tag
{

  /// <summary>
  /// Generate an &lt;source&gt; tag with optional contents
  /// </summary>
  
  public Source() : base("source", new TagOptions { Close = false })
  {
  }

  /// <summary>
  /// Generate an &lt;source&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Source(params object[] content) : base("source", new TagOptions { Close = false }, content)
  {
  }

  /// <summary>
  /// Set the src attribute on the &lt;source&gt; tag
  /// </summary>
  /// <param name="value">what should be src attribute</param>
  /// <returns>a Source object to enable fluid command chaining</returns>
      public Source Src(string value) => this.Attr("src", value);




  /// <summary>
  /// Set the srcset attribute on the &lt;source&gt; tag
  /// </summary>
  /// <param name="value">what should be srcset attribute</param>
  /// <returns>a Source object to enable fluid command chaining</returns>
      public Source Srcset(string value) => this.Attr("srcset", value, ",");




  /// <summary>
  /// Activate the srcset attribute on the &lt;source&gt; tag
  /// </summary>
  /// <param name="name">image name</param>
  /// <param name="multiplier">what the images is for - numbers below 8 are used for resolution densities, larger numbers for pixel widths</param>  
  /// <returns>a Source object to enable fluid command chaining</returns>
      public Source Srcset(string name, int multiplier) => Srcset(name + " " + multiplier + (multiplier > 8 ? "w" : "x"));


  /// <summary>
  /// Set the media attribute on the &lt;source&gt; tag
  /// </summary>
  /// <param name="value">what should be media attribute</param>
  /// <returns>a Source object to enable fluid command chaining</returns>
      public Source Media(string value) => this.Attr("media", value);




  /// <summary>
  /// Set the sizes attribute on the &lt;source&gt; tag
  /// </summary>
  /// <param name="value">what should be sizes attribute</param>
  /// <returns>a Source object to enable fluid command chaining</returns>
      public Source Sizes(string value) => this.Attr("sizes", value);




  /// <summary>
  /// Set the type attribute on the &lt;source&gt; tag
  /// </summary>
  /// <param name="value">what should be type attribute</param>
  /// <returns>a Source object to enable fluid command chaining</returns>
      public Source Type(string value) => this.Attr("type", value);




}

  /// <summary>
  /// Generate a standard HTML5 &lt;track&gt; tag
  /// </summary>
public partial class Track : Tag
{

  /// <summary>
  /// Generate an &lt;track&gt; tag with optional contents
  /// </summary>
  
  public Track() : base("track", new TagOptions { Close = false })
  {
  }

  /// <summary>
  /// Generate an &lt;track&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Track(params object[] content) : base("track", new TagOptions { Close = false }, content)
  {
  }

  /// <summary>
  /// Set the default attribute on the &lt;track&gt; tag
  /// </summary>
  /// <param name="value">what should be default attribute</param>
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
  /// <param name="value">what should be kind attribute</param>
  /// <returns>a Track object to enable fluid command chaining</returns>
      public Track Kind(string value) => this.Attr("kind", value);




  /// <summary>
  /// Set the label attribute on the &lt;track&gt; tag
  /// </summary>
  /// <param name="value">what should be label attribute</param>
  /// <returns>a Track object to enable fluid command chaining</returns>
      public Track Label(string value) => this.Attr("label", value);




  /// <summary>
  /// Set the src attribute on the &lt;track&gt; tag
  /// </summary>
  /// <param name="value">what should be src attribute</param>
  /// <returns>a Track object to enable fluid command chaining</returns>
      public Track Src(string value) => this.Attr("src", value);




  /// <summary>
  /// Set the srclang attribute on the &lt;track&gt; tag
  /// </summary>
  /// <param name="value">what should be srclang attribute</param>
  /// <returns>a Track object to enable fluid command chaining</returns>
      public Track Srclang(string value) => this.Attr("srclang", value);




}

  /// <summary>
  /// Generate a standard HTML5 &lt;video&gt; tag
  /// </summary>
public partial class Video : Tag
{

  /// <summary>
  /// Generate an &lt;video&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Video(object content = null) : base("video", content)
  {
  }

  /// <summary>
  /// Generate an &lt;video&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Video(params object[] content) : base("video", null, content)
  {
  }

  /// <summary>
  /// Set the autoplay attribute on the &lt;video&gt; tag
  /// </summary>
  /// <param name="value">what should be autoplay attribute</param>
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
  /// <param name="value">what should be controls attribute</param>
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
  /// <param name="value">what should be height attribute</param>
  /// <returns>a Video object to enable fluid command chaining</returns>
      public Video Height(string value) => this.Attr("height", value);


  /// <summary>
  /// Set the height attribute on the &lt;video&gt; tag
  /// </summary>
  /// <param name="value">what should be height attribute</param>
  /// <returns>a Video object to enable fluid command chaining</returns>
      public Video Height(int value) => this.Attr("height", value);


  /// <summary>
  /// Set the loop attribute on the &lt;video&gt; tag
  /// </summary>
  /// <param name="value">what should be loop attribute</param>
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
  /// <param name="value">what should be muted attribute</param>
  /// <returns>a Video object to enable fluid command chaining</returns>
      public Video Muted(string value) => this.Attr("muted", value);




  /// <summary>
  /// Activate the muted attribute on the &lt;video&gt; tag
  /// </summary>
  /// <returns>a Video object to enable fluid command chaining</returns>
      public Video Muted() => this.Attr("muted");


  /// <summary>
  /// Set the poster attribute on the &lt;video&gt; tag
  /// </summary>
  /// <param name="value">what should be poster attribute</param>
  /// <returns>a Video object to enable fluid command chaining</returns>
      public Video Poster(string value) => this.Attr("poster", value);




  /// <summary>
  /// Set the preload attribute on the &lt;video&gt; tag
  /// </summary>
  /// <param name="value">what should be preload attribute</param>
  /// <returns>a Video object to enable fluid command chaining</returns>
      public Video Preload(string value) => this.Attr("preload", value);




  /// <summary>
  /// Set the src attribute on the &lt;video&gt; tag
  /// </summary>
  /// <param name="value">what should be src attribute</param>
  /// <returns>a Video object to enable fluid command chaining</returns>
      public Video Src(string value) => this.Attr("src", value);




  /// <summary>
  /// Set the width attribute on the &lt;video&gt; tag
  /// </summary>
  /// <param name="value">what should be width attribute</param>
  /// <returns>a Video object to enable fluid command chaining</returns>
      public Video Width(string value) => this.Attr("width", value);


  /// <summary>
  /// Set the width attribute on the &lt;video&gt; tag
  /// </summary>
  /// <param name="value">what should be width attribute</param>
  /// <returns>a Video object to enable fluid command chaining</returns>
      public Video Width(int value) => this.Attr("width", value);


}
}
