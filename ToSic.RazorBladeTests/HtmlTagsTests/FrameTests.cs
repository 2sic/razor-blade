using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Html5;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.HtmlTagsTests
{
    [TestClass]
    public class FrameTests: TagTestBase
    {
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void IFrames()
        {
            Is("<iframe>", 
                new Iframe());
            Is("<iframe src='https://azing.org'>", 
                new Iframe("https://azing.org"));
            Is("<iframe src='https://azing.org'>", 
                new Iframe().Src("https://azing.org"));

            Is("<iframe src='xyz' height='8' width='7'>", 
                new Iframe("xyz", 7, 8));
        }

    }
}
