﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Internals;

namespace ToSic.RazorBladeTests.TagBuilderTests
{
    [TestClass]
    public class HtmlEncode
    {
        private static readonly Dictionary<string, string> TestVals = new Dictionary<string, string>
        {
            {"hello", "hello"},
            {"that's", "that&apos;s" },
            {"he said: \"hello\"", "he said: &quot;hello&quot;" },
            {"this & that", "this &amp; that" }
        };

        [TestMethod]
        public void AttributeEncode()
        {
            foreach(var set in TestVals)
                Assert.AreEqual(set.Value, Html.Encode(set.Key), $"{set.Key}");
        }
    }
}
