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
    /// Generate a standard HTML5 &lt;article&gt; tag
    /// </summary>
    /// <returns>
    /// A Article object with all the attributes available in that tag
    /// </returns>
    public partial class Article : Tag<Article>
    {
    
    /// <summary>
    /// Generate an &lt;article&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Article(object content = null) : base("article", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;article&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Article object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Article(params object[] content) : base("article", null, content)
    {
    }
    private Article(Article original, CloneChanges changes) : base(original, changes) { }
    internal override Article CwC(CloneChanges changes) => new Article(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;aside&gt; tag
    /// </summary>
    /// <returns>
    /// A Aside object with all the attributes available in that tag
    /// </returns>
    public partial class Aside : Tag<Aside>
    {
    
    /// <summary>
    /// Generate an &lt;aside&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Aside(object content = null) : base("aside", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;aside&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Aside object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Aside(params object[] content) : base("aside", null, content)
    {
    }
    private Aside(Aside original, CloneChanges changes) : base(original, changes) { }
    internal override Aside CwC(CloneChanges changes) => new Aside(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;data&gt; tag
    /// </summary>
    /// <returns>
    /// A Data object with all the attributes available in that tag
    /// </returns>
    public partial class Data : Tag<Data>
    {
    
    /// <summary>
    /// Generate an &lt;data&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Data(object content = null) : base("data", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;data&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Data object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Data(params object[] content) : base("data", null, content)
    {
    }
    private Data(Data original, CloneChanges changes) : base(original, changes) { }
    internal override Data CwC(CloneChanges changes) => new Data(this, changes);
    
    /// <summary>
    /// Set the open attribute on the &lt;data&gt; tag 
    /// </summary>
    /// <param name="value">what should be in open='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Data object to enable fluid command chaining</returns>
        public Data Open(string value) => this.Attr("open", value);




    /// <summary>
    /// Activate the open attribute on the &lt;data&gt; tag
    /// </summary>
    /// <returns>a Data object to enable fluid command chaining</returns>
        public Data Open() => this.Attr("open");


    }

    /// <summary>
    /// Generate a standard HTML5 &lt;details&gt; tag
    /// </summary>
    /// <returns>
    /// A Details object with all the attributes available in that tag
    /// </returns>
    public partial class Details : Tag<Details>
    {
    
    /// <summary>
    /// Generate an &lt;details&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Details(object content = null) : base("details", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;details&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Details object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Details(params object[] content) : base("details", null, content)
    {
    }
    private Details(Details original, CloneChanges changes) : base(original, changes) { }
    internal override Details CwC(CloneChanges changes) => new Details(this, changes);
    
    /// <summary>
    /// Set the open attribute on the &lt;details&gt; tag 
    /// </summary>
    /// <param name="value">what should be in open='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Details object to enable fluid command chaining</returns>
        public Details Open(string value) => this.Attr("open", value);




    /// <summary>
    /// Activate the open attribute on the &lt;details&gt; tag
    /// </summary>
    /// <returns>a Details object to enable fluid command chaining</returns>
        public Details Open() => this.Attr("open");


    }

    /// <summary>
    /// Generate a standard HTML5 &lt;dialog&gt; tag
    /// </summary>
    /// <returns>
    /// A Dialog object with all the attributes available in that tag
    /// </returns>
    public partial class Dialog : Tag<Dialog>
    {
    
    /// <summary>
    /// Generate an &lt;dialog&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Dialog(object content = null) : base("dialog", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;dialog&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Dialog object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Dialog(params object[] content) : base("dialog", null, content)
    {
    }
    private Dialog(Dialog original, CloneChanges changes) : base(original, changes) { }
    internal override Dialog CwC(CloneChanges changes) => new Dialog(this, changes);
    
    /// <summary>
    /// Set the open attribute on the &lt;dialog&gt; tag 
    /// </summary>
    /// <param name="value">what should be in open='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Dialog object to enable fluid command chaining</returns>
        public Dialog Open(string value) => this.Attr("open", value);




    /// <summary>
    /// Activate the open attribute on the &lt;dialog&gt; tag
    /// </summary>
    /// <returns>a Dialog object to enable fluid command chaining</returns>
        public Dialog Open() => this.Attr("open");


    }

    /// <summary>
    /// Generate a standard HTML5 &lt;div&gt; tag
    /// </summary>
    /// <returns>
    /// A Div object with all the attributes available in that tag
    /// </returns>
    public partial class Div : Tag<Div>
    {
    
    /// <summary>
    /// Generate an &lt;div&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Div(object content = null) : base("div", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;div&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Div object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Div(params object[] content) : base("div", null, content)
    {
    }
    private Div(Div original, CloneChanges changes) : base(original, changes) { }
    internal override Div CwC(CloneChanges changes) => new Div(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;footer&gt; tag
    /// </summary>
    /// <returns>
    /// A Footer object with all the attributes available in that tag
    /// </returns>
    public partial class Footer : Tag<Footer>
    {
    
    /// <summary>
    /// Generate an &lt;footer&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Footer(object content = null) : base("footer", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;footer&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Footer object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Footer(params object[] content) : base("footer", null, content)
    {
    }
    private Footer(Footer original, CloneChanges changes) : base(original, changes) { }
    internal override Footer CwC(CloneChanges changes) => new Footer(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;header&gt; tag
    /// </summary>
    /// <returns>
    /// A Header object with all the attributes available in that tag
    /// </returns>
    public partial class Header : Tag<Header>
    {
    
    /// <summary>
    /// Generate an &lt;header&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Header(object content = null) : base("header", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;header&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Header object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Header(params object[] content) : base("header", null, content)
    {
    }
    private Header(Header original, CloneChanges changes) : base(original, changes) { }
    internal override Header CwC(CloneChanges changes) => new Header(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;main&gt; tag
    /// </summary>
    /// <returns>
    /// A Main object with all the attributes available in that tag
    /// </returns>
    public partial class Main : Tag<Main>
    {
    
    /// <summary>
    /// Generate an &lt;main&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Main(object content = null) : base("main", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;main&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Main object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Main(params object[] content) : base("main", null, content)
    {
    }
    private Main(Main original, CloneChanges changes) : base(original, changes) { }
    internal override Main CwC(CloneChanges changes) => new Main(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;section&gt; tag
    /// </summary>
    /// <returns>
    /// A Section object with all the attributes available in that tag
    /// </returns>
    public partial class Section : Tag<Section>
    {
    
    /// <summary>
    /// Generate an &lt;section&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Section(object content = null) : base("section", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;section&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Section object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Section(params object[] content) : base("section", null, content)
    {
    }
    private Section(Section original, CloneChanges changes) : base(original, changes) { }
    internal override Section CwC(CloneChanges changes) => new Section(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;span&gt; tag
    /// </summary>
    /// <returns>
    /// A Span object with all the attributes available in that tag
    /// </returns>
    public partial class Span : Tag<Span>
    {
    
    /// <summary>
    /// Generate an &lt;span&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Span(object content = null) : base("span", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;span&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Span object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Span(params object[] content) : base("span", null, content)
    {
    }
    private Span(Span original, CloneChanges changes) : base(original, changes) { }
    internal override Span CwC(CloneChanges changes) => new Span(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;style&gt; tag
    /// </summary>
    /// <returns>
    /// A Style object with all the attributes available in that tag
    /// </returns>
    public partial class Style : Tag<Style>
    {
    
    /// <summary>
    /// Generate an &lt;style&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Style(object content = null) : base("style", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;style&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Style object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Style(params object[] content) : base("style", null, content)
    {
    }
    private Style(Style original, CloneChanges changes) : base(original, changes) { }
    internal override Style CwC(CloneChanges changes) => new Style(this, changes);
    
    /// <summary>
    /// Set the media attribute on the &lt;style&gt; tag 
    /// </summary>
    /// <param name="value">what should be in media='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Style object to enable fluid command chaining</returns>
        public Style Media(string value) => this.Attr("media", value);




    /// <summary>
    /// Set the type attribute on the &lt;style&gt; tag 
    /// </summary>
    /// <param name="value">what should be in type='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Style object to enable fluid command chaining</returns>
        public Style Type(string value) => this.Attr("type", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;summary&gt; tag
    /// </summary>
    /// <returns>
    /// A Summary object with all the attributes available in that tag
    /// </returns>
    public partial class Summary : Tag<Summary>
    {
    
    /// <summary>
    /// Generate an &lt;summary&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Summary(object content = null) : base("summary", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;summary&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Summary object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Summary(params object[] content) : base("summary", null, content)
    {
    }
    private Summary(Summary original, CloneChanges changes) : base(original, changes) { }
    internal override Summary CwC(CloneChanges changes) => new Summary(this, changes);
    
    }
}
