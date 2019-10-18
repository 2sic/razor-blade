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
            Assert.AreEqual("</p>", new TagBase("p").Close.ToString());
            Assert.AreEqual("</em>", new TagBase("em").Close.ToString());
            Assert.AreEqual("</EM>", new TagBase("EM").Close.ToString());
            Assert.AreEqual("</ng-template>", new TagBase("ng-template").Close.ToString());
        }

        [TestMethod]
        public void OpenCloseEmptyTags()
        {
            Assert.AreEqual("", new TagBase("").Close.ToString());
            Assert.AreEqual("", new TagBase(" ").Close.ToString());
            Assert.AreEqual("", new TagBase(null).Close.ToString());
            Assert.AreEqual("", new TagBase("").Open.ToString());
            Assert.AreEqual("", new TagBase(" ").Open.ToString());
            Assert.AreEqual("", new TagBase(null).Open.ToString());
        }

        
    }
}
