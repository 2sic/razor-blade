using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using ToSic.Razor.Markup;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ToSic.RazorBladeTests.TagTests
{
    [TestClass]
    public class TagOperatorsTests
    {
        [TestMethod]
        public void AddTags()
        {
            var addTags = Tag.Div() + Tag.P();
            IsInstanceOfType(addTags, typeof(TagBase));
            IsInstanceOfType(addTags, typeof(IHtmlTag));
            AreEqual("<div></div><p></p>", addTags.ToString());

            var addTags2 = Tag.Div("a") + Tag.P("b");
            IsInstanceOfType(addTags2, typeof(TagBase));
            IsInstanceOfType(addTags2, typeof(IHtmlTag));
            AreEqual("<div>a</div><p>b</p>", addTags2.ToString());
        }

        [TestMethod]
        public void AddTagsWithStrings()
        {
            var addTags = "<div></div>" + Tag.P();
            IsInstanceOfType(addTags, typeof(string));
            AreEqual("<div></div><p></p>", addTags);

            var addTags2 = Tag.Div("a") + "<p>b</p>";
            IsInstanceOfType(addTags2, typeof(string));
            AreEqual("<div>a</div><p>b</p>", addTags2);
        }

        [TestMethod]
        public void AddTagsWithNumbers()
        {
            var addTags = 5 + Tag.P();
            IsInstanceOfType(addTags, typeof(string));
            AreEqual("5<p></p>", addTags);

            var addTags2 = Tag.Div("a") + 27;
            IsInstanceOfType(addTags2, typeof(string));
            AreEqual("<div>a</div>27", addTags2);
        }

        [TestMethod]
        public void AddTagsWithBoolean()
        {
            var addTags = true + Tag.P();
            IsInstanceOfType(addTags, typeof(string));
            AreEqual("true<p></p>", addTags);

            var addTags2 = Tag.Div("a") + false;
            IsInstanceOfType(addTags2, typeof(string));
            AreEqual("<div>a</div>false", addTags2);
        }
    }
}
