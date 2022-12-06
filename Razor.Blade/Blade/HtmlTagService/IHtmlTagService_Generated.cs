
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.Razor.Markup;
using ToSic.Razor.Internals.Documentation;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created 06.12.2022 22:24
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


// ReSharper disable once CheckNamespace
namespace ToSic.Razor.Blade
{
    public partial interface IHtmlTagService
    {
        
    /// <summary>
    /// Generate a standard HTML5 &lt;a&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A A object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var a = tagSvc.A();
    /// var a2 = tagSvc.A("hello there");
    /// </code>
    A A(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;abbr&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Abbr object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var abbr = tagSvc.Abbr();
    /// var abbr2 = tagSvc.Abbr("hello there");
    /// </code>
    Abbr Abbr(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;address&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Address object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var address = tagSvc.Address();
    /// var address2 = tagSvc.Address("hello there");
    /// </code>
    Address Address(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;area&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Area object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var area = tagSvc.Area();
    /// var area2 = tagSvc.Area("hello there");
    /// </code>
    Area Area(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;article&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Article object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var article = tagSvc.Article();
    /// var article2 = tagSvc.Article("hello there");
    /// </code>
    Article Article(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;aside&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Aside object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var aside = tagSvc.Aside();
    /// var aside2 = tagSvc.Aside("hello there");
    /// </code>
    Aside Aside(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;audio&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Audio object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var audio = tagSvc.Audio();
    /// var audio2 = tagSvc.Audio("hello there");
    /// </code>
    Audio Audio(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;b&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A B object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var b = tagSvc.B();
    /// var b2 = tagSvc.B("hello there");
    /// </code>
    B B(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;base&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Base object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var base = tagSvc.Base();
    /// </code>
    Base Base(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;bdi&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Bdi object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var bdi = tagSvc.Bdi();
    /// var bdi2 = tagSvc.Bdi("hello there");
    /// </code>
    Bdi Bdi(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;bdo&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Bdo object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var bdo = tagSvc.Bdo();
    /// var bdo2 = tagSvc.Bdo("hello there");
    /// </code>
    Bdo Bdo(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;blockquote&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Blockquote object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var blockquote = tagSvc.Blockquote();
    /// var blockquote2 = tagSvc.Blockquote("hello there");
    /// </code>
    Blockquote Blockquote(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;br&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Br object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var br = tagSvc.Br();
    /// </code>
    Br Br(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;button&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Button object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var button = tagSvc.Button();
    /// var button2 = tagSvc.Button("hello there");
    /// </code>
    Button Button(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;canvas&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Canvas object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var canvas = tagSvc.Canvas();
    /// var canvas2 = tagSvc.Canvas("hello there");
    /// </code>
    Canvas Canvas(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;caption&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Caption object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var caption = tagSvc.Caption();
    /// var caption2 = tagSvc.Caption("hello there");
    /// </code>
    Caption Caption(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;cite&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Cite object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var cite = tagSvc.Cite();
    /// var cite2 = tagSvc.Cite("hello there");
    /// </code>
    Cite Cite(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;code&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Code object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var code = tagSvc.Code();
    /// var code2 = tagSvc.Code("hello there");
    /// </code>
    Code Code(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;col&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Col object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var col = tagSvc.Col();
    /// var col2 = tagSvc.Col("hello there");
    /// </code>
    Col Col(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;colgroup&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Colgroup object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var colgroup = tagSvc.Colgroup();
    /// var colgroup2 = tagSvc.Colgroup("hello there");
    /// </code>
    Colgroup Colgroup(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;data&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Data object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var data = tagSvc.Data();
    /// var data2 = tagSvc.Data("hello there");
    /// </code>
    Data Data(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;datalist&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Datalist object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var datalist = tagSvc.Datalist();
    /// var datalist2 = tagSvc.Datalist("hello there");
    /// </code>
    Datalist Datalist(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;dd&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Dd object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var dd = tagSvc.Dd();
    /// var dd2 = tagSvc.Dd("hello there");
    /// </code>
    Dd Dd(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;del&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Del object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var del = tagSvc.Del();
    /// var del2 = tagSvc.Del("hello there");
    /// </code>
    Del Del(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;details&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Details object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var details = tagSvc.Details();
    /// var details2 = tagSvc.Details("hello there");
    /// </code>
    Details Details(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;dfn&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Dfn object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var dfn = tagSvc.Dfn();
    /// var dfn2 = tagSvc.Dfn("hello there");
    /// </code>
    Dfn Dfn(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;dialog&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Dialog object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var dialog = tagSvc.Dialog();
    /// var dialog2 = tagSvc.Dialog("hello there");
    /// </code>
    Dialog Dialog(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;div&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Div object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var div = tagSvc.Div();
    /// var div2 = tagSvc.Div("hello there");
    /// </code>
    Div Div(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;dl&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Dl object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var dl = tagSvc.Dl();
    /// var dl2 = tagSvc.Dl("hello there");
    /// </code>
    Dl Dl(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;dt&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Dt object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var dt = tagSvc.Dt();
    /// var dt2 = tagSvc.Dt("hello there");
    /// </code>
    Dt Dt(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;em&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Em object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var em = tagSvc.Em();
    /// var em2 = tagSvc.Em("hello there");
    /// </code>
    Em Em(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;embed&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Embed object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var embed = tagSvc.Embed();
    /// var embed2 = tagSvc.Embed("hello there");
    /// </code>
    Embed Embed(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;fieldset&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Fieldset object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var fieldset = tagSvc.Fieldset();
    /// var fieldset2 = tagSvc.Fieldset("hello there");
    /// </code>
    Fieldset Fieldset(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;figcaption&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Figcaption object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var figcaption = tagSvc.Figcaption();
    /// var figcaption2 = tagSvc.Figcaption("hello there");
    /// </code>
    Figcaption Figcaption(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;figure&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Figure object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var figure = tagSvc.Figure();
    /// var figure2 = tagSvc.Figure("hello there");
    /// </code>
    Figure Figure(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;footer&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Footer object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var footer = tagSvc.Footer();
    /// var footer2 = tagSvc.Footer("hello there");
    /// </code>
    Footer Footer(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;form&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Form object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var form = tagSvc.Form();
    /// var form2 = tagSvc.Form("hello there");
    /// </code>
    Form Form(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;h1&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A H1 object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var h1 = tagSvc.H1();
    /// var h12 = tagSvc.H1("hello there");
    /// </code>
    H1 H1(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;h2&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A H2 object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var h2 = tagSvc.H2();
    /// var h22 = tagSvc.H2("hello there");
    /// </code>
    H2 H2(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;h3&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A H3 object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var h3 = tagSvc.H3();
    /// var h32 = tagSvc.H3("hello there");
    /// </code>
    H3 H3(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;h4&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A H4 object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var h4 = tagSvc.H4();
    /// var h42 = tagSvc.H4("hello there");
    /// </code>
    H4 H4(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;h5&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A H5 object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var h5 = tagSvc.H5();
    /// var h52 = tagSvc.H5("hello there");
    /// </code>
    H5 H5(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;h6&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A H6 object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var h6 = tagSvc.H6();
    /// var h62 = tagSvc.H6("hello there");
    /// </code>
    H6 H6(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;head&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Head object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var head = tagSvc.Head();
    /// var head2 = tagSvc.Head("hello there");
    /// </code>
    Head Head(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;header&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Header object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var header = tagSvc.Header();
    /// var header2 = tagSvc.Header("hello there");
    /// </code>
    Header Header(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;hr&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Hr object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var hr = tagSvc.Hr();
    /// </code>
    Hr Hr(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;i&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A I object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var i = tagSvc.I();
    /// var i2 = tagSvc.I("hello there");
    /// </code>
    I I(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;iframe&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Iframe object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var iframe = tagSvc.Iframe();
    /// </code>
    Iframe Iframe(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;img&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Img object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var img = tagSvc.Img();
    /// </code>
    Img Img(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;input&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Input object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var input = tagSvc.Input();
    /// </code>
    Input Input(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;ins&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Ins object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var ins = tagSvc.Ins();
    /// var ins2 = tagSvc.Ins("hello there");
    /// </code>
    Ins Ins(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;kbd&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Kbd object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var kbd = tagSvc.Kbd();
    /// var kbd2 = tagSvc.Kbd("hello there");
    /// </code>
    Kbd Kbd(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;label&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Label object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var label = tagSvc.Label();
    /// var label2 = tagSvc.Label("hello there");
    /// </code>
    Label Label(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;legend&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Legend object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var legend = tagSvc.Legend();
    /// var legend2 = tagSvc.Legend("hello there");
    /// </code>
    Legend Legend(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;li&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Li object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var li = tagSvc.Li();
    /// var li2 = tagSvc.Li("hello there");
    /// </code>
    Li Li(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;link&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Link object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var link = tagSvc.Link();
    /// </code>
    Link Link(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;main&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Main object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var main = tagSvc.Main();
    /// var main2 = tagSvc.Main("hello there");
    /// </code>
    Main Main(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;map&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Map object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var map = tagSvc.Map();
    /// var map2 = tagSvc.Map("hello there");
    /// </code>
    Map Map(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;mark&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Mark object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var mark = tagSvc.Mark();
    /// var mark2 = tagSvc.Mark("hello there");
    /// </code>
    Mark Mark(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;meta&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Meta object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var meta = tagSvc.Meta();
    /// </code>
    Meta Meta(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;meter&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Meter object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var meter = tagSvc.Meter();
    /// var meter2 = tagSvc.Meter("hello there");
    /// </code>
    Meter Meter(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;nav&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Nav object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var nav = tagSvc.Nav();
    /// var nav2 = tagSvc.Nav("hello there");
    /// </code>
    Nav Nav(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;noscript&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Noscript object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var noscript = tagSvc.Noscript();
    /// var noscript2 = tagSvc.Noscript("hello there");
    /// </code>
    Noscript Noscript(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;object&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Object object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var object = tagSvc.Object();
    /// var object2 = tagSvc.Object("hello there");
    /// </code>
    Object Object(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;ol&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Ol object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var ol = tagSvc.Ol();
    /// var ol2 = tagSvc.Ol("hello there");
    /// </code>
    Ol Ol(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;optgroup&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Optgroup object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var optgroup = tagSvc.Optgroup();
    /// var optgroup2 = tagSvc.Optgroup("hello there");
    /// </code>
    Optgroup Optgroup(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;option&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Option object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var option = tagSvc.Option();
    /// var option2 = tagSvc.Option("hello there");
    /// </code>
    Option Option(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;output&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Output object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var output = tagSvc.Output();
    /// var output2 = tagSvc.Output("hello there");
    /// </code>
    Output Output(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;p&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A P object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var p = tagSvc.P();
    /// var p2 = tagSvc.P("hello there");
    /// </code>
    P P(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;param&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Param object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var param = tagSvc.Param();
    /// var param2 = tagSvc.Param("hello there");
    /// </code>
    Param Param(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;picture&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Picture object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var picture = tagSvc.Picture();
    /// var picture2 = tagSvc.Picture("hello there");
    /// </code>
    Picture Picture(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;pre&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Pre object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var pre = tagSvc.Pre();
    /// var pre2 = tagSvc.Pre("hello there");
    /// </code>
    Pre Pre(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;progress&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Progress object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var progress = tagSvc.Progress();
    /// var progress2 = tagSvc.Progress("hello there");
    /// </code>
    Progress Progress(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;q&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Q object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var q = tagSvc.Q();
    /// var q2 = tagSvc.Q("hello there");
    /// </code>
    Q Q(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;rp&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Rp object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var rp = tagSvc.Rp();
    /// var rp2 = tagSvc.Rp("hello there");
    /// </code>
    Rp Rp(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;rt&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Rt object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var rt = tagSvc.Rt();
    /// var rt2 = tagSvc.Rt("hello there");
    /// </code>
    Rt Rt(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;ruby&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Ruby object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var ruby = tagSvc.Ruby();
    /// var ruby2 = tagSvc.Ruby("hello there");
    /// </code>
    Ruby Ruby(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;s&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A S object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var s = tagSvc.S();
    /// var s2 = tagSvc.S("hello there");
    /// </code>
    S S(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;samp&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Samp object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var samp = tagSvc.Samp();
    /// var samp2 = tagSvc.Samp("hello there");
    /// </code>
    Samp Samp(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;script&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Script object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var script = tagSvc.Script();
    /// var script2 = tagSvc.Script("hello there");
    /// </code>
    Script Script(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;section&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Section object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var section = tagSvc.Section();
    /// var section2 = tagSvc.Section("hello there");
    /// </code>
    Section Section(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;select&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Select object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var select = tagSvc.Select();
    /// var select2 = tagSvc.Select("hello there");
    /// </code>
    Select Select(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;small&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Small object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var small = tagSvc.Small();
    /// var small2 = tagSvc.Small("hello there");
    /// </code>
    Small Small(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;source&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Source object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var source = tagSvc.Source();
    /// </code>
    Source Source(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;span&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Span object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var span = tagSvc.Span();
    /// var span2 = tagSvc.Span("hello there");
    /// </code>
    Span Span(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;strong&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Strong object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var strong = tagSvc.Strong();
    /// var strong2 = tagSvc.Strong("hello there");
    /// </code>
    Strong Strong(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;style&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Style object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var style = tagSvc.Style();
    /// var style2 = tagSvc.Style("hello there");
    /// </code>
    Style Style(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;sub&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Sub object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var sub = tagSvc.Sub();
    /// var sub2 = tagSvc.Sub("hello there");
    /// </code>
    Sub Sub(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;summary&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Summary object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var summary = tagSvc.Summary();
    /// var summary2 = tagSvc.Summary("hello there");
    /// </code>
    Summary Summary(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;sup&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Sup object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var sup = tagSvc.Sup();
    /// var sup2 = tagSvc.Sup("hello there");
    /// </code>
    Sup Sup(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;svg&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Svg object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var svg = tagSvc.Svg();
    /// var svg2 = tagSvc.Svg("hello there");
    /// </code>
    Svg Svg(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;table&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Table object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var table = tagSvc.Table();
    /// var table2 = tagSvc.Table("hello there");
    /// </code>
    Table Table(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;tbody&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Tbody object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var tbody = tagSvc.Tbody();
    /// var tbody2 = tagSvc.Tbody("hello there");
    /// </code>
    Tbody Tbody(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;td&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Td object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var td = tagSvc.Td();
    /// var td2 = tagSvc.Td("hello there");
    /// </code>
    Td Td(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;template&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Template object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var template = tagSvc.Template();
    /// var template2 = tagSvc.Template("hello there");
    /// </code>
    Template Template(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;textarea&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Textarea object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var textarea = tagSvc.Textarea();
    /// var textarea2 = tagSvc.Textarea("hello there");
    /// </code>
    Textarea Textarea(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;tfoot&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Tfoot object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var tfoot = tagSvc.Tfoot();
    /// var tfoot2 = tagSvc.Tfoot("hello there");
    /// </code>
    Tfoot Tfoot(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;th&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Th object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var th = tagSvc.Th();
    /// var th2 = tagSvc.Th("hello there");
    /// </code>
    Th Th(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;thead&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Thead object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var thead = tagSvc.Thead();
    /// var thead2 = tagSvc.Thead("hello there");
    /// </code>
    Thead Thead(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;time&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Time object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var time = tagSvc.Time();
    /// var time2 = tagSvc.Time("hello there");
    /// </code>
    Time Time(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;tr&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Tr object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var tr = tagSvc.Tr();
    /// var tr2 = tagSvc.Tr("hello there");
    /// </code>
    Tr Tr(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;track&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Track object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var track = tagSvc.Track();
    /// </code>
    Track Track(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;u&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A U object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var u = tagSvc.U();
    /// var u2 = tagSvc.U("hello there");
    /// </code>
    U U(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;ul&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Ul object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var ul = tagSvc.Ul();
    /// var ul2 = tagSvc.Ul("hello there");
    /// </code>
    Ul Ul(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;var&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Var object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var var = tagSvc.Var();
    /// var var2 = tagSvc.Var("hello there");
    /// </code>
    Var Var(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;video&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Video object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var video = tagSvc.Video();
    /// var video2 = tagSvc.Video("hello there");
    /// </code>
    Video Video(params object[] content);

    /// <summary>
    /// Generate a standard HTML5 &lt;wbr&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Wbr object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var wbr = tagSvc.Wbr();
    /// </code>
    Wbr Wbr(params object[] content);
    }
}
