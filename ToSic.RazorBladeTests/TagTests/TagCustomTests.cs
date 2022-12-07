using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagTests
{
    [TestClass]
    public class TagCustomTests: TagTestBase
    {
        [DataRow("", null)]
        [DataRow("", "")]
        [DataRow("<p></p>", "p")]
        [TestMethod]
        public void CustomTag(string exp, string tag)
        {
            
            Is(exp, Tag.Custom(tag));
            //Is("", Tag.Custom(null));
            //Is("", Tag.Custom(""));
            //Is("<p></p>", Tag.Custom("p"));
        }

        //[DataRow("", null, null)]
        //[DataRow("", "", "")]
        //[DataRow("<p></p>", "p", null)]
        [DataRow("<h1>title</h1>", "h1", "title")]
        [TestMethod]
        public void CustomTagWithVal(string exp, string tag, string val)
        {

            Is(exp, Tag.Custom(tag, val));
            //Is("", Tag.Custom(null));
            //Is("", Tag.Custom(""));
            //Is("<p></p>", Tag.Custom("p"));
            //Is("<h1>title</h1>", Tag.Custom("h1", "title"));
        }

    }
}
