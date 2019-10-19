using ToSic.Razor.Blade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable StringLiteralTypo

namespace Razor_Blades_Tests.TagTests
{
    [TestClass]
    public class TagAttributeTests: TagTestBase
    {
        #region Generic Attr calls
        [TestMethod]
        public void TagAttributeBasics()
        {
            Is("<div class='x'>", Tag.Custom("div").Attr("class", "x").TagStart);
        }

        [TestMethod]
        public void TagAttributeStandalone()
        {
            Is("<div data-fancybox>", Tag.Custom("div").Attr("data-fancybox").TagStart);
        }

        [TestMethod]
        public void TagAttributeMultiple()
        {
            Is("<div class='x' name='value'>", Tag.Custom("div")
                .Attr("class", "x")
                .Attr("name", "value")
                .TagStart
            );
        }

         [TestMethod]
        public void TagAttributeAppend()
        {
            Is("<div class='xyz'>", Tag.Custom("div")
                .Attr("class", "x", "")
                .Attr("class", "y", "")
                .Attr("class", "z", "")
                .TagStart
            );
        }

        [TestMethod]
        public void TagAttributeSeparator()
        {
            Is("<div class='x,y-z'>", Tag.Custom("div")
                .Attr("class", "x", " ")
                .Attr("class", "y", ",")
                .Attr("class", "z", "-")
                .TagStart
            );
        }

        [TestMethod]
        public void TagAttributeReplace()
        {
            Is("<div class='z'>", Tag.Custom("div")
                .Attr("class", "x", " ")
                .Attr("class", "y", ",")
                .Attr("class", "z", null)
                .TagStart
            );
        }
        #endregion

        #region Id, Class, Title, Style
        [TestMethod]
        public void TagId()
        {
            Is("<div id='z'>", Tag.Custom("div").Id("z").TagStart);
            Is("<div id='y'>", Tag.Custom("div").Id("z").Id("y").TagStart);
            Is("<div id>", Tag.Custom("div").Id(null).TagStart);
            Is("<div id>", Tag.Custom("div").Id("z").Id(null).TagStart);
            Is("<div id='x'>", Tag.Custom("div").Id("z").Id(null).Id("x").TagStart);
        }

        [TestMethod]
        public void TagClass()
        {
            Is("<div class='z'>", Tag.Custom("div").Class("z").TagStart);
            Is("<div class='z y'>", Tag.Custom("div").Class("z").Class("y").TagStart);
            Is("<div class>", Tag.Custom("div").Class(null).TagStart);
            Is("<div class>", Tag.Custom("div").Class("z").Class("y").Class(null).TagStart);
            Is("<div class='x'>", Tag.Custom("div").Class("z").Class("y").Class(null).Class("x").TagStart);
        }

        [TestMethod]
        public void TagStyle()
        {
            Is("<div style='z'>", Tag.Custom("div").Style("z").TagStart);
            Is("<div style='z;y'>", Tag.Custom("div").Style("z").Style("y").TagStart);
            Is("<div style>", Tag.Custom("div").Style("z").Style("y").Style(null).TagStart);
            Is("<div style='x'>", Tag.Custom("div").Style("z").Style("y").Style(null).Style("x").TagStart);
        }
        #endregion
    }
}
