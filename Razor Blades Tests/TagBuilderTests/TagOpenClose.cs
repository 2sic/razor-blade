using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Markup;


namespace Razor_Blades_Tests.TagBuilderTests
{
    [TestClass]
    public class TagOpenClose
    {
        [TestMethod]
        public void CloseSimpleTags()
        {
            Assert.AreEqual("</p>", new TagBase("p").TagEnd.ToString());
            Assert.AreEqual("</em>", new TagBase("em").TagEnd.ToString());
            Assert.AreEqual("</EM>", new TagBase("EM").TagEnd.ToString());
            Assert.AreEqual("</ng-template>", new TagBase("ng-template").TagEnd.ToString());
        }

        [TestMethod]
        public void OpenCloseEmptyTags()
        {
            Assert.AreEqual("", new TagBase("").TagEnd.ToString());
            Assert.AreEqual("", new TagBase(" ").TagEnd.ToString());
            Assert.AreEqual("", new TagBase(null).TagEnd.ToString());
            Assert.AreEqual("", new TagBase("").TagStart.ToString());
            Assert.AreEqual("", new TagBase(" ").TagStart.ToString());
            Assert.AreEqual("", new TagBase(null).TagStart.ToString());
        }

        
    }
}
