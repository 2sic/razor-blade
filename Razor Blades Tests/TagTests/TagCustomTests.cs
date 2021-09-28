using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace Razor_Blades_Tests.TagTests
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
