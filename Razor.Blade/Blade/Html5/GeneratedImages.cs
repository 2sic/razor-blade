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
  /// Generate a standard HTML5 &lt;area&gt; tag
  /// </summary>
public partial class Area : Tag
{

  /// <summary>
  /// Generate an &lt;area&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Area(object content = null) : base("area", content)
  {
  }

  /// <summary>
  /// Generate an &lt;area&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Area(params object[] content) : base("area", null, content)
  {
  }

}

  /// <summary>
  /// Generate a standard HTML5 &lt;canvas&gt; tag
  /// </summary>
public partial class Canvas : Tag
{

  /// <summary>
  /// Generate an &lt;canvas&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Canvas(object content = null) : base("canvas", content)
  {
  }

  /// <summary>
  /// Generate an &lt;canvas&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Canvas(params object[] content) : base("canvas", null, content)
  {
  }

  /// <summary>
  /// Set the height attribute on the &lt;canvas&gt; tag
  /// </summary>
  /// <param name="value">what should be height attribute</param>
  /// <returns>a Canvas object to enable fluid command chaining</returns>
      public Canvas Height(string value) => this.Attr("height", value);


  /// <summary>
  /// Set the height attribute on the &lt;canvas&gt; tag
  /// </summary>
  /// <param name="value">what should be height attribute</param>
  /// <returns>a Canvas object to enable fluid command chaining</returns>
      public Canvas Height(int value) => this.Attr("height", value);


  /// <summary>
  /// Set the width attribute on the &lt;canvas&gt; tag
  /// </summary>
  /// <param name="value">what should be width attribute</param>
  /// <returns>a Canvas object to enable fluid command chaining</returns>
      public Canvas Width(string value) => this.Attr("width", value);


  /// <summary>
  /// Set the width attribute on the &lt;canvas&gt; tag
  /// </summary>
  /// <param name="value">what should be width attribute</param>
  /// <returns>a Canvas object to enable fluid command chaining</returns>
      public Canvas Width(int value) => this.Attr("width", value);


}

  /// <summary>
  /// Generate a standard HTML5 &lt;img&gt; tag
  /// </summary>
public partial class Img : Tag
{

  /// <summary>
  /// Generate an &lt;img&gt; tag with optional contents
  /// </summary>
  
  public Img() : base("img", new TagOptions { Close = false })
  {
  }

  /// <summary>
  /// Generate an &lt;img&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Img(params object[] content) : base("img", new TagOptions { Close = false }, content)
  {
  }

  /// <summary>
  /// Set the alt attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="value">what should be alt attribute</param>
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Alt(string value) => this.Attr("alt", value);




  /// <summary>
  /// Set the crossorigin attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="value">what should be crossorigin attribute</param>
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Crossorigin(string value) => this.Attr("crossorigin", value);




  /// <summary>
  /// Set the height attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="value">what should be height attribute</param>
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Height(string value) => this.Attr("height", value);


  /// <summary>
  /// Set the height attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="value">what should be height attribute</param>
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Height(int value) => this.Attr("height", value);


  /// <summary>
  /// Set the longdesc attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="value">what should be longdesc attribute</param>
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Longdesc(string value) => this.Attr("longdesc", value);




  /// <summary>
  /// Set the sizes attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="value">what should be sizes attribute</param>
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Sizes(string value) => this.Attr("sizes", value);




  /// <summary>
  /// Set the src attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="value">what should be src attribute</param>
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Src(string value) => this.Attr("src", value);




  /// <summary>
  /// Set the srcset attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="value">what should be srcset attribute</param>
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Srcset(string value) => this.Attr("srcset", value, ",");




  /// <summary>
  /// Activate the srcset attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="name">image name</param>
  /// <param name="multiplier">what the images is for - numbers below 8 are used for resolution densities, larger numbers for pixel widths</param>  
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Srcset(string name, int multiplier) => Srcset(name + " " + multiplier + (multiplier > 8 ? "w" : "x"));


  /// <summary>
  /// Set the usemap attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="value">what should be usemap attribute</param>
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Usemap(string value) => this.Attr("usemap", value);




  /// <summary>
  /// Set the width attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="value">what should be width attribute</param>
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Width(string value) => this.Attr("width", value);


  /// <summary>
  /// Set the width attribute on the &lt;img&gt; tag
  /// </summary>
  /// <param name="value">what should be width attribute</param>
  /// <returns>a Img object to enable fluid command chaining</returns>
      public Img Width(int value) => this.Attr("width", value);


}

  /// <summary>
  /// Generate a standard HTML5 &lt;map&gt; tag
  /// </summary>
public partial class Map : Tag
{

  /// <summary>
  /// Generate an &lt;map&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Map(object content = null) : base("map", content)
  {
  }

  /// <summary>
  /// Generate an &lt;map&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Map(params object[] content) : base("map", null, content)
  {
  }

  /// <summary>
  /// Set the name attribute on the &lt;map&gt; tag
  /// </summary>
  /// <param name="value">what should be name attribute</param>
  /// <returns>a Map object to enable fluid command chaining</returns>
      public Map Name(string value) => this.Attr("name", value);




}

  /// <summary>
  /// Generate a standard HTML5 &lt;picture&gt; tag
  /// </summary>
public partial class Picture : Tag
{

  /// <summary>
  /// Generate an &lt;picture&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Picture(object content = null) : base("picture", content)
  {
  }

  /// <summary>
  /// Generate an &lt;picture&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Picture(params object[] content) : base("picture", null, content)
  {
  }

}

  /// <summary>
  /// Generate a standard HTML5 &lt;svg&gt; tag
  /// </summary>
public partial class Svg : Tag
{

  /// <summary>
  /// Generate an &lt;svg&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Svg(object content = null) : base("svg", content)
  {
  }

  /// <summary>
  /// Generate an &lt;svg&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Svg(params object[] content) : base("svg", null, content)
  {
  }

  /// <summary>
  /// Set the height attribute on the &lt;svg&gt; tag
  /// </summary>
  /// <param name="value">what should be height attribute</param>
  /// <returns>a Svg object to enable fluid command chaining</returns>
      public Svg Height(string value) => this.Attr("height", value);


  /// <summary>
  /// Set the height attribute on the &lt;svg&gt; tag
  /// </summary>
  /// <param name="value">what should be height attribute</param>
  /// <returns>a Svg object to enable fluid command chaining</returns>
      public Svg Height(int value) => this.Attr("height", value);


  /// <summary>
  /// Set the width attribute on the &lt;svg&gt; tag
  /// </summary>
  /// <param name="value">what should be width attribute</param>
  /// <returns>a Svg object to enable fluid command chaining</returns>
      public Svg Width(string value) => this.Attr("width", value);


  /// <summary>
  /// Set the width attribute on the &lt;svg&gt; tag
  /// </summary>
  /// <param name="value">what should be width attribute</param>
  /// <returns>a Svg object to enable fluid command chaining</returns>
      public Svg Width(int value) => this.Attr("width", value);


}
}
