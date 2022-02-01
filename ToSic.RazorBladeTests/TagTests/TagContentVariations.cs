using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using ToSic.Razor.Markup;

namespace ToSic.RazorBladeTests.TagTests
{
    [TestClass]
    public class TagContentVariations
    {
        [TestMethod]
        public void Strings()
        {
            Assert.AreEqual("<p>test</p>", Tag.P("test").ToString());
            Assert.AreEqual("<p>test123</p>", Tag.P("test", "123").ToString());
        }

        [TestMethod]
        public void NullTest()
        {
            Assert.AreEqual("<p></p>", Tag.P(null).ToString());
            Assert.AreEqual("<p></p>", Tag.P(null, null).ToString());
            Assert.AreEqual("<p>test123</p>", Tag.P("test", null, "123").ToString());
        }

        [TestMethod]
        public void StringContentArray()
        {
            var content = new[] { "test", "123", "abc" };
            Assert.AreEqual("<p>test123abc</p>", Tag.P(content).ToString());
        }

        [TestMethod]
        public void StringContentEnumerable()
        {
            var content = new List<string> { "test", "123", "abc" };
            Assert.AreEqual("<p>test123abc</p>", Tag.P(content).ToString());
        }

        [TestMethod]
        public void StringContentTagsEnumerable()
        {
            var content = new ITag[] { Tag.Em(), Tag.Strong("test") };
            Assert.AreEqual("<p><em></em><strong>test</strong></p>", Tag.P(content).ToString());
        }
    }
}
