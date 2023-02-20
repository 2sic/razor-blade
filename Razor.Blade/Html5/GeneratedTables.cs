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
    /// Generate a standard HTML5 &lt;caption&gt; tag
    /// </summary>
    /// <returns>
    /// A Caption object with all the attributes available in that tag
    /// </returns>
    public partial class Caption : Tag<Caption>
    {
    
    /// <summary>
    /// Generate an &lt;caption&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Caption(object content = null) : base("caption", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;caption&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Caption object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Caption(params object[] content) : base("caption", null, content)
    {
    }
    private Caption(Caption original, CloneChanges changes) : base(original, changes) { }
    internal override Caption CwC(CloneChanges changes) => new Caption(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;col&gt; tag
    /// </summary>
    /// <returns>
    /// A Col object with all the attributes available in that tag
    /// </returns>
    public partial class Col : Tag<Col>
    {
    
    /// <summary>
    /// Generate an &lt;col&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Col(object content = null) : base("col", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;col&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Col object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Col(params object[] content) : base("col", null, content)
    {
    }
    private Col(Col original, CloneChanges changes) : base(original, changes) { }
    internal override Col CwC(CloneChanges changes) => new Col(this, changes);
    
    /// <summary>
    /// Set the span attribute on the &lt;col&gt; tag 
    /// </summary>
    /// <param name="value">what should be in span='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Col object to enable fluid command chaining</returns>
        public Col Span(string value) => this.Attr("span", value);


    /// <summary>
    /// Set the span attribute on the &lt;col&gt; tag 
    /// </summary>
    /// <param name="value">what should be in span='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Col object to enable fluid command chaining</returns>
        public Col Span(int value) => this.Attr("span", value);


    }

    /// <summary>
    /// Generate a standard HTML5 &lt;colgroup&gt; tag
    /// </summary>
    /// <returns>
    /// A Colgroup object with all the attributes available in that tag
    /// </returns>
    public partial class Colgroup : Tag<Colgroup>
    {
    
    /// <summary>
    /// Generate an &lt;colgroup&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Colgroup(object content = null) : base("colgroup", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;colgroup&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Colgroup object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Colgroup(params object[] content) : base("colgroup", null, content)
    {
    }
    private Colgroup(Colgroup original, CloneChanges changes) : base(original, changes) { }
    internal override Colgroup CwC(CloneChanges changes) => new Colgroup(this, changes);
    
    /// <summary>
    /// Set the span attribute on the &lt;colgroup&gt; tag 
    /// </summary>
    /// <param name="value">what should be in span='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Colgroup object to enable fluid command chaining</returns>
        public Colgroup Span(string value) => this.Attr("span", value);


    /// <summary>
    /// Set the span attribute on the &lt;colgroup&gt; tag 
    /// </summary>
    /// <param name="value">what should be in span='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Colgroup object to enable fluid command chaining</returns>
        public Colgroup Span(int value) => this.Attr("span", value);


    }

    /// <summary>
    /// Generate a standard HTML5 &lt;table&gt; tag
    /// </summary>
    /// <returns>
    /// A Table object with all the attributes available in that tag
    /// </returns>
    public partial class Table : Tag<Table>
    {
    
    /// <summary>
    /// Generate an &lt;table&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Table(object content = null) : base("table", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;table&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Table object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Table(params object[] content) : base("table", null, content)
    {
    }
    private Table(Table original, CloneChanges changes) : base(original, changes) { }
    internal override Table CwC(CloneChanges changes) => new Table(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;tbody&gt; tag
    /// </summary>
    /// <returns>
    /// A Tbody object with all the attributes available in that tag
    /// </returns>
    public partial class Tbody : Tag<Tbody>
    {
    
    /// <summary>
    /// Generate an &lt;tbody&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Tbody(object content = null) : base("tbody", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;tbody&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Tbody object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Tbody(params object[] content) : base("tbody", null, content)
    {
    }
    private Tbody(Tbody original, CloneChanges changes) : base(original, changes) { }
    internal override Tbody CwC(CloneChanges changes) => new Tbody(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;td&gt; tag
    /// </summary>
    /// <returns>
    /// A Td object with all the attributes available in that tag
    /// </returns>
    public partial class Td : Tag<Td>
    {
    
    /// <summary>
    /// Generate an &lt;td&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Td(object content = null) : base("td", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;td&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Td object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Td(params object[] content) : base("td", null, content)
    {
    }
    private Td(Td original, CloneChanges changes) : base(original, changes) { }
    internal override Td CwC(CloneChanges changes) => new Td(this, changes);
    
    /// <summary>
    /// Set the colspan attribute on the &lt;td&gt; tag 
    /// </summary>
    /// <param name="value">what should be in colspan='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Td object to enable fluid command chaining</returns>
        public Td Colspan(string value) => this.Attr("colspan", value);


    /// <summary>
    /// Set the colspan attribute on the &lt;td&gt; tag 
    /// </summary>
    /// <param name="value">what should be in colspan='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Td object to enable fluid command chaining</returns>
        public Td Colspan(int value) => this.Attr("colspan", value);


    /// <summary>
    /// Set the headers attribute on the &lt;td&gt; tag 
    /// </summary>
    /// <param name="value">what should be in headers='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Td object to enable fluid command chaining</returns>
        public Td Headers(string value) => this.Attr("headers", value);




    /// <summary>
    /// Set the rowspan attribute on the &lt;td&gt; tag 
    /// </summary>
    /// <param name="value">what should be in rowspan='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Td object to enable fluid command chaining</returns>
        public Td Rowspan(string value) => this.Attr("rowspan", value);


    /// <summary>
    /// Set the rowspan attribute on the &lt;td&gt; tag 
    /// </summary>
    /// <param name="value">what should be in rowspan='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Td object to enable fluid command chaining</returns>
        public Td Rowspan(int value) => this.Attr("rowspan", value);


    }

    /// <summary>
    /// Generate a standard HTML5 &lt;tfoot&gt; tag
    /// </summary>
    /// <returns>
    /// A Tfoot object with all the attributes available in that tag
    /// </returns>
    public partial class Tfoot : Tag<Tfoot>
    {
    
    /// <summary>
    /// Generate an &lt;tfoot&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Tfoot(object content = null) : base("tfoot", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;tfoot&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Tfoot object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Tfoot(params object[] content) : base("tfoot", null, content)
    {
    }
    private Tfoot(Tfoot original, CloneChanges changes) : base(original, changes) { }
    internal override Tfoot CwC(CloneChanges changes) => new Tfoot(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;th&gt; tag
    /// </summary>
    /// <returns>
    /// A Th object with all the attributes available in that tag
    /// </returns>
    public partial class Th : Tag<Th>
    {
    
    /// <summary>
    /// Generate an &lt;th&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Th(object content = null) : base("th", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;th&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Th object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Th(params object[] content) : base("th", null, content)
    {
    }
    private Th(Th original, CloneChanges changes) : base(original, changes) { }
    internal override Th CwC(CloneChanges changes) => new Th(this, changes);
    
    /// <summary>
    /// Set the abbr attribute on the &lt;th&gt; tag 
    /// </summary>
    /// <param name="value">what should be in abbr='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Th object to enable fluid command chaining</returns>
        public Th Abbr(string value) => this.Attr("abbr", value);




    /// <summary>
    /// Set the colspan attribute on the &lt;th&gt; tag 
    /// </summary>
    /// <param name="value">what should be in colspan='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Th object to enable fluid command chaining</returns>
        public Th Colspan(string value) => this.Attr("colspan", value);


    /// <summary>
    /// Set the colspan attribute on the &lt;th&gt; tag 
    /// </summary>
    /// <param name="value">what should be in colspan='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Th object to enable fluid command chaining</returns>
        public Th Colspan(int value) => this.Attr("colspan", value);


    /// <summary>
    /// Set the headers attribute on the &lt;th&gt; tag 
    /// </summary>
    /// <param name="value">what should be in headers='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Th object to enable fluid command chaining</returns>
        public Th Headers(string value) => this.Attr("headers", value);




    /// <summary>
    /// Set the rowspan attribute on the &lt;th&gt; tag 
    /// </summary>
    /// <param name="value">what should be in rowspan='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Th object to enable fluid command chaining</returns>
        public Th Rowspan(string value) => this.Attr("rowspan", value);


    /// <summary>
    /// Set the rowspan attribute on the &lt;th&gt; tag 
    /// </summary>
    /// <param name="value">what should be in rowspan='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Th object to enable fluid command chaining</returns>
        public Th Rowspan(int value) => this.Attr("rowspan", value);


    /// <summary>
    /// Set the scope attribute on the &lt;th&gt; tag 
    /// </summary>
    /// <param name="value">what should be in scope='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Th object to enable fluid command chaining</returns>
        public Th Scope(string value) => this.Attr("scope", value);




    /// <summary>
    /// Set the sorted attribute on the &lt;th&gt; tag 
    /// </summary>
    /// <param name="value">what should be in sorted='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Th object to enable fluid command chaining</returns>
        public Th Sorted(string value) => this.Attr("sorted", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;thead&gt; tag
    /// </summary>
    /// <returns>
    /// A Thead object with all the attributes available in that tag
    /// </returns>
    public partial class Thead : Tag<Thead>
    {
    
    /// <summary>
    /// Generate an &lt;thead&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Thead(object content = null) : base("thead", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;thead&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Thead object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Thead(params object[] content) : base("thead", null, content)
    {
    }
    private Thead(Thead original, CloneChanges changes) : base(original, changes) { }
    internal override Thead CwC(CloneChanges changes) => new Thead(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;tr&gt; tag
    /// </summary>
    /// <returns>
    /// A Tr object with all the attributes available in that tag
    /// </returns>
    public partial class Tr : Tag<Tr>
    {
    
    /// <summary>
    /// Generate an &lt;tr&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Tr(object content = null) : base("tr", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;tr&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Tr object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Tr(params object[] content) : base("tr", null, content)
    {
    }
    private Tr(Tr original, CloneChanges changes) : base(original, changes) { }
    internal override Tr CwC(CloneChanges changes) => new Tr(this, changes);
    
    }
}
