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
            Assert.AreEqual("</p>", new TagCustom("p").TagEnd.ToString());
            Assert.AreEqual("</em>", new TagCustom("em").TagEnd.ToString());
            Assert.AreEqual("</EM>", new TagCustom("EM").TagEnd.ToString());
            Assert.AreEqual("</ng-template>", new TagCustom("ng-template").TagEnd.ToString());
        }

        [TestMethod]
        public void OpenCloseEmptyTags()
        {
            Assert.AreEqual("", new TagCustom("").TagEnd.ToString());
            Assert.AreEqual("", new TagCustom(" ").TagEnd.ToString());
            Assert.AreEqual("", new TagCustom(null).TagEnd.ToString());
            Assert.AreEqual("", new TagCustom("").TagStart.ToString());
            Assert.AreEqual("", new TagCustom(" ").TagStart.ToString());
            Assert.AreEqual("", new TagCustom(null).TagStart.ToString());
        }

        
    }
}
