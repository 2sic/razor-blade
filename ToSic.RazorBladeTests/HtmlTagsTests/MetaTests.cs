﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Html5;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.HtmlTagsTests
{
    [TestClass]
    public class MetaTests: TagTestBase
    {
        [TestMethod]
        public void MetaTag()
        {
            Is("<meta name='something' content='other'>", 
                new Meta("something", "other"));
            Is("<meta name='something' content='other'>", 
                new Meta("something").Content("other"));
            Is("<meta name='something' content='other'>", 
                new Meta().Name("something").Content("other"));
        }

        [TestMethod]
        public void MetaOgTag()
        {
            Is("<meta property='og:something' content='other'>", 
                new MetaOg("something", "other"), "basic");
            Is("<meta property='og:something' content='other'>",
                new MetaOg("og:something", "other"), "basic");
            Is("<meta property='og:something' content='other'>",
                new MetaOg("something", "").Content("other"), "");
            Is("<meta property='og:something' content='other'>",
                new MetaOg().Property("something").Content( "other"), "default order");
            Is("<meta content='other' property='og:something'>",
                new MetaOg().Content("other").Property("something"), "modified order");
        }


        [TestMethod]
        public void MetaTagFluentWithBaseProperties()
        {
            Is("<meta id='x' name='something' content='other'>",
                new Meta().Id("x").Name("something").Content("other"));
        }


    }
}
