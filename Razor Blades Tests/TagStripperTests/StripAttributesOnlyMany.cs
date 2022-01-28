using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagStripperTests
{
    //Tests for TagStripper().Attributes(string original, params string[] attributes)
    [TestClass]
    public class StripAttributesOnlyManys
    {
        string StripAttributes(string original, params string[] attributes) => new TagStripper().Attributes(original, attributes);

        [TestMethod]
        public void Normal()
        {
            string[] testAttributes = { "class", "href" };
            Assert.AreEqual("<div ><a >", StripAttributes("<div class=\"example\"><a href='https:...'>", testAttributes));
        }

        [TestMethod]
        public void MultipleAttributes()
        {
            string[] testAttributes = { "class", "href" };
            Assert.AreEqual("<div style='color:blue'>", StripAttributes("<div class=\"hello-world\" href=https:\\... style='color:blue'>", testAttributes));
        }

        [TestMethod]
        public void InvalidAttributes()
        {
            string[] testAttributes = { "style" };
            Assert.AreEqual("<div style=\"background-color:blue'>", StripAttributes("<div style=\"background-color:blue'>", testAttributes));
        }

        [TestMethod]
        public void NewLine()
        {
            string[] testAttributes = { "style" };
            Assert.AreEqual("<div\n >", StripAttributes("<div\n style=\"backg\nround-\ncolor:\nblue\">", testAttributes));
        }

        [TestMethod]
        public void OnlyAttribute()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            string[] testAttributes = { "style", "class" };
            Assert.AreEqual("<div>", StripAttributes("<div class style>", testAttributes));
        }

        [TestMethod]
        public void EmptyStringClass()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            string[] testAttributes = { "style", "class" };
            Assert.AreEqual("<div>", StripAttributes("<div class=\" \" style=' '>", testAttributes));
        }
    }
}
