using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToSic.Razor.Blade;
using ToSic.Razor.Markup;

namespace Razor_Blades_Tests.TagTests
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
