using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Html5;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.HtmlTagsTests
{
    [TestClass]
    public class Headings : TagTestBase
    {
        [TestMethod]
        public void H1To6()
        {
            Is("<h1></h1>", new H1(false));
            Is("<h2></h2>", new H2(false));
            Is("<h3></h3>", new H3(false));
            Is("<h4></h4>", new H4(false));
            Is("<h5></h5>", new H5(false));
            Is("<h6></h6>", new H6(false));
        }

        [TestMethod]
        public void H1To6WithContent()
        {
            Is("<h1>title</h1>", new H1(false, "title"));
            Is("<h2>title</h2>", new H2(false, "title"));
            Is("<h3>title</h3>", new H3(false, "title"));
            Is("<h4>title</h4>", new H4(false, "title"));
            Is("<h5>title</h5>", new H5(false, "title"));
            Is("<h6>title</h6>", new H6(false, "title"));
        }
    }

}
