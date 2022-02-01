using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    [TestClass]
    public class StripExceptMany
    {
        private string StripExcept(string original, params string[] tags) => new Scrub().Except(original, tags);

        [TestMethod]
        public void Normal1()
        {
            var testTags = "div";
            Assert.AreEqual("<div>Hello small World</div>", StripExcept("<div>Hello <p>small</p> World</div>", testTags));
        }

        [TestMethod]
        public void Normal2()
        {
            string[] testTags = { "div", "a" };
            Assert.AreEqual("<div>Hello <a>small</a> World</div>", StripExcept("<div>Hello <p><a>small</a></p> World</div>", testTags));
        }

        [TestMethod]
        public void Normal3()
        {
            string[] testTags = { "div", "a", "b" };
            Assert.AreEqual("<div>This<a> is </a></div><div><b>an </b>Example</div>", StripExcept("<body><div>This<a> is </a></div></br><div><b>an </b>Example</div></body>", testTags));
        }

        [TestMethod]
        public void EmptyArray()
        {
            // An empty array doesn't do anything in this case you can just use the normal strip
            string[] testTags = { };
            Assert.AreEqual("<body><div>This<a> is </a></div></br><div><b>an </b>Example</div></body>", StripExcept("<body><div>This<a> is </a></div></br><div><b>an </b>Example</div></body>", testTags));
        }

        [TestMethod]
        public void ArrayWithEmptyStrings()
        {
            string[] testTags = { "", " ", "  " };
            Assert.AreEqual("This is an Example", StripExcept("<body><div>This<a> is </a></div></br><div><b>an </b>Example</div></body>", testTags));
        }

        [TestMethod]
        public void ArrayWithUnnecessaryStrings()
        {
            string[] testTags = { "a" };
            Assert.AreEqual("Hello", StripExcept("<div>Hello</div>", testTags));
        }

        [TestMethod]
        public void NoTags()
        {
            string[] testTags = { "a" };
            Assert.AreEqual("Hello", StripExcept("Hello", testTags));
        }

        [TestMethod]
        public void ArrayWithWeirdInput()
        {
            string[] testTags = { "div", "4x5" };
            Assert.AreEqual("<div>Hello</div>", StripExcept("<div>Hello</div>", testTags));
        }

        [TestMethod]
        public void TagsWithAttributes()
        {
            string[] testTags = { "div" };
            Assert.AreEqual("<div style=\"background-color: blue; padding:0\" href=\"https//:www...\">Hello small World</div>", StripExcept("<div style=\"background-color: blue; padding:0\" href=\"https//:www...\">Hello<a style=\"background-color:black;\"> small </a>World</div>", testTags));
        }

        [TestMethod]
        public void TagsWithAttributes2()
        {
            string[] testTags = { "body" };
            Assert.AreEqual("<body></body>", StripExcept("<body><div style\n=\"background-color: blue;\n padding:0\"\n href=\"https//:www...\"\n></body>", testTags));
        }

        //Tests with constants
        [TestMethod]
        public void ExceptWithTagSetsFormatting()
        {
            Assert.AreEqual("<i></i>", StripExcept("<i><img></i>", TagSets.Formatting));
        }

        [TestMethod]
        public void ExceptWithTagSetsFormattingSimple()
        {
            Assert.AreEqual("<em>Hello</em><i> World</i>", StripExcept("<div><em>Hello</em><i> World</i></div>", TagSets.FormattingSimple));
        }

        [TestMethod]
        public void ExceptWithTagSetsInlineBasic()
        {
            Assert.AreEqual("<em>Hello</em><a> small </a><i>World</i>", StripExcept("<div><em>Hello</em><p><a> small </a></p><i>World</i></div>", TagSets.InlineBasic));
        }
    }
}
