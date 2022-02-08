using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    [TestClass]
    public class StripOnlyMany: ScrubBase
    {
        private string StripOnly(string original, params string[] tags) => GetService<IScrub>().Only(original, tags);

        private void TestStripOnlyMany(string expected, string original, params string[] tags)
            => Assert.AreEqual(expected, GetService<IScrub>().Only(original, tags));

        private void TestStripUnchanged(string original, params string[] tags) => TestStripOnlyMany(original, original, tags);

        [TestMethod]
        public void Normal1()
        {
            string[] testTags = { "a" };
            TestStripOnlyMany("<div>Hello World</div>", "<div>Hello <a>World</a></div>", testTags);
        }

        [TestMethod]
        public void Normal2()
        {
            string[] testTags = { "p", "a" };
            TestStripOnlyMany("<div>HelloWorld</div>", "<div><p>Hello</p><a>World</a></div>", testTags);
        }

        [TestMethod]
        public void Normal3()
        {
            string[] testTags = { "p", "a", "body", "div", "span" };
            TestStripOnlyMany("<html>Hello World</html>", "<html><body><div><span>Hello</span> <a>World</a><div></body></html>", testTags);
        }

        [TestMethod]
        public void Normal4()
        {
            string[] testTags = { "br", "p" };
            TestStripOnlyMany("Hello World", "Hello</p> </br>World", testTags);
        }

        [TestMethod]
        public void EmptyArray()
        {
            string[] testTags = { };
            TestStripOnlyMany("<div>Hello World</div>", "<div>Hello World</div>", testTags);
        }

        [TestMethod]
        public void ArrayWithEmptyStrings()
        {
            string[] testTags = { "", " ", "  " };
            TestStripOnlyMany("<div>Hello World</div>", "<div>Hello World</div>", testTags);
        }

        [TestMethod]
        public void ArrayWithUnnecessaryStrings()
        {
            string[] testTags = { "div", "a" };
            TestStripOnlyMany("Hello", "<div>Hello</div>", testTags);
        }

        [TestMethod]
        public void ArrayWithWeirdInput()
        {
            string[] testTags = { "div", "4x5" };
            TestStripOnlyMany("Hello", "<div>Hello</div>", testTags);
        }

        [TestMethod]
        public void TagsWithAttributes()
        {
            string[] testTags = { "div", "a" };
            TestStripOnlyMany("Hello small World", "<div style=\"background-color: blue; padding:0\" href=\"https//:www...\">Hello<a style=\"background-color:black;\"> small </a>World</div>", testTags);
        }

        [TestMethod]
        public void TagsWithAttributes2()
        {
            string[] testTags = { "div" };
            TestStripOnlyMany("", "<div style\n=\"background-color: blue;\n padding:0\"\n href=\"https//:www...\"\n>", testTags);
        }

        [TestMethod]
        public void Special()
        //This test is expected to leave some > and < behind because they don't belong to the actuall tags
        {
            string[] testTags = { "body", "a" };
            TestStripOnlyMany("<Hello <there<>", "<<body>Hello <<a>there<</a></body>>", testTags);
        }

        [TestMethod]
        public void WrongTag()
        //These tags can't be detected as invalid HTML and will be deleted anyway
        {
            string[] testTags = { "p", "a"};
            TestStripOnlyMany("", "</p/></a/>", testTags);
        }
    }
}
