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
  /// Generate a standard HTML5 &lt;caption&gt; tag
  /// </summary>
public partial class Caption : Tag
{

  /// <summary>
  /// Generate an &lt;caption&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Caption(object content = null) : base("caption", content)
  {
  }

  /// <summary>
  /// Generate an &lt;caption&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Caption(params object[] content) : base("caption", null, content)
  {
  }

}

  /// <summary>
  /// Generate a standard HTML5 &lt;col&gt; tag
  /// </summary>
public partial class Col : Tag
{

  /// <summary>
  /// Generate an &lt;col&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Col(object content = null) : base("col", content)
  {
  }

  /// <summary>
  /// Generate an &lt;col&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Col(params object[] content) : base("col", null, content)
  {
  }

  /// <summary>
  /// Set the span attribute on the &lt;col&gt; tag
  /// </summary>
  /// <param name="value">what should be span attribute</param>
  /// <returns>a Col object to enable fluid command chaining</returns>
      public Col Span(string value) => this.Attr("span", value);


  /// <summary>
  /// Set the span attribute on the &lt;col&gt; tag
  /// </summary>
  /// <param name="value">what should be span attribute</param>
  /// <returns>a Col object to enable fluid command chaining</returns>
      public Col Span(int value) => this.Attr("span", value);


}

  /// <summary>
  /// Generate a standard HTML5 &lt;colgroup&gt; tag
  /// </summary>
public partial class Colgroup : Tag
{

  /// <summary>
  /// Generate an &lt;colgroup&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Colgroup(object content = null) : base("colgroup", content)
  {
  }

  /// <summary>
  /// Generate an &lt;colgroup&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Colgroup(params object[] content) : base("colgroup", null, content)
  {
  }

  /// <summary>
  /// Set the span attribute on the &lt;colgroup&gt; tag
  /// </summary>
  /// <param name="value">what should be span attribute</param>
  /// <returns>a Colgroup object to enable fluid command chaining</returns>
      public Colgroup Span(string value) => this.Attr("span", value);


  /// <summary>
  /// Set the span attribute on the &lt;colgroup&gt; tag
  /// </summary>
  /// <param name="value">what should be span attribute</param>
  /// <returns>a Colgroup object to enable fluid command chaining</returns>
      public Colgroup Span(int value) => this.Attr("span", value);


}

  /// <summary>
  /// Generate a standard HTML5 &lt;table&gt; tag
  /// </summary>
public partial class Table : Tag
{

  /// <summary>
  /// Generate an &lt;table&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Table(object content = null) : base("table", content)
  {
  }

  /// <summary>
  /// Generate an &lt;table&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Table(params object[] content) : base("table", null, content)
  {
  }

}

  /// <summary>
  /// Generate a standard HTML5 &lt;tbody&gt; tag
  /// </summary>
public partial class Tbody : Tag
{

  /// <summary>
  /// Generate an &lt;tbody&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Tbody(object content = null) : base("tbody", content)
  {
  }

  /// <summary>
  /// Generate an &lt;tbody&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Tbody(params object[] content) : base("tbody", null, content)
  {
  }

}

  /// <summary>
  /// Generate a standard HTML5 &lt;td&gt; tag
  /// </summary>
public partial class Td : Tag
{

  /// <summary>
  /// Generate an &lt;td&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Td(object content = null) : base("td", content)
  {
  }

  /// <summary>
  /// Generate an &lt;td&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Td(params object[] content) : base("td", null, content)
  {
  }

  /// <summary>
  /// Set the colspan attribute on the &lt;td&gt; tag
  /// </summary>
  /// <param name="value">what should be colspan attribute</param>
  /// <returns>a Td object to enable fluid command chaining</returns>
      public Td Colspan(string value) => this.Attr("colspan", value);


  /// <summary>
  /// Set the colspan attribute on the &lt;td&gt; tag
  /// </summary>
  /// <param name="value">what should be colspan attribute</param>
  /// <returns>a Td object to enable fluid command chaining</returns>
      public Td Colspan(int value) => this.Attr("colspan", value);


  /// <summary>
  /// Set the headers attribute on the &lt;td&gt; tag
  /// </summary>
  /// <param name="value">what should be headers attribute</param>
  /// <returns>a Td object to enable fluid command chaining</returns>
      public Td Headers(string value) => this.Attr("headers", value);




  /// <summary>
  /// Set the rowspan attribute on the &lt;td&gt; tag
  /// </summary>
  /// <param name="value">what should be rowspan attribute</param>
  /// <returns>a Td object to enable fluid command chaining</returns>
      public Td Rowspan(string value) => this.Attr("rowspan", value);


  /// <summary>
  /// Set the rowspan attribute on the &lt;td&gt; tag
  /// </summary>
  /// <param name="value">what should be rowspan attribute</param>
  /// <returns>a Td object to enable fluid command chaining</returns>
      public Td Rowspan(int value) => this.Attr("rowspan", value);


}

  /// <summary>
  /// Generate a standard HTML5 &lt;tfoot&gt; tag
  /// </summary>
public partial class Tfoot : Tag
{

  /// <summary>
  /// Generate an &lt;tfoot&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Tfoot(object content = null) : base("tfoot", content)
  {
  }

  /// <summary>
  /// Generate an &lt;tfoot&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Tfoot(params object[] content) : base("tfoot", null, content)
  {
  }

}

  /// <summary>
  /// Generate a standard HTML5 &lt;th&gt; tag
  /// </summary>
public partial class Th : Tag
{

  /// <summary>
  /// Generate an &lt;th&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Th(object content = null) : base("th", content)
  {
  }

  /// <summary>
  /// Generate an &lt;th&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Th(params object[] content) : base("th", null, content)
  {
  }

  /// <summary>
  /// Set the abbr attribute on the &lt;th&gt; tag
  /// </summary>
  /// <param name="value">what should be abbr attribute</param>
  /// <returns>a Th object to enable fluid command chaining</returns>
      public Th Abbr(string value) => this.Attr("abbr", value);




  /// <summary>
  /// Set the colspan attribute on the &lt;th&gt; tag
  /// </summary>
  /// <param name="value">what should be colspan attribute</param>
  /// <returns>a Th object to enable fluid command chaining</returns>
      public Th Colspan(string value) => this.Attr("colspan", value);


  /// <summary>
  /// Set the colspan attribute on the &lt;th&gt; tag
  /// </summary>
  /// <param name="value">what should be colspan attribute</param>
  /// <returns>a Th object to enable fluid command chaining</returns>
      public Th Colspan(int value) => this.Attr("colspan", value);


  /// <summary>
  /// Set the headers attribute on the &lt;th&gt; tag
  /// </summary>
  /// <param name="value">what should be headers attribute</param>
  /// <returns>a Th object to enable fluid command chaining</returns>
      public Th Headers(string value) => this.Attr("headers", value);




  /// <summary>
  /// Set the rowspan attribute on the &lt;th&gt; tag
  /// </summary>
  /// <param name="value">what should be rowspan attribute</param>
  /// <returns>a Th object to enable fluid command chaining</returns>
      public Th Rowspan(string value) => this.Attr("rowspan", value);


  /// <summary>
  /// Set the rowspan attribute on the &lt;th&gt; tag
  /// </summary>
  /// <param name="value">what should be rowspan attribute</param>
  /// <returns>a Th object to enable fluid command chaining</returns>
      public Th Rowspan(int value) => this.Attr("rowspan", value);


  /// <summary>
  /// Set the scope attribute on the &lt;th&gt; tag
  /// </summary>
  /// <param name="value">what should be scope attribute</param>
  /// <returns>a Th object to enable fluid command chaining</returns>
      public Th Scope(string value) => this.Attr("scope", value);




  /// <summary>
  /// Set the sorted attribute on the &lt;th&gt; tag
  /// </summary>
  /// <param name="value">what should be sorted attribute</param>
  /// <returns>a Th object to enable fluid command chaining</returns>
      public Th Sorted(string value) => this.Attr("sorted", value);




}

  /// <summary>
  /// Generate a standard HTML5 &lt;thead&gt; tag
  /// </summary>
public partial class Thead : Tag
{

  /// <summary>
  /// Generate an &lt;thead&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Thead(object content = null) : base("thead", content)
  {
  }

  /// <summary>
  /// Generate an &lt;thead&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Thead(params object[] content) : base("thead", null, content)
  {
  }

}

  /// <summary>
  /// Generate a standard HTML5 &lt;tr&gt; tag
  /// </summary>
public partial class Tr : Tag
{

  /// <summary>
  /// Generate an &lt;tr&gt; tag with optional contents
  /// </summary>
  /// <param name="content">content which will be inside the tag</param>
  public Tr(object content = null) : base("tr", content)
  {
  }

  /// <summary>
  /// Generate an &lt;tr&gt; tag with optional contents
  /// </summary>
  /// <param name="content">list of objects (strings, tags) which will be inside the tag</param>
  public Tr(params object[] content) : base("tr", null, content)
  {
  }

}
}
