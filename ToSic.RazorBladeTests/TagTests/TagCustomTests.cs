using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagTests
{
    [TestClass]
    public class TagCustomTests: TagTestBase
    {
        [TestMethod]
        public void CustomTag()
        {
            Is("", Tag.Custom(null));
            Is("", Tag.Custom(""));
            Is("<p></p>", Tag.Custom("p"));
        }
    }
}
