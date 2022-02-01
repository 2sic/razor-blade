using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Html5;
using ToSic.Razor.Internals.Mime;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.HtmlTagsTests.IconTests
{
    [TestClass]
    public class IconSets: TagTestBase
    {
        [TestMethod]
        public void DefaultSet()
        {
            var path = "/path/icon.png";
            var set = ToSic.Razor.Internals.Page.IconSet.GenerateIconSet(path);
            Assert.AreEqual(4, set.Count, "expected 3 items in set");
            Is($"<link rel='{Icon.RelIcon}' type='{Mime.MimeTypes["png"]}' href='{path}'>",
                set[0]);
            Is($"<link rel='{Icon.RelShortcut}' type='{Mime.MimeTypes["png"]}' href='{path}'>",
                set[1]);
            Is($"<link rel='{Icon.RelApple}' type='{Mime.MimeTypes["png"]}' href='{path}'>",
                set[2]);
            Is(
                $"<link rel='{Icon.RelShortcut}' type='{Mime.MimeTypes["png"]}' href='{path}'>",
                set[3]);
        }

        [TestMethod]
        public void WithoutDefaultFav()
        {
            var path = "/path/icon.png";

            var set = ToSic.Razor.Internals.Page.IconSet.GenerateIconSet(path, true);
            Assert.AreEqual(4, set.Count, "expected 3 items in set");

            Is($"<link rel='{Icon.RelIcon}' type='{Mime.MimeTypes["png"]}' href='{path}'>",
                set[0]);
            Is($"<link rel='{Icon.RelShortcut}' type='{Mime.MimeTypes["png"]}' href='{path}'>",
                set[1]);
            Is($"<link rel='{Icon.RelApple}' type='{Mime.MimeTypes["png"]}' href='{path}'>",
                set[2]);
            Is(
                $"<link rel='{Icon.RelShortcut}' type='{Mime.MimeTypes["ico"]}' href='/favicon.ico'>",
                set[3]);
        }


        [TestMethod]
        public void WithoutFav()
        {
            var set = ToSic.Razor.Internals.Page.IconSet.GenerateIconSet("/path/icon.png", false);
            Assert.AreEqual(3, set.Count, "expected 3 items in set");
        }

        private static readonly IEnumerable<string> Rels = new List<string> {"icon", "icon2", "icon3", "icon4"};
        private static readonly IEnumerable<int> Sizes = new int[] {
            100, 200, 250
        };

        [TestMethod]
        [SuppressMessage("ReSharper", "StringIndexOfIsCultureSpecific.1")]
        public void CustomRels()
        {
            var set = ToSic.Razor.Internals.Page.IconSet.GenerateIconSet("/path/icon.png", false, Rels);
            Assert.AreEqual(4, set.Count, "expected 4 items in set");
            Assert.IsTrue(set[2].ToString().IndexOf("icon3")> 0);
            Assert.IsTrue(set[2].ToString().IndexOf("icon4") == -1);
        }

        [TestMethod]
        [SuppressMessage("ReSharper", "StringIndexOfIsCultureSpecific.1")]
        public void CustomSizesWithoutFavicon()
        {
            var set = ToSic.Razor.Internals.Page.IconSet.GenerateIconSet("/path/icon.png", false, sizes:Sizes);
            Assert.AreEqual(9, set.Count, "expected 3 sizes for 3 default rels in set");
            Assert.AreEqual(3, set.Count(i => $"{i}".IndexOf("100x100") > 0));
            Assert.AreEqual(3, set.Count(i => $"{i}".IndexOf("200x200") > 0));
        }

        [TestMethod]
        [SuppressMessage("ReSharper", "StringIndexOfIsCultureSpecific.1")]
        public void CustomSizesWithFavicon()
        {
            var set = ToSic.Razor.Internals.Page.IconSet.GenerateIconSet("/path/icon.png", sizes:Sizes);
            Assert.AreEqual(10, set.Count, "expected 3 sizes for 3 default rels + 1 fav in set");
            Assert.AreEqual(3, set.Count(i => $"{i}".IndexOf("100x100") > 0));
            Assert.AreEqual(3, set.Count(i => $"{i}".IndexOf("200x200") > 0));
        }


        [TestMethod]
        [SuppressMessage("ReSharper", "StringIndexOfIsCultureSpecific.1")]
        public void CustomSizesOneRel()
        {
            var set = ToSic.Razor.Internals.Page.IconSet.GenerateIconSet("/path/icon.png", false, rels: new []{"icon"}, sizes:Sizes);
            Assert.AreEqual(3, set.Count, "expected 3 sizes for 1 default rels in set");
            Assert.AreEqual(1, set.Count(i => $"{i}".IndexOf("100x100") > 0));
            Assert.AreEqual(1, set.Count(i => $"{i}".IndexOf("200x200") > 0));
        }

    }
}
