using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagStripperTests
{
    //Tests for TagStripper().Attributes(string original, string attribute)
    [TestClass]
    public class StripAttributesOnlyOne
    {
        string StripAttributes(string original, string attribute) => new TagStripper().Attributes(original, attribute);

        [TestMethod]
        public void Normal()
        {
            Assert.AreEqual("<div >", StripAttributes("<div class=example>", "class"));
        }

        [TestMethod]
        public void Normal2()
        {
            Assert.AreEqual("<div >", StripAttributes("<div class='example'>", "class"));
        }

        [TestMethod]
        public void Normal3()
        {
            Assert.AreEqual("<div >", StripAttributes("<div class=\"example\">", "class"));
        }

        [TestMethod]
        public void DoubleSingleNoQuotes()
        {
            Assert.AreEqual("<div src='https://www...' width=100>", StripAttributes("<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>", "style"));
        }

        [TestMethod]
        public void DoubleSingleNoQuotes2()
        {
            Assert.AreEqual("<div style=\"background-color:blue; color: yellow;\" width=100>", StripAttributes("<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>", "src"));
        }

        [TestMethod]
        public void DoubleSingleNoQuotes3()
        {
            Assert.AreEqual("<div style=\"background-color:blue; color: yellow;\" src='https://www...' >", StripAttributes("<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>", "width"));
        }

        [TestMethod]
        public void InvalidAttributes()
        {
            Assert.AreEqual("<div style=\"background-color:blue'>", StripAttributes("<div style=\"background-color:blue'>", "style"));
        }

        [TestMethod]
        public void NewLine()
        {
            Assert.AreEqual("<div\n >", StripAttributes("<div\n style=\"backg\nround-\ncolor:\nblue\">", "style"));
        }

        [TestMethod]
        public void OnlyAttribute()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div >", StripAttributes("<div class>", "class"));
        }

        [TestMethod]
        public void EmptyStringClass()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div >", StripAttributes("<div class=\" \">", "class"));
        }
    }
}
