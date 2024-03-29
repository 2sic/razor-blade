﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagBuilderTests
{
    [TestClass]
    public class Test_Blades_Html
    {

        [TestMethod]
        public void Br2Nl()
        {
            var inp = "text<br>second-line";
            var inp2 = inp.Replace(">", "/>");
            var inp3 = inp2.Replace(">", " class='test'>");
            var expected = inp.Replace("<br>", "\n");
            Assert.AreEqual(expected, Tags.Br2Nl(inp));
            Assert.AreEqual(expected, Tags.Br2Nl(inp2));
            Assert.AreEqual(expected, Tags.Br2Nl(inp3));
        }


        [TestMethod]
        public void Br2Space()
        {
            var inp = "text<br>second-line";
            var inp2 = inp.Replace(">", "/>");
            var inp3 = inp2.Replace(">", " class='test'>");
            var expected = inp.Replace("<br>", " ");
            Assert.AreEqual(expected, Tags.Br2Space(inp));
            Assert.AreEqual(expected, Tags.Br2Space(inp2));
            Assert.AreEqual(expected, Tags.Br2Space(inp3));
        }

        [TestMethod]
        public void Nl2Br()
        {
            var inp = "text\nsecond-line\rthird-line\r\nfourth-line";
            var expected = inp.Replace("\n", "<br>")
                .Replace("\r", "<br>");
            Assert.AreEqual(expected, Tags.Nl2Br(inp));
        }

    }
}
