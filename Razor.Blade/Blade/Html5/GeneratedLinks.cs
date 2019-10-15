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
  /// Generate a standard HTML5 &lt;a&gt; tag
  /// </summary>
public partial class A : Tag
{

  /// <summary>
  /// Generate an &lt;a&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public A(object content = null) : base("a", content)
  {
  }

  /// <summary>
  /// Generate an &lt;a&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public A(params object[] content) : base("a", null, content)
  {
  }

  /// <summary>
  /// Set the download attribute on the &lt;a&gt; tag
  /// </summary>
  /// <param name="value">what should be download attribute</param>
  /// <returns>a A object to enable fluid command chaining</returns>
      public A Download(string value) => this.Attr("download", value);




  /// <summary>
  /// Set the href attribute on the &lt;a&gt; tag
  /// </summary>
  /// <param name="value">what should be href attribute</param>
  /// <returns>a A object to enable fluid command chaining</returns>
      public A Href(string value) => this.Attr("href", value);




  /// <summary>
  /// Set the hreflang attribute on the &lt;a&gt; tag
  /// </summary>
  /// <param name="value">what should be hreflang attribute</param>
  /// <returns>a A object to enable fluid command chaining</returns>
      public A Hreflang(string value) => this.Attr("hreflang", value);




  /// <summary>
  /// Set the media attribute on the &lt;a&gt; tag
  /// </summary>
  /// <param name="value">what should be media attribute</param>
  /// <returns>a A object to enable fluid command chaining</returns>
      public A Media(string value) => this.Attr("media", value);




  /// <summary>
  /// Set the ping attribute on the &lt;a&gt; tag
  /// </summary>
  /// <param name="value">what should be ping attribute</param>
  /// <returns>a A object to enable fluid command chaining</returns>
      public A Ping(string value) => this.Attr("ping", value);




  /// <summary>
  /// Set the rel attribute on the &lt;a&gt; tag
  /// </summary>
  /// <param name="value">what should be rel attribute</param>
  /// <returns>a A object to enable fluid command chaining</returns>
      public A Rel(string value) => this.Attr("rel", value);




  /// <summary>
  /// Set the target attribute on the &lt;a&gt; tag
  /// </summary>
  /// <param name="value">what should be target attribute</param>
  /// <returns>a A object to enable fluid command chaining</returns>
      public A Target(string value) => this.Attr("target", value);




  /// <summary>
  /// Set the type attribute on the &lt;a&gt; tag
  /// </summary>
  /// <param name="value">what should be type attribute</param>
  /// <returns>a A object to enable fluid command chaining</returns>
      public A Type(string value) => this.Attr("type", value);




}

  /// <summary>
  /// Generate a standard HTML5 &lt;link&gt; tag
  /// </summary>
public partial class Link : Tag
{

  /// <summary>
  /// Generate an &lt;link&gt; tag with optional contents
  /// </summary>
  
  public Link() : base("link", new TagOptions { Close = false })
  {
  }

  /// <summary>
  /// Generate an &lt;link&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Link(params object[] content) : base("link", new TagOptions { Close = false }, content)
  {
  }

  /// <summary>
  /// Set the crossorigin attribute on the &lt;link&gt; tag
  /// </summary>
  /// <param name="value">what should be crossorigin attribute</param>
  /// <returns>a Link object to enable fluid command chaining</returns>
      public Link Crossorigin(string value) => this.Attr("crossorigin", value);




  /// <summary>
  /// Set the href attribute on the &lt;link&gt; tag
  /// </summary>
  /// <param name="value">what should be href attribute</param>
  /// <returns>a Link object to enable fluid command chaining</returns>
      public Link Href(string value) => this.Attr("href", value);




  /// <summary>
  /// Set the hreflang attribute on the &lt;link&gt; tag
  /// </summary>
  /// <param name="value">what should be hreflang attribute</param>
  /// <returns>a Link object to enable fluid command chaining</returns>
      public Link Hreflang(string value) => this.Attr("hreflang", value);




  /// <summary>
  /// Set the media attribute on the &lt;link&gt; tag
  /// </summary>
  /// <param name="value">what should be media attribute</param>
  /// <returns>a Link object to enable fluid command chaining</returns>
      public Link Media(string value) => this.Attr("media", value);




  /// <summary>
  /// Set the rel attribute on the &lt;link&gt; tag
  /// </summary>
  /// <param name="value">what should be rel attribute</param>
  /// <returns>a Link object to enable fluid command chaining</returns>
      public Link Rel(string value) => this.Attr("rel", value);




  /// <summary>
  /// Set the type attribute on the &lt;link&gt; tag
  /// </summary>
  /// <param name="value">what should be type attribute</param>
  /// <returns>a Link object to enable fluid command chaining</returns>
      public Link Type(string value) => this.Attr("type", value);




}

  /// <summary>
  /// Generate a standard HTML5 &lt;nav&gt; tag
  /// </summary>
public partial class Nav : Tag
{

  /// <summary>
  /// Generate an &lt;nav&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Nav(object content = null) : base("nav", content)
  {
  }

  /// <summary>
  /// Generate an &lt;nav&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Nav(params object[] content) : base("nav", null, content)
  {
  }

}
}
