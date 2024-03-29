﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToSic.RazorBladeTests.TextTests
{
    [TestClass]
    public class Test_Blades_HasText
    {

        [TestMethod]
        public void Test_HasText()
        {
            Assert.IsFalse(ToSic.Razor.Blade.Text.Has(null), "null should be no text");
            Assert.IsFalse(ToSic.Razor.Blade.Text.Has(""), "empty should be no text");
            Assert.IsFalse(ToSic.Razor.Blade.Text.Has("   "), "spaces should be no text");
            Assert.IsFalse(ToSic.Razor.Blade.Text.Has("			"), "tabs should be no text");
            Assert.IsTrue(ToSic.Razor.Blade.Text.Has("xyz"), "text shouldn't be null or WS");
        }

        [TestMethod]
        public void Test_HasText_WithHtmlWhitespace()
        {
            Assert.IsFalse(ToSic.Razor.Blade.Text.Has("&nbsp;"), "nbsp should be no text");
            Assert.IsFalse(ToSic.Razor.Blade.Text.Has("&#160;"), "#160 should be no text");
            Assert.IsFalse(ToSic.Razor.Blade.Text.Has("  &nbsp;&nbsp; "), "spaces with multiple whitespace should be no text");
            Assert.IsTrue(ToSic.Razor.Blade.Text.Has("&nbsp;xyz"), "text shouldn't be null or WS");
        }

    }
}
