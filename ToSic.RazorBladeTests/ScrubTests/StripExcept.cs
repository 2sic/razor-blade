using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    [TestClass]
    public class StripExceptMany: ScrubBase
    {
        private string StripExcept(string original, params string[] tags) => GetService<IScrub>().Except(original, tags);

        private void TestStripExcept(string expected, string original, params string[] tags)
            => Assert.AreEqual(expected, GetService<IScrub>().Except(original, tags));

        private void TestStripUnchanged(string original, params string[] tags) => TestStripExcept(original, original, tags);

        //Tests with strings
        [TestMethod]
        public void Normal1()
        {
            var testTags = "div";
            TestStripExcept("<div>Hello small World</div>", "<div>Hello <p>small</p> World</div>", testTags);
        }

        //Tests with array 
        [TestMethod]
        public void Normal2()
        {
            string[] testTags = { "div", "a" };
            TestStripExcept("<div>Hello <a>small</a> World</div>", "<div>Hello <p><a>small</a></p> World</div>", testTags);
        }

        [TestMethod]
        public void Normal3()
        {
            string[] testTags = { "div", "a", "b" };
            TestStripExcept("<div>This<a> is </a></div><div><b>an </b>Example</div>", "<body><div>This<a> is </a></div></br><div><b>an </b>Example</div></body>", testTags);
        }

        [TestMethod]
        public void EmptyArray()
        {
            // An empty array doesn't do anything in this case you can just use the normal strip
            string[] testTags = { };
            TestStripExcept("<body><div>This<a> is </a></div></br><div><b>an </b>Example</div></body>", "<body><div>This<a> is </a></div></br><div><b>an </b>Example</div></body>", testTags);
        }

        [TestMethod]
        public void ArrayWithEmptyStrings()
        {
            string[] testTags = { "", " ", "  " };
            TestStripExcept("This is an Example", "<body><div>This<a> is </a></div></br><div><b>an </b>Example</div></body>", testTags);
        }

        [TestMethod]
        public void ArrayWithUnnecessaryStrings()
        {
            string[] testTags = { "a" };
            TestStripExcept("Hello", "<div>Hello</div>", testTags);
        }

        [TestMethod]
        public void NoTags()
        {
            string[] testTags = { "a" };
            TestStripUnchanged("Hello", testTags);
            TestStripExcept("", "", testTags);

        }

        [TestMethod]
        public void ArrayWithWeirdInput()
        {
            string[] testTags = { "div", "4x5" };
            TestStripExcept("<div>Hello</div>", "<div>Hello</div>", testTags);
        }

        [TestMethod]
        public void TagsWithAttributes()
        {
            string[] testTags = { "div" };
            TestStripExcept("<div style=\"background-color: blue; padding:0\" href=\"https//:www...\">Hello small World</div>", "<div style=\"background-color: blue; padding:0\" href=\"https//:www...\">Hello<a style=\"background-color:black;\"> small </a>World</div>", testTags);
        }

        [TestMethod]
        public void TagsWithAttributes2()
        {
            string[] testTags = { "body" };
            TestStripExcept("<body></body>", "<body><div style\n=\"background-color: blue;\n padding:0\"\n href=\"https//:www...\"\n></body>", testTags);
        }

        [TestMethod]
        public void TagNamesWithNumbers()
        {
            string[] testTags = { "div", "span" };
            TestStripExcept("<div><span>The cool title</span></div>", "<div><h2><span>The cool title</span></h2></div>", testTags);
        }

        [TestMethod]
        public void TagNamesWithNumbers2()
        {
            string[] testTags = { "div", "span" };
            TestStripExcept("A cool text with some random numbers: 1234567890", "<2sic><h2><he11o>A cool text with some random numbers: 1234567890</he11o></h2></2sic>", testTags);
        }

        //Tests with constants
        [TestMethod]
        public void ExceptWithTagSetsFormatting()
        {
            TestStripExcept("<i></i>", "<i><img></i>", TagSets.Formatting);
        }

        [TestMethod]
        public void ExceptWithTagSetsFormattingSimple()
        {
            TestStripExcept("<em>Hello</em><i> World</i>", "<div><em>Hello</em><i> World</i></div>", TagSets.FormattingSimple);
        }

        [TestMethod]
        public void ExceptWithTagSetsInlineBasic()
        {
            TestStripExcept("<em>Hello</em><a> small </a><i>World</i>", "<div><em>Hello</em><p><a> small </a></p><i>World</i></div>", TagSets.InlineBasic);
        }
    }
}
