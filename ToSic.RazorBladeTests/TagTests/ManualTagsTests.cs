﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Markup;

namespace ToSic.RazorBladeTests.TagTests
{
    [TestClass]
    public class ManualTagsTests: TagTestBase
    {
        [TestMethod]
        public void RealTags()
        {
            var text = "<div>";
            Is(text, new TagCustom(text));
            text = "<div id='7'>text</div>";
            Is(text, new TagCustom(text));
        }

        [TestMethod]
        public void Comment()
        {
            var text = "<!-- comment -->";
            Is(text, new TagCustom(text));
        }

        [TestMethod]
        public void Text()
        {
            var text = "div";
            Is(text, new TagText(text));
        }
    }

}
