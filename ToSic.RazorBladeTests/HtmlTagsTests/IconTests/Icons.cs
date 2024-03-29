﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Html5;
using ToSic.Razor.Internals.Mime;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.HtmlTagsTests.IconTests
{
    [TestClass]
    public class Icons: TagTestBase
    {
        [TestMethod]
        public void BasicIco()
        {
            var expected =
                $"<link rel='{Icon.RelIcon}' type='{Mime.MimeTypes["ico"]}' href='/favicon.ico'>";
            var result = new Icon("/favicon.ico");
            Is(expected, result);
        }


        [TestMethod]
        public void CustomType()
        {
            var someDummyType = "image/xyz";
            Is($"<link rel='{Icon.RelIcon}' type='{someDummyType}' href='/favicon.ico'>", 
                new Icon("/favicon.ico", type:someDummyType));
        }

        [TestMethod]
        public void CustomTypeFluent()
        {
            var someDummyType = "image/xyz";
            Is($"<link rel='{Icon.RelIcon}' type='{someDummyType}' href='/favicon.ico'>", 
                new Icon("/favicon.ico").Type(someDummyType));
        }

        [TestMethod]
        public void BasicPng()
        {
            Is($"<link rel='{Icon.RelIcon}' type='{Mime.MimeTypes["png"]}' href='/path/icon.png'>", 
               new Icon("/path/icon.png"));
        }

        [TestMethod]
        public void CustomRel()
        {
            var customRel = "xyz";
            Is($"<link rel='{customRel}' type='{Mime.MimeTypes["png"]}' href='/path/icon.png'>",
                new Icon("/path/icon.png", rel: customRel));
        }

    }
}
