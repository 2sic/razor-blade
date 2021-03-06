﻿using ToSic.Razor.Html5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Razor_Blades_Tests.HtmlTagsTests
{
    [TestClass]
    public class HrBrTests: TagTestBase
    {
        [TestMethod]
        public void Hr()
        {
            Is("<hr>", new Hr());
        }

        [TestMethod]
        public void Br()
        {
            Is("<br>", new Br());
        }
    }
}
