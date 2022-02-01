using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagTests
{
    [TestClass]
    public class RawHtmlTests: TagTestBase
    {
        [TestMethod]
        public void Basic()
        {
            Is("", Tag.RawHtml(""));
            Is("", Tag.RawHtml(""));
            Is("hello", Tag.RawHtml("hello"));
            Is("test='value'", Tag.RawHtml("test='value'"));
        }
    }
}
