using System;
using ToSic.Razor.Blade;
using ToSic.Razor.Markup;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created 04.12.2019 11:53
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
    internal Abbr(object content = null) : base("abbr", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;abbr&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Abbr object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Abbr(params object[] content) : base("abbr", null, content)
    {
    }
    
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
    internal Address(object content = null) : base("address", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;address&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Address object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Address(params object[] content) : base("address", null, content)
    {
    }
    
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
    internal B(object content = null) : base("b", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;b&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A B object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal B(params object[] content) : base("b", null, content)
    {
    }
    
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
    internal Bdi(object content = null) : base("bdi", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;bdi&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Bdi object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Bdi(params object[] content) : base("bdi", null, content)
    {
    }
    
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
    internal Bdo(object content = null) : base("bdo", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;bdo&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Bdo object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Bdo(params object[] content) : base("bdo", null, content)
    {
    }
    
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
    internal Blockquote(object content = null) : base("blockquote", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;blockquote&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Blockquote object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Blockquote(params object[] content) : base("blockquote", null, content)
    {
    }
    
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
    internal Cite(object content = null) : base("cite", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;cite&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Cite object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Cite(params object[] content) : base("cite", null, content)
    {
    }
    
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
    internal Code(object content = null) : base("code", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;code&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Code object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Code(params object[] content) : base("code", null, content)
    {
    }
    
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
    internal Del(object content = null) : base("del", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;del&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Del object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Del(params object[] content) : base("del", null, content)
    {
    }
    
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
    internal Dfn(object content = null) : base("dfn", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;dfn&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Dfn object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Dfn(params object[] content) : base("dfn", null, content)
    {
    }
    
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
    internal Em(object content = null) : base("em", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;em&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Em object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Em(params object[] content) : base("em", null, content)
    {
    }
    
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
    internal Figcaption(object content = null) : base("figcaption", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;figcaption&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Figcaption object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Figcaption(params object[] content) : base("figcaption", null, content)
    {
    }
    
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
    internal Figure(object content = null) : base("figure", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;figure&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Figure object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Figure(params object[] content) : base("figure", null, content)
    {
    }
    
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
    internal I(object content = null) : base("i", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;i&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A I object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal I(params object[] content) : base("i", null, content)
    {
    }
    
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
    internal Ins(object content = null) : base("ins", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;ins&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Ins object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Ins(params object[] content) : base("ins", null, content)
    {
    }
    
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
    internal Kbd(object content = null) : base("kbd", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;kbd&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Kbd object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Kbd(params object[] content) : base("kbd", null, content)
    {
    }
    
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
    internal Mark(object content = null) : base("mark", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;mark&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Mark object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Mark(params object[] content) : base("mark", null, content)
    {
    }
    
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
    internal Meter(object content = null) : base("meter", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;meter&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Meter object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Meter(params object[] content) : base("meter", null, content)
    {
    }
    
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
    internal Pre(object content = null) : base("pre", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;pre&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Pre object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Pre(params object[] content) : base("pre", null, content)
    {
    }
    
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
    internal Progress(object content = null) : base("progress", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;progress&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Progress object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Progress(params object[] content) : base("progress", null, content)
    {
    }
    
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
    internal Q(object content = null) : base("q", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;q&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Q object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Q(params object[] content) : base("q", null, content)
    {
    }
    
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
    internal Rp(object content = null) : base("rp", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;rp&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Rp object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Rp(params object[] content) : base("rp", null, content)
    {
    }
    
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
    internal Rt(object content = null) : base("rt", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;rt&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Rt object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Rt(params object[] content) : base("rt", null, content)
    {
    }
    
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
    internal Ruby(object content = null) : base("ruby", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;ruby&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Ruby object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Ruby(params object[] content) : base("ruby", null, content)
    {
    }
    
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
    internal S(object content = null) : base("s", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;s&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A S object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal S(params object[] content) : base("s", null, content)
    {
    }
    
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
    internal Samp(object content = null) : base("samp", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;samp&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Samp object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Samp(params object[] content) : base("samp", null, content)
    {
    }
    
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
    internal Small(object content = null) : base("small", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;small&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Small object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Small(params object[] content) : base("small", null, content)
    {
    }
    
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
    internal Strong(object content = null) : base("strong", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;strong&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Strong object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Strong(params object[] content) : base("strong", null, content)
    {
    }
    
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
    internal Sub(object content = null) : base("sub", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;sub&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Sub object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Sub(params object[] content) : base("sub", null, content)
    {
    }
    
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
    internal Sup(object content = null) : base("sup", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;sup&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Sup object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Sup(params object[] content) : base("sup", null, content)
    {
    }
    
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
    internal Template(object content = null) : base("template", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;template&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Template object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Template(params object[] content) : base("template", null, content)
    {
    }
    
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
    internal Time(object content = null) : base("time", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;time&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Time object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Time(params object[] content) : base("time", null, content)
    {
    }
    
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
    internal U(object content = null) : base("u", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;u&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A U object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal U(params object[] content) : base("u", null, content)
    {
    }
    
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
    internal Var(object content = null) : base("var", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;var&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Var object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    internal Var(params object[] content) : base("var", null, content)
    {
    }
    
    }
}
