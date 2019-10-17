using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tag = ToSic.Razor.Html.Tag;

namespace Razor_Blades_Tests.TagTests
{
    [TestClass]
    public class TagObjectBasics: TagTestBase
    {
        [TestMethod]
        public void VeryBasic()
        {
            Is("<div></div>", new Tag("div"));
            Is("<strong></strong>", new Tag{TagName = "strong"});
            Is("<strong>...</strong>", new Tag { TagName = "strong", TagContents = "..."});
        }
    }
}
