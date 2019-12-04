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
            Is("<div></div>", new TagCustom("div"));
            Is("<strong></strong>", new TagCustom( "strong"));
            Is("<strong>...</strong>", new TagCustom("strong"){ TagContents = "..."});
        }
    }
}
