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
            Assert.AreEqual("</p>", new TagGeneric("p").TagEnd.ToString());
            Assert.AreEqual("</em>", new TagGeneric("em").TagEnd.ToString());
            Assert.AreEqual("</EM>", new TagGeneric("EM").TagEnd.ToString());
            Assert.AreEqual("</ng-template>", new TagGeneric("ng-template").TagEnd.ToString());
        }

        [TestMethod]
        public void OpenCloseEmptyTags()
        {
            Assert.AreEqual("", new TagGeneric("").TagEnd.ToString());
            Assert.AreEqual("", new TagGeneric(" ").TagEnd.ToString());
            Assert.AreEqual("", new TagGeneric(null).TagEnd.ToString());
            Assert.AreEqual("", new TagGeneric("").TagStart.ToString());
            Assert.AreEqual("", new TagGeneric(" ").TagStart.ToString());
            Assert.AreEqual("", new TagGeneric(null).TagStart.ToString());
        }

        
    }
}
