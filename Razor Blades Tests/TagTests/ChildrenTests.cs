﻿using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Markup;

// ReSharper disable MustUseReturnValue

namespace Razor_Blades_Tests.TagTests
{
    [TestClass]
    public class ChildrenTests
    {
        [TestMethod]
        public void TextChildren()
        {
            var tag = new Div();
            tag.Add("razor");
            Assert.AreEqual("<div>razor</div>", tag.ToString());
            tag.Add("blade");
            Assert.AreEqual("<div>razorblade</div>", tag.ToString());
        }

        [TestMethod]
        public void TagChildren()
        {
            var tag = new Div();
            tag.Add(new Span());
            Assert.AreEqual("<div><span></span></div>", tag.ToString());
            tag.Add(new Div());
            Assert.AreEqual("<div><span></span><div></div></div>", tag.ToString());
        }

        [TestMethod]
        public void TagSubchildren()
        {
            var tag = new Div();
            tag.Add(new Span(new B(), new I()));
            Assert.AreEqual("<div><span><b></b><i></i></span></div>", tag.ToString());
        }

        [TestMethod]
        public void MixedChildren()
        {
            var tag = new Div();
            tag.Add(new Span());
            Assert.AreEqual("<div><span></span></div>", tag.ToString());
            tag.Add("razor-blade");
            Assert.AreEqual("<div><span></span>razor-blade</div>", tag.ToString());
        }

        [TestMethod]
        public void Wrap()
        {
            var tag = new Div();
            tag.Add(new Span());
            Assert.AreEqual("<div><span></span></div>", tag.ToString());
            tag.Wrap("razor-blade");
            Assert.AreEqual("<div>razor-blade</div>", tag.ToString());
        }

        [TestMethod]
        public void SetContent()
        {
            var tag = new Div();
            tag.Add(new Span());
            Assert.AreEqual("<div><span></span></div>", tag.ToString());
            tag.TagContents = "razor-blade";
            Assert.AreEqual("<div>razor-blade</div>", tag.ToString());
        }

        [TestMethod]
        public void ConstructorContent()
        {
            var tag = new Div(new Span());
            Assert.AreEqual("<div><span></span></div>", tag.ToString());

            tag.TagContents = "razor-blade";
            Assert.AreEqual("<div>razor-blade</div>", tag.ToString());

            tag = new Div(new Span(), new Span(), "hello");
        }


        [TestMethod]
        public void SubChildren()
        {
            var tag = new Div();
            var span = new Span().Add(new Div());
            tag.Add(span);
            Assert.AreEqual("<div><span><div></div></span></div>", tag.ToString());
            tag.Add(span);
            Assert.AreEqual("<div><span><div></div></span><span><div></div></span></div>", tag.ToString());
        }

        [TestMethod]
        public void SubChildrenAndText()
        {
            var tag = new Div();
            var span = new Span().Add(new Div());
            tag.Add(span);
            Assert.AreEqual("<div><span><div></div></span></div>", tag.ToString());
            tag.Add("razor-blade");
            Assert.AreEqual("<div><span><div></div></span>razor-blade</div>", tag.ToString());
        }

        [TestMethod]
        public void SubChildrenPreserveOptions()
        {
            var tag = new Div().Id("27");
            tag.TagOptions = new TagOptions(new AttributeOptions {Quote = "\""});
            var span = new Span().Id("spn").Add(new Div());
            tag.Add(span);
            Assert.AreEqual("<div id=\"27\"><span id=\"spn\"><div></div></span></div>", tag.ToString());
        }

        [TestMethod]
        public void SubChildrenPreserveOptionsUnlessOverridden()
        {
            var tag = new Div().Id("27");
            tag.TagOptions = new TagOptions(new AttributeOptions { Quote = "\"" });
            var span = new Span().Id("spn").Add(new Div());
            span.TagOptions = new TagOptions();
            tag.Add(span);
            Assert.AreEqual("<div id=\"27\"><span id='spn'><div></div></span></div>", tag.ToString());
        }

    }
}
