﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Connect.Razor.V1.Blade;

namespace Razor_Blades_Tests
{
    [TestClass]
    public class Test_Blades_Html
    {
        [TestMethod]
        public void Test_StripHtml()
        {
            var html = "<div>some text with valid html</div>";
            var clean = "some text with valid html";
            var strip = StripTags(html);

            Assert.AreEqual(clean, strip, "should be the same");
        }
        
    }
}
