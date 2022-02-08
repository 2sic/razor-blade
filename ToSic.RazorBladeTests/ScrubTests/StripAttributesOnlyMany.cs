using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    //Tests for TagStripper().Attributes(string original, params string[] attributes)
    [TestClass]
    public class StripAttributesOnlyManys: ScrubBase
    {
        string StripAttributes(string original, params string[] attributes) => GetService<IScrub>().Attributes(original, attributes);

        private void TestStripOnlyMany(string expected, string original, params string[] attributes)
            => Assert.AreEqual(expected, GetService<IScrub>().Attributes(original, attributes));

        private void TestStripUnchanged(string original, params string[] attributes) => TestStripOnlyMany(original, original, attributes);

        [TestMethod]
        public void Normal()
        {
            string[] testAttributes = { "class", "href" };
            TestStripOnlyMany("<div ><a >", "<div class=\"example\"><a href='https:...'>", testAttributes);        
        }

        [TestMethod]
        public void MultipleAttributes()
        {
            string[] testAttributes = { "class", "href" };
            TestStripOnlyMany("<div style='color:blue'>", "<div class=\"hello-world\" href=https:\\... style='color:blue'>", testAttributes);
        }

        [TestMethod]
        public void InvalidAttributes()
        {
            string[] testAttributes = { "style" };
            TestStripUnchanged("<div style=\"background-color:blue'>", testAttributes);
        }

        [TestMethod]
        public void NewLine()
        {
            string[] testAttributes = { "style" };
            TestStripOnlyMany("<div\n >", "<div\n style=\"backg\nround-\ncolor:\nblue\">", testAttributes);

        }

        [TestMethod]
        public void OnlyAttribute()
        {
            string[] testAttributes = { "style", "class" };
            TestStripOnlyMany("<div>", "<div class style>", testAttributes);
        }

        [TestMethod]
        public void EmptyStringAttributes()
        {
            string[] testAttributes = { "style", "class" };
            TestStripOnlyMany("<div>", "<div class=\" \" style=' '>", testAttributes);
        }
    }
}
