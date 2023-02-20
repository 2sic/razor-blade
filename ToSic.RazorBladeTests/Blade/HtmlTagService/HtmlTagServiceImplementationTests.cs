using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.Razor.Blade.Tests
{
    [TestClass()]
    public class HtmlTagServiceImplementationTests : TagTestBase
    {
        private readonly HtmlTagServiceImplementation htmlTagService = new HtmlTagServiceImplementation();

        [TestMethod()]
        public void H1Test()
        {
            Is("<h1></h1>", htmlTagService.H1());
            Is("<h1>content</h1>", htmlTagService.H1("content"));
        }
    }
}