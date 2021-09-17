using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace Razor_Blades_Tests.TagsTests
{
    [TestClass]
    public class Nl2BrTests
    {
        [TestMethod]
        public void Basic()
        {
            Assert.AreEqual("", Tags.Nl2Br(""));
            Assert.AreEqual("<br>", Tags.Nl2Br("\n"));
            Assert.AreEqual("<br><br>", Tags.Nl2Br("\n\n"));
            Assert.AreEqual("<br>abc<br>", Tags.Nl2Br("\nabc\n"));
        }

        [TestMethod]
        public void NullCheck()
        {
            Assert.AreEqual(null, Tags.Nl2Br(null));
        }
    }
}
