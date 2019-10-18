using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Markup;

namespace Razor_Blades_Tests.TagTests
{
    [TestClass]
    public class ManualTagsTests: TagTestBase
    {
        [TestMethod]
        public void RealTags()
        {
            var text = "<div>";
            Is(text, new TagBase(text));
            text = "<div id='7'>text</div>";
            Is(text, new TagBase(text));
        }

        [TestMethod]
        public void Comment()
        {
            var text = "<!-- comment -->";
            Is(text, new TagBase(text));
        }

        [TestMethod]
        public void Text()
        {
            var text = "div";
            Is(text, TagBase.Text(text));
        }
    }

}
