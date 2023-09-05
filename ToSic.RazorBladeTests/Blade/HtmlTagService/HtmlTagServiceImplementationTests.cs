using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.Razor.Blade.Tests
{
    [TestClass()]
    public class HtmlTagsServiceImplementationTests : TagTestBase
    {
        private readonly HtmlTagsServiceImplementation HtmlTagsService = new HtmlTagsServiceImplementation();

        [TestMethod()]
        public void H1Test()
        {
            Is("<h1></h1>", HtmlTagsService.H1());
            Is("<h1>content</h1>", HtmlTagsService.H1("content"));
        }

        [TestMethod()]
        public void AttributesHaveSpaces()
        {
            Is(" name='value' ", HtmlTagsService.Attr("name", "value"));
        }
    }
}