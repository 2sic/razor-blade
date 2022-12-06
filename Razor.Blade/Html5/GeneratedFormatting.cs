using System;
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.Razor.Markup;
using ToSic.Razor.Internals.Documentation;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created 06.12.2022 21:53
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
    /// Generate a standard HTML5 &lt;abbr&gt; tag
    /// </summary>
    /// <returns>
    /// A Abbr object with all the attributes available in that tag
    /// </returns>
    public partial class Abbr : Tag<Abbr>
    {
    
    /// <summary>
    /// Generate an &lt;abbr&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Abbr(bool fluid, object content = null) : base(fluid, "abbr", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;abbr&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Abbr object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Abbr(bool fluid, params object[] content) : base(fluid, "abbr", null, content)
    {
    }
    private Abbr(Abbr original, CloneChanges changes) : base(original, changes) { }
    internal override Abbr CwC(CloneChanges changes) => new Abbr(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;address&gt; tag
    /// </summary>
    /// <returns>
    /// A Address object with all the attributes available in that tag
    /// </returns>
    public partial class Address : Tag<Address>
    {
    
    /// <summary>
    /// Generate an &lt;address&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Address(bool fluid, object content = null) : base(fluid, "address", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;address&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Address object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Address(bool fluid, params object[] content) : base(fluid, "address", null, content)
    {
    }
    private Address(Address original, CloneChanges changes) : base(original, changes) { }
    internal override Address CwC(CloneChanges changes) => new Address(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;b&gt; tag
    /// </summary>
    /// <returns>
    /// A B object with all the attributes available in that tag
    /// </returns>
    public partial class B : Tag<B>
    {
    
    /// <summary>
    /// Generate an &lt;b&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal B(bool fluid, object content = null) : base(fluid, "b", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;b&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A B object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal B(bool fluid, params object[] content) : base(fluid, "b", null, content)
    {
    }
    private B(B original, CloneChanges changes) : base(original, changes) { }
    internal override B CwC(CloneChanges changes) => new B(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;bdi&gt; tag
    /// </summary>
    /// <returns>
    /// A Bdi object with all the attributes available in that tag
    /// </returns>
    public partial class Bdi : Tag<Bdi>
    {
    
    /// <summary>
    /// Generate an &lt;bdi&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Bdi(bool fluid, object content = null) : base(fluid, "bdi", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;bdi&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Bdi object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Bdi(bool fluid, params object[] content) : base(fluid, "bdi", null, content)
    {
    }
    private Bdi(Bdi original, CloneChanges changes) : base(original, changes) { }
    internal override Bdi CwC(CloneChanges changes) => new Bdi(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;bdo&gt; tag
    /// </summary>
    /// <returns>
    /// A Bdo object with all the attributes available in that tag
    /// </returns>
    public partial class Bdo : Tag<Bdo>
    {
    
    /// <summary>
    /// Generate an &lt;bdo&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Bdo(bool fluid, object content = null) : base(fluid, "bdo", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;bdo&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Bdo object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Bdo(bool fluid, params object[] content) : base(fluid, "bdo", null, content)
    {
    }
    private Bdo(Bdo original, CloneChanges changes) : base(original, changes) { }
    internal override Bdo CwC(CloneChanges changes) => new Bdo(this, changes);
    
    /// <summary>
    /// Set the dir attribute on the &lt;bdo&gt; tag 
    /// </summary>
    /// <param name="value">what should be in dir='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Bdo object to enable fluid command chaining</returns>
        public Bdo Dir(string value) => this.Attr("dir", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;blockquote&gt; tag
    /// </summary>
    /// <returns>
    /// A Blockquote object with all the attributes available in that tag
    /// </returns>
    public partial class Blockquote : Tag<Blockquote>
    {
    
    /// <summary>
    /// Generate an &lt;blockquote&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Blockquote(bool fluid, object content = null) : base(fluid, "blockquote", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;blockquote&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Blockquote object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Blockquote(bool fluid, params object[] content) : base(fluid, "blockquote", null, content)
    {
    }
    private Blockquote(Blockquote original, CloneChanges changes) : base(original, changes) { }
    internal override Blockquote CwC(CloneChanges changes) => new Blockquote(this, changes);
    
    /// <summary>
    /// Set the cite attribute on the &lt;blockquote&gt; tag 
    /// </summary>
    /// <param name="value">what should be in cite='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Blockquote object to enable fluid command chaining</returns>
        public Blockquote Cite(string value) => this.Attr("cite", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;cite&gt; tag
    /// </summary>
    /// <returns>
    /// A Cite object with all the attributes available in that tag
    /// </returns>
    public partial class Cite : Tag<Cite>
    {
    
    /// <summary>
    /// Generate an &lt;cite&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Cite(bool fluid, object content = null) : base(fluid, "cite", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;cite&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Cite object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Cite(bool fluid, params object[] content) : base(fluid, "cite", null, content)
    {
    }
    private Cite(Cite original, CloneChanges changes) : base(original, changes) { }
    internal override Cite CwC(CloneChanges changes) => new Cite(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;code&gt; tag
    /// </summary>
    /// <returns>
    /// A Code object with all the attributes available in that tag
    /// </returns>
    public partial class Code : Tag<Code>
    {
    
    /// <summary>
    /// Generate an &lt;code&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Code(bool fluid, object content = null) : base(fluid, "code", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;code&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Code object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Code(bool fluid, params object[] content) : base(fluid, "code", null, content)
    {
    }
    private Code(Code original, CloneChanges changes) : base(original, changes) { }
    internal override Code CwC(CloneChanges changes) => new Code(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;del&gt; tag
    /// </summary>
    /// <returns>
    /// A Del object with all the attributes available in that tag
    /// </returns>
    public partial class Del : Tag<Del>
    {
    
    /// <summary>
    /// Generate an &lt;del&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Del(bool fluid, object content = null) : base(fluid, "del", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;del&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Del object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Del(bool fluid, params object[] content) : base(fluid, "del", null, content)
    {
    }
    private Del(Del original, CloneChanges changes) : base(original, changes) { }
    internal override Del CwC(CloneChanges changes) => new Del(this, changes);
    
    /// <summary>
    /// Set the cite attribute on the &lt;del&gt; tag 
    /// </summary>
    /// <param name="value">what should be in cite='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Del object to enable fluid command chaining</returns>
        public Del Cite(string value) => this.Attr("cite", value);




    /// <summary>
    /// Set the datetime attribute on the &lt;del&gt; tag 
    /// </summary>
    /// <param name="value">what should be in datetime='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Del object to enable fluid command chaining</returns>
        public Del Datetime(string value) => this.Attr("datetime", value);


    /// <summary>
    /// Set the datetime attribute on the &lt;del&gt; tag 
    /// </summary>
    /// <param name="value">what should be in datetime='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Del object to enable fluid command chaining</returns>
        public Del Datetime(DateTime value) => this.Attr("datetime", value);


    }

    /// <summary>
    /// Generate a standard HTML5 &lt;dfn&gt; tag
    /// </summary>
    /// <returns>
    /// A Dfn object with all the attributes available in that tag
    /// </returns>
    public partial class Dfn : Tag<Dfn>
    {
    
    /// <summary>
    /// Generate an &lt;dfn&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Dfn(bool fluid, object content = null) : base(fluid, "dfn", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;dfn&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Dfn object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Dfn(bool fluid, params object[] content) : base(fluid, "dfn", null, content)
    {
    }
    private Dfn(Dfn original, CloneChanges changes) : base(original, changes) { }
    internal override Dfn CwC(CloneChanges changes) => new Dfn(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;em&gt; tag
    /// </summary>
    /// <returns>
    /// A Em object with all the attributes available in that tag
    /// </returns>
    public partial class Em : Tag<Em>
    {
    
    /// <summary>
    /// Generate an &lt;em&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Em(bool fluid, object content = null) : base(fluid, "em", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;em&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Em object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Em(bool fluid, params object[] content) : base(fluid, "em", null, content)
    {
    }
    private Em(Em original, CloneChanges changes) : base(original, changes) { }
    internal override Em CwC(CloneChanges changes) => new Em(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;figcaption&gt; tag
    /// </summary>
    /// <returns>
    /// A Figcaption object with all the attributes available in that tag
    /// </returns>
    public partial class Figcaption : Tag<Figcaption>
    {
    
    /// <summary>
    /// Generate an &lt;figcaption&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Figcaption(bool fluid, object content = null) : base(fluid, "figcaption", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;figcaption&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Figcaption object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Figcaption(bool fluid, params object[] content) : base(fluid, "figcaption", null, content)
    {
    }
    private Figcaption(Figcaption original, CloneChanges changes) : base(original, changes) { }
    internal override Figcaption CwC(CloneChanges changes) => new Figcaption(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;figure&gt; tag
    /// </summary>
    /// <returns>
    /// A Figure object with all the attributes available in that tag
    /// </returns>
    public partial class Figure : Tag<Figure>
    {
    
    /// <summary>
    /// Generate an &lt;figure&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Figure(bool fluid, object content = null) : base(fluid, "figure", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;figure&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Figure object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Figure(bool fluid, params object[] content) : base(fluid, "figure", null, content)
    {
    }
    private Figure(Figure original, CloneChanges changes) : base(original, changes) { }
    internal override Figure CwC(CloneChanges changes) => new Figure(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;i&gt; tag
    /// </summary>
    /// <returns>
    /// A I object with all the attributes available in that tag
    /// </returns>
    public partial class I : Tag<I>
    {
    
    /// <summary>
    /// Generate an &lt;i&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal I(bool fluid, object content = null) : base(fluid, "i", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;i&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A I object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal I(bool fluid, params object[] content) : base(fluid, "i", null, content)
    {
    }
    private I(I original, CloneChanges changes) : base(original, changes) { }
    internal override I CwC(CloneChanges changes) => new I(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;ins&gt; tag
    /// </summary>
    /// <returns>
    /// A Ins object with all the attributes available in that tag
    /// </returns>
    public partial class Ins : Tag<Ins>
    {
    
    /// <summary>
    /// Generate an &lt;ins&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Ins(bool fluid, object content = null) : base(fluid, "ins", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;ins&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Ins object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Ins(bool fluid, params object[] content) : base(fluid, "ins", null, content)
    {
    }
    private Ins(Ins original, CloneChanges changes) : base(original, changes) { }
    internal override Ins CwC(CloneChanges changes) => new Ins(this, changes);
    
    /// <summary>
    /// Set the cite attribute on the &lt;ins&gt; tag 
    /// </summary>
    /// <param name="value">what should be in cite='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Ins object to enable fluid command chaining</returns>
        public Ins Cite(string value) => this.Attr("cite", value);




    /// <summary>
    /// Set the datetime attribute on the &lt;ins&gt; tag 
    /// </summary>
    /// <param name="value">what should be in datetime='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Ins object to enable fluid command chaining</returns>
        public Ins Datetime(string value) => this.Attr("datetime", value);


    /// <summary>
    /// Set the datetime attribute on the &lt;ins&gt; tag 
    /// </summary>
    /// <param name="value">what should be in datetime='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Ins object to enable fluid command chaining</returns>
        public Ins Datetime(DateTime value) => this.Attr("datetime", value);


    }

    /// <summary>
    /// Generate a standard HTML5 &lt;kbd&gt; tag
    /// </summary>
    /// <returns>
    /// A Kbd object with all the attributes available in that tag
    /// </returns>
    public partial class Kbd : Tag<Kbd>
    {
    
    /// <summary>
    /// Generate an &lt;kbd&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Kbd(bool fluid, object content = null) : base(fluid, "kbd", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;kbd&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Kbd object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Kbd(bool fluid, params object[] content) : base(fluid, "kbd", null, content)
    {
    }
    private Kbd(Kbd original, CloneChanges changes) : base(original, changes) { }
    internal override Kbd CwC(CloneChanges changes) => new Kbd(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;mark&gt; tag
    /// </summary>
    /// <returns>
    /// A Mark object with all the attributes available in that tag
    /// </returns>
    public partial class Mark : Tag<Mark>
    {
    
    /// <summary>
    /// Generate an &lt;mark&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Mark(bool fluid, object content = null) : base(fluid, "mark", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;mark&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Mark object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Mark(bool fluid, params object[] content) : base(fluid, "mark", null, content)
    {
    }
    private Mark(Mark original, CloneChanges changes) : base(original, changes) { }
    internal override Mark CwC(CloneChanges changes) => new Mark(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;meter&gt; tag
    /// </summary>
    /// <returns>
    /// A Meter object with all the attributes available in that tag
    /// </returns>
    public partial class Meter : Tag<Meter>
    {
    
    /// <summary>
    /// Generate an &lt;meter&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Meter(bool fluid, object content = null) : base(fluid, "meter", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;meter&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Meter object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Meter(bool fluid, params object[] content) : base(fluid, "meter", null, content)
    {
    }
    private Meter(Meter original, CloneChanges changes) : base(original, changes) { }
    internal override Meter CwC(CloneChanges changes) => new Meter(this, changes);
    
    /// <summary>
    /// Set the form attribute on the &lt;meter&gt; tag 
    /// </summary>
    /// <param name="value">what should be in form='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Meter object to enable fluid command chaining</returns>
        public Meter Form(string value) => this.Attr("form", value);




    /// <summary>
    /// Set the high attribute on the &lt;meter&gt; tag 
    /// </summary>
    /// <param name="value">what should be in high='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Meter object to enable fluid command chaining</returns>
        public Meter High(string value) => this.Attr("high", value);




    /// <summary>
    /// Set the low attribute on the &lt;meter&gt; tag 
    /// </summary>
    /// <param name="value">what should be in low='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Meter object to enable fluid command chaining</returns>
        public Meter Low(string value) => this.Attr("low", value);




    /// <summary>
    /// Set the max attribute on the &lt;meter&gt; tag 
    /// </summary>
    /// <param name="value">what should be in max='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Meter object to enable fluid command chaining</returns>
        public Meter Max(string value) => this.Attr("max", value);




    /// <summary>
    /// Set the min attribute on the &lt;meter&gt; tag 
    /// </summary>
    /// <param name="value">what should be in min='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Meter object to enable fluid command chaining</returns>
        public Meter Min(string value) => this.Attr("min", value);




    /// <summary>
    /// Set the optimum attribute on the &lt;meter&gt; tag 
    /// </summary>
    /// <param name="value">what should be in optimum='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Meter object to enable fluid command chaining</returns>
        public Meter Optimum(string value) => this.Attr("optimum", value);




    /// <summary>
    /// Set the value attribute on the &lt;meter&gt; tag 
    /// </summary>
    /// <param name="value">what should be in value='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Meter object to enable fluid command chaining</returns>
        public Meter Value(string value) => this.Attr("value", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;pre&gt; tag
    /// </summary>
    /// <returns>
    /// A Pre object with all the attributes available in that tag
    /// </returns>
    public partial class Pre : Tag<Pre>
    {
    
    /// <summary>
    /// Generate an &lt;pre&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Pre(bool fluid, object content = null) : base(fluid, "pre", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;pre&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Pre object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Pre(bool fluid, params object[] content) : base(fluid, "pre", null, content)
    {
    }
    private Pre(Pre original, CloneChanges changes) : base(original, changes) { }
    internal override Pre CwC(CloneChanges changes) => new Pre(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;progress&gt; tag
    /// </summary>
    /// <returns>
    /// A Progress object with all the attributes available in that tag
    /// </returns>
    public partial class Progress : Tag<Progress>
    {
    
    /// <summary>
    /// Generate an &lt;progress&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Progress(bool fluid, object content = null) : base(fluid, "progress", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;progress&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Progress object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Progress(bool fluid, params object[] content) : base(fluid, "progress", null, content)
    {
    }
    private Progress(Progress original, CloneChanges changes) : base(original, changes) { }
    internal override Progress CwC(CloneChanges changes) => new Progress(this, changes);
    
    /// <summary>
    /// Set the max attribute on the &lt;progress&gt; tag 
    /// </summary>
    /// <param name="value">what should be in max='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Progress object to enable fluid command chaining</returns>
        public Progress Max(string value) => this.Attr("max", value);




    /// <summary>
    /// Set the value attribute on the &lt;progress&gt; tag 
    /// </summary>
    /// <param name="value">what should be in value='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Progress object to enable fluid command chaining</returns>
        public Progress Value(string value) => this.Attr("value", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;q&gt; tag
    /// </summary>
    /// <returns>
    /// A Q object with all the attributes available in that tag
    /// </returns>
    public partial class Q : Tag<Q>
    {
    
    /// <summary>
    /// Generate an &lt;q&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Q(bool fluid, object content = null) : base(fluid, "q", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;q&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Q object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Q(bool fluid, params object[] content) : base(fluid, "q", null, content)
    {
    }
    private Q(Q original, CloneChanges changes) : base(original, changes) { }
    internal override Q CwC(CloneChanges changes) => new Q(this, changes);
    
    /// <summary>
    /// Set the cite attribute on the &lt;q&gt; tag 
    /// </summary>
    /// <param name="value">what should be in cite='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Q object to enable fluid command chaining</returns>
        public Q Cite(string value) => this.Attr("cite", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;rp&gt; tag
    /// </summary>
    /// <returns>
    /// A Rp object with all the attributes available in that tag
    /// </returns>
    public partial class Rp : Tag<Rp>
    {
    
    /// <summary>
    /// Generate an &lt;rp&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Rp(bool fluid, object content = null) : base(fluid, "rp", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;rp&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Rp object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Rp(bool fluid, params object[] content) : base(fluid, "rp", null, content)
    {
    }
    private Rp(Rp original, CloneChanges changes) : base(original, changes) { }
    internal override Rp CwC(CloneChanges changes) => new Rp(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;rt&gt; tag
    /// </summary>
    /// <returns>
    /// A Rt object with all the attributes available in that tag
    /// </returns>
    public partial class Rt : Tag<Rt>
    {
    
    /// <summary>
    /// Generate an &lt;rt&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Rt(bool fluid, object content = null) : base(fluid, "rt", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;rt&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Rt object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Rt(bool fluid, params object[] content) : base(fluid, "rt", null, content)
    {
    }
    private Rt(Rt original, CloneChanges changes) : base(original, changes) { }
    internal override Rt CwC(CloneChanges changes) => new Rt(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;ruby&gt; tag
    /// </summary>
    /// <returns>
    /// A Ruby object with all the attributes available in that tag
    /// </returns>
    public partial class Ruby : Tag<Ruby>
    {
    
    /// <summary>
    /// Generate an &lt;ruby&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Ruby(bool fluid, object content = null) : base(fluid, "ruby", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;ruby&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Ruby object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Ruby(bool fluid, params object[] content) : base(fluid, "ruby", null, content)
    {
    }
    private Ruby(Ruby original, CloneChanges changes) : base(original, changes) { }
    internal override Ruby CwC(CloneChanges changes) => new Ruby(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;s&gt; tag
    /// </summary>
    /// <returns>
    /// A S object with all the attributes available in that tag
    /// </returns>
    public partial class S : Tag<S>
    {
    
    /// <summary>
    /// Generate an &lt;s&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal S(bool fluid, object content = null) : base(fluid, "s", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;s&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A S object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal S(bool fluid, params object[] content) : base(fluid, "s", null, content)
    {
    }
    private S(S original, CloneChanges changes) : base(original, changes) { }
    internal override S CwC(CloneChanges changes) => new S(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;samp&gt; tag
    /// </summary>
    /// <returns>
    /// A Samp object with all the attributes available in that tag
    /// </returns>
    public partial class Samp : Tag<Samp>
    {
    
    /// <summary>
    /// Generate an &lt;samp&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Samp(bool fluid, object content = null) : base(fluid, "samp", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;samp&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Samp object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Samp(bool fluid, params object[] content) : base(fluid, "samp", null, content)
    {
    }
    private Samp(Samp original, CloneChanges changes) : base(original, changes) { }
    internal override Samp CwC(CloneChanges changes) => new Samp(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;small&gt; tag
    /// </summary>
    /// <returns>
    /// A Small object with all the attributes available in that tag
    /// </returns>
    public partial class Small : Tag<Small>
    {
    
    /// <summary>
    /// Generate an &lt;small&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Small(bool fluid, object content = null) : base(fluid, "small", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;small&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Small object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Small(bool fluid, params object[] content) : base(fluid, "small", null, content)
    {
    }
    private Small(Small original, CloneChanges changes) : base(original, changes) { }
    internal override Small CwC(CloneChanges changes) => new Small(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;strong&gt; tag
    /// </summary>
    /// <returns>
    /// A Strong object with all the attributes available in that tag
    /// </returns>
    public partial class Strong : Tag<Strong>
    {
    
    /// <summary>
    /// Generate an &lt;strong&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Strong(bool fluid, object content = null) : base(fluid, "strong", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;strong&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Strong object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Strong(bool fluid, params object[] content) : base(fluid, "strong", null, content)
    {
    }
    private Strong(Strong original, CloneChanges changes) : base(original, changes) { }
    internal override Strong CwC(CloneChanges changes) => new Strong(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;sub&gt; tag
    /// </summary>
    /// <returns>
    /// A Sub object with all the attributes available in that tag
    /// </returns>
    public partial class Sub : Tag<Sub>
    {
    
    /// <summary>
    /// Generate an &lt;sub&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Sub(bool fluid, object content = null) : base(fluid, "sub", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;sub&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Sub object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Sub(bool fluid, params object[] content) : base(fluid, "sub", null, content)
    {
    }
    private Sub(Sub original, CloneChanges changes) : base(original, changes) { }
    internal override Sub CwC(CloneChanges changes) => new Sub(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;sup&gt; tag
    /// </summary>
    /// <returns>
    /// A Sup object with all the attributes available in that tag
    /// </returns>
    public partial class Sup : Tag<Sup>
    {
    
    /// <summary>
    /// Generate an &lt;sup&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Sup(bool fluid, object content = null) : base(fluid, "sup", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;sup&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Sup object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Sup(bool fluid, params object[] content) : base(fluid, "sup", null, content)
    {
    }
    private Sup(Sup original, CloneChanges changes) : base(original, changes) { }
    internal override Sup CwC(CloneChanges changes) => new Sup(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;template&gt; tag
    /// </summary>
    /// <returns>
    /// A Template object with all the attributes available in that tag
    /// </returns>
    public partial class Template : Tag<Template>
    {
    
    /// <summary>
    /// Generate an &lt;template&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Template(bool fluid, object content = null) : base(fluid, "template", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;template&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Template object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Template(bool fluid, params object[] content) : base(fluid, "template", null, content)
    {
    }
    private Template(Template original, CloneChanges changes) : base(original, changes) { }
    internal override Template CwC(CloneChanges changes) => new Template(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;time&gt; tag
    /// </summary>
    /// <returns>
    /// A Time object with all the attributes available in that tag
    /// </returns>
    public partial class Time : Tag<Time>
    {
    
    /// <summary>
    /// Generate an &lt;time&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Time(bool fluid, object content = null) : base(fluid, "time", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;time&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Time object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Time(bool fluid, params object[] content) : base(fluid, "time", null, content)
    {
    }
    private Time(Time original, CloneChanges changes) : base(original, changes) { }
    internal override Time CwC(CloneChanges changes) => new Time(this, changes);
    
    /// <summary>
    /// Set the datetime attribute on the &lt;time&gt; tag 
    /// </summary>
    /// <param name="value">what should be in datetime='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Time object to enable fluid command chaining</returns>
        public Time Datetime(string value) => this.Attr("datetime", value);


    /// <summary>
    /// Set the datetime attribute on the &lt;time&gt; tag 
    /// </summary>
    /// <param name="value">what should be in datetime='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Time object to enable fluid command chaining</returns>
        public Time Datetime(DateTime value) => this.Attr("datetime", value);


    }

    /// <summary>
    /// Generate a standard HTML5 &lt;u&gt; tag
    /// </summary>
    /// <returns>
    /// A U object with all the attributes available in that tag
    /// </returns>
    public partial class U : Tag<U>
    {
    
    /// <summary>
    /// Generate an &lt;u&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal U(bool fluid, object content = null) : base(fluid, "u", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;u&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A U object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal U(bool fluid, params object[] content) : base(fluid, "u", null, content)
    {
    }
    private U(U original, CloneChanges changes) : base(original, changes) { }
    internal override U CwC(CloneChanges changes) => new U(this, changes);
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;var&gt; tag
    /// </summary>
    /// <returns>
    /// A Var object with all the attributes available in that tag
    /// </returns>
    public partial class Var : Tag<Var>
    {
    
    /// <summary>
    /// Generate an &lt;var&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    internal Var(bool fluid, object content = null) : base(fluid, "var", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;var&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Var object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Var(bool fluid, params object[] content) : base(fluid, "var", null, content)
    {
    }
    private Var(Var original, CloneChanges changes) : base(original, changes) { }
    internal override Var CwC(CloneChanges changes) => new Var(this, changes);
    
    }
}
