using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using ToSic.Razor.Markup;

namespace ToSic.RazorBladeTests.TagTests
{
    [TestClass]
    public class TagOperatorsTests
    {
        [TestMethod]
        public void AddTags()
        {
            var addTags = Tag.Div() + Tag.P();
            Assert.IsInstanceOfType(addTags, typeof(TagBase));
            Assert.AreEqual("<div></div><p></p>", addTags.ToString());

            var addTags2 = Tag.Div("a") + Tag.P("b");
            Assert.IsInstanceOfType(addTags2, typeof(TagBase));
            Assert.AreEqual("<div>a</div><p>b</p>", addTags2.ToString());
        }

        [TestMethod]
        public void AddTagsWithStrings()
        {
            var addTags = "<div></div>" + Tag.P();
            Assert.IsInstanceOfType(addTags, typeof(string));
            Assert.AreEqual("<div></div><p></p>", addTags);

            var addTags2 = Tag.Div("a") + "<p>b</p>";
            Assert.IsInstanceOfType(addTags2, typeof(string));
            Assert.AreEqual("<div>a</div><p>b</p>", addTags2);
        }

        [TestMethod]
        public void AddTagsWithNumbers()
        {
            var addTags = 5 + Tag.P();
            Assert.IsInstanceOfType(addTags, typeof(string));
            Assert.AreEqual("5<p></p>", addTags);

            var addTags2 = Tag.Div("a") + 27;
            Assert.IsInstanceOfType(addTags2, typeof(string));
            Assert.AreEqual("<div>a</div>27", addTags2);
        }

        [TestMethod]
        public void AddTagsWithBoolean()
        {
            var addTags = true + Tag.P();
            Assert.IsInstanceOfType(addTags, typeof(string));
            Assert.AreEqual("true<p></p>", addTags);

            var addTags2 = Tag.Div("a") + false;
            Assert.IsInstanceOfType(addTags2, typeof(string));
            Assert.AreEqual("<div>a</div>false", addTags2);
        }
    }
}
