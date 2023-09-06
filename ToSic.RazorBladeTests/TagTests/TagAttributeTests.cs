using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

// ReSharper disable StringLiteralTypo

namespace ToSic.RazorBladeTests.TagTests
{
    [TestClass]
    public class TagAttributeTests: TagTestBase
    {
        #region Generic Attr calls
        [TestMethod]
        public void TagAttributeBasics()
        {
            Is("<div class='x'>", TestDiv().Attr("class", "x").TagStart);
        }

        [TestMethod]
        public void TagAttributeContainingIHtmlData()
        {
            Is("<div data='love &amp; harmony'>", Tag.Div().Attr("data", Tag.RawHtml("love & harmony") ).TagStart);
        }

        [TestMethod]
        public void TagAttributeContainingPTag()
        {
            Is("<div data='&lt;p&gt;content&lt;/p&gt;'>", Tag.Div().Attr("data", Tag.P("content") ).TagStart);
        }

        [TestMethod]
        public void TagAttributeWithoutValue()
        {
            Is("<div data-fancybox>", TestDiv().Attr("data-fancybox").TagStart);
        }

        [TestMethod]
        public void TagAttributeOnly()
        {
            Is(" name='value' ", Tag.Attr("name", "value"));
        }


        [TestMethod]
        public void TagAttributeMultiple()
        {
            Is("<div class='x' name='value'>", TestDiv()
                .Attr("class", "x")
                .Attr("name", "value")
                .TagStart
            );
        }

         [TestMethod]
        public void TagAttributeAppend()
        {
            Is("<div class='xyz'>", TestDiv()
                .Attr("class", "x", "")
                .Attr("class", "y", "")
                .Attr("class", "z", "")
                .TagStart
            );
        }

        [TestMethod]
        public void TagAttributeSeparator()
        {
            Is("<div class='x,y-z'>", TestDiv()
                .Attr("class", "x", " ")
                .Attr("class", "y", ",")
                .Attr("class", "z", "-")
                .TagStart
            );
        }

        [TestMethod]
        public void TagAttributeReplace()
        {
            Is("<div class='z'>", TestDiv()
                .Attr("class", "x", " ")
                .Attr("class", "y", ",")
                .Attr("class", "z", null)
                .TagStart
            );
        }
        #endregion

        #region Id, Class, Title, Style

        /// <summary>
        /// Get a div, but treat as IHtmlTag to verify that the methods work as such too
        /// </summary>
        /// <returns></returns>
        private IHtmlTag HtmlTagDiv() => TestDiv();

        [TestMethod]
        public void TagIdWithDiv()
        {
            Is("<div id='z'>", TestDiv().Id("z").TagStart);
            Is("<div id='y'>", TestDiv().Id("z").Id("y").TagStart);
            Is("<div id>", TestDiv().Id(null).TagStart);
            Is("<div id>", TestDiv().Id("z").Id(null).TagStart);
            Is("<div id='x'>", TestDiv().Id("z").Id(null).Id("x").TagStart);
        }


        [TestMethod]
        public void TestIdWithHtmlTag()
        {
            Is("<div id='z'>", HtmlTagDiv().Id("z").TagStart);
            Is("<div id='y'>", HtmlTagDiv().Id("z").Id("y").TagStart);
            Is("<div id>", HtmlTagDiv().Id(null).TagStart);
            Is("<div id>", HtmlTagDiv().Id("z").Id(null).TagStart);
            Is("<div id='x'>", HtmlTagDiv().Id("z").Id(null).Id("x").TagStart);
        }

        [TestMethod]
        public void TagClassWithDiv()
        {
            Is("<div class='z'>", TestDiv().Class("z").TagStart);
            Is("<div class='z y'>", TestDiv().Class("z").Class("y").TagStart);
            Is("<div class>", TestDiv().Class(null).TagStart);
            Is("<div class>", TestDiv().Class("z").Class("y").Class(null).TagStart);
            Is("<div class='x'>", TestDiv().Class("z").Class("y").Class(null).Class("x").TagStart);
        }
        [TestMethod]
        public void TagClassWithHtmlTag()
        {
            Is("<div class='z'>", HtmlTagDiv().Class("z").TagStart);
            Is("<div class='z y'>", HtmlTagDiv().Class("z").Class("y").TagStart);
            Is("<div class>", HtmlTagDiv().Class(null).TagStart);
            Is("<div class>", HtmlTagDiv().Class("z").Class("y").Class(null).TagStart);
            Is("<div class='x'>", HtmlTagDiv().Class("z").Class("y").Class(null).Class("x").TagStart);
        }

        [TestMethod]
        public void TagStyleWithDiv()
        {
            Is("<div style='z'>", TestDiv().Style("z").TagStart);
            Is("<div style='z;y'>", TestDiv().Style("z").Style("y").TagStart);
            Is("<div style>", TestDiv().Style("z").Style("y").Style(null).TagStart);
            Is("<div style='x'>", TestDiv().Style("z").Style("y").Style(null).Style("x").TagStart);
        }
        [TestMethod]
        public void TagStyleWithHtmlTag()
        {
            Is("<div style='z'>", HtmlTagDiv().Style("z").TagStart);
            Is("<div style='z;y'>", HtmlTagDiv().Style("z").Style("y").TagStart);
            Is("<div style>", HtmlTagDiv().Style("z").Style("y").Style(null).TagStart);
            Is("<div style='x'>", HtmlTagDiv().Style("z").Style("y").Style(null).Style("x").TagStart);
        }
        #endregion
    }
}
