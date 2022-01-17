using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Html5;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.HtmlTagsTests
{
    [TestClass]
    public class HrBrTests: TagTestBase
    {
        [TestMethod]
        public void Hr()
        {
            Is("<hr>", new Hr());
        }

        [TestMethod]
        public void Br()
        {
            Is("<br>", new Br());
        }
    }
}
