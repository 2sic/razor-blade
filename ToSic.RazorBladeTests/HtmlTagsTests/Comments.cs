using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Html5;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.HtmlTagsTests
{
    [TestClass]
    public class Comments: TagTestBase
    {
        [TestMethod]
        public void Empty()
        {
            Is("<!--  -->", new Comment());
        }

        [TestMethod]
        public void WithNote()
        {
            Is("<!-- note -->", new Comment("note"));
        }

    }
}
