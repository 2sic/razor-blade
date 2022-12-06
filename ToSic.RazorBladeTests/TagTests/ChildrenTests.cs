using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Html5;
using ToSic.Razor.Markup;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

// ReSharper disable MustUseReturnValue

namespace ToSic.RazorBladeTests.TagTests
{
    [TestClass]
    public class ChildrenTests
    {
        [TestMethod]
        public void TextChildren()
        {
            var tag = new Div();
            tag = tag.Add("razor");
            AreEqual("<div>razor</div>", tag.ToString());
            tag = tag.Add("blade");
            AreEqual("<div>razorblade</div>", tag.ToString());
        }

        [TestMethod]
        public void TagChildren()
        {
            var tag = new Div();
            tag = tag.Add(new Span());
            AreEqual("<div><span></span></div>", tag.ToString());
            tag = tag.Add(new Div());
            AreEqual("<div><span></span><div></div></div>", tag.ToString());
        }

        [TestMethod]
        public void TagSubchildren()
        {
            var tag = new Div();
            tag = tag.Add(new Span(new B(), new I()));
            AreEqual("<div><span><b></b><i></i></span></div>", tag.ToString());
        }

        [TestMethod]
        public void MixedChildrenFluid()
        {
            var tag = new Div();
            var withSpan = tag.Add(new Span());
            AreEqual("<div><span></span></div>", withSpan.ToString());
            var withText = withSpan.Add("razor-blade");
            AreEqual("<div><span></span>razor-blade</div>", withText.ToString());
            AreNotEqual(tag, withText);
            AreNotEqual(tag, withSpan);
            AreNotEqual(withText, withSpan);
        }

        [TestMethod]
        public void MixedChildrenNonFluidButAsIf()
        {
            var tag = new Div() {TagIsFluid = false};
            var withSpan = tag.Add(new Span());
            AreEqual("<div><span></span></div>", withSpan.ToString());
            var withText = withSpan.Add("razor-blade");
            AreEqual("<div><span></span>razor-blade</div>", withText.ToString());
            AreEqual(tag, withSpan);
            AreEqual(tag, withText);
        }

        [TestMethod]
        public void MixedChildrenNonFluid()
        {
            var tag = new Div() {TagIsFluid = false};
            var withSpan = tag.Add(new Span());
            AreEqual("<div><span></span></div>", withSpan.ToString());
            var withText = withSpan.Add("razor-blade");
            AreEqual("<div><span></span>razor-blade</div>", withText.ToString());
            AreEqual(tag, withSpan);
            AreEqual(tag, withText);
        }

        [TestMethod]
        public void Wrap()
        {
            var tag = new Div();
            tag = tag.Add(new Span());
            AreEqual("<div><span></span></div>", tag.ToString());
            tag = tag.Wrap("razor-blade");
            AreEqual("<div>razor-blade</div>", tag.ToString());
        }

        [TestMethod]
        public void SetContent()
        {
            var tag = new Div() {TagIsFluid = false};
            tag.Add(new Span());
            AreEqual("<div><span></span></div>", tag.ToString());
            tag.TagContents = "razor-blade";
            AreEqual("<div>razor-blade</div>", tag.ToString());
        }

        [TestMethod]
        public void ConstructorContent()
        {
            var tag = new Div(new Span());
            AreEqual("<div><span></span></div>", tag.ToString());

            tag.TagContents = "razor-blade";
            AreEqual("<div>razor-blade</div>", tag.ToString());

            tag = new(new Span(), new Span(), "hello");
        }


        [TestMethod]
        public void SubChildren()
        {
            var tag = new Div();
            var span = new Span().Add(new Div() { TagIsFluid = false });
            tag = tag.Add(span);
            AreEqual("<div><span><div></div></span></div>", tag.ToString());
            tag = tag.Add(span);
            AreEqual("<div><span><div></div></span><span><div></div></span></div>", tag.ToString());
        }

        [TestMethod]
        public void SubChildrenAndText()
        {
            var tag = new Div() { TagIsFluid = false};
            var span = new Span().Add(new Div());
            tag.Add(span);
            AreEqual("<div><span><div></div></span></div>", tag.ToString());
            tag.Add("razor-blade");
            AreEqual("<div><span><div></div></span>razor-blade</div>", tag.ToString());
        }

        [TestMethod]
        public void SubChildrenPreserveOptions()
        {
            var tag = new Div() { TagIsFluid = false }.Id("27");
            tag = tag.WithOptions(new(attributeOptions: new(quote: "\"")));
            var span = new Span().Id("spn").Add(new Div());
            tag.Add(span);
            AreEqual("<div id=\"27\"><span id=\"spn\"><div></div></span></div>", tag.ToString());
        }

        [TestMethod]
        public void SubChildrenPreserveOptionsUnlessOverridden()
        {
            var tag = new Div().Id("27");
            tag = tag.WithOptions(new(attributeOptions: new(quote: "\"")));
            var span = new Span() { TagIsFluid = false }.Id("spn").Add(new Div());
            span = span.WithOptions(TagOptions.DefaultOptions);
            tag = tag.Add(span);
            AreEqual("<div id=\"27\"><span id='spn'><div></div></span></div>", tag.ToString());
        }

    }
}
