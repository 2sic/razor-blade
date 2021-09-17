using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Razor_Blades_Tests.TextTests
{
    [TestClass]
    public class Test_Blades_Zip
    {

        [TestMethod]
        public void Test_Zip_Basic()
        {
            var message = "This is a   teaser for something";
            var expected = "This is a teaser for something";
            Assert.AreEqual(expected, ToSic.Razor.Blade.Text.Zip(message), "multiple spaces must go");
        }
        
        [TestMethod]
        public void Test_Zip_NewLine()
        {
            var message = "This is a \n  teaser\n for something";
            var expected = "This is a teaser for something";
            Assert.AreEqual(expected, ToSic.Razor.Blade.Text.Zip(message), "multiple spaces must go");
        }

    }
}
