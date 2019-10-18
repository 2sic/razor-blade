using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Markup;

namespace Razor_Blades_Tests.TagTests
{
    [TestClass]
    public class TagObjectBasics: TagTestBase
    {
        [TestMethod]
        public void VeryBasic()
        {
            Is("<div></div>", new TagBase("div"));
            Is("<strong></strong>", new TagBase{TagName = "strong"});
            Is("<strong>...</strong>", new TagBase { TagName = "strong", TagContents = "..."});
        }
    }
}
