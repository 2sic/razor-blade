using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    [TestClass]
    public class StripAll: ScrubBase
    {
        private string StripTags(string original) => GetService<IScrub>().All(original);

        private void TestStripTagsAll(string expected, string original)
            => Assert.AreEqual(expected, GetService<IScrub>().All(original));

        [TestMethod]
        public void Basic() => TestStripTagsAll("Hello there", "<h1>Hello</h1><strong> there</strong>");

        [TestMethod]
        public void MultiLine() => TestStripTagsAll("Hello there", "<h1>\nHello\n </ h1 >\n < strong >\nthere\n </ strong >");

        [TestMethod]
        public void MultiLineTag() => TestStripTagsAll("Hello there", "<h1>\nHello\n</h1>\n<strong\n  class='something'\n  onclick='someJs'>\nthere\n</strong>");
        [TestMethod]
        public void NullCheck() => TestStripTagsAll(null, null);

        [TestMethod]
        public void Test_StripHtml() => TestStripTagsAll("some text with valid html", "<div>some text with valid html</div>");
    }
}
