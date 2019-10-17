﻿using ToSic.Razor.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Razor_Blades_Tests.Text
{
    [TestClass]
    public class Test_Ellipsis
    {

        [TestMethod]
        public void Test_Ellipsis_Basic()
        {
            var message = "This is a teaser for something";
            Assert.AreEqual(message, ToSic.Razor.Blade.Text.Ellipsis(message, 100), "message is short, shouldn't change");
            Assert.AreEqual("This" + Defaults.HtmlEllipsisCharacter, ToSic.Razor.Blade.Text.Ellipsis(message, 5), "message is longer, should be truncated");
            Assert.AreEqual("This", ToSic.Razor.Blade.Text.Ellipsis(message, 5, ""), "blank Text.Ellipsis char should just trunc");
            Assert.AreEqual(4 + Defaults.HtmlEllipsisCharacter.Length, ToSic.Razor.Blade.Text.Ellipsis(message, 5).Length, "should trunc and add ell");
        }

        [TestMethod]
        public void Test_Ellipsis_DontSplitWords()
        {
            var message = "This is a teaser for something";
            var messageLess12 = "This is a";
            Assert.AreEqual(messageLess12 + Defaults.HtmlEllipsisCharacter, ToSic.Razor.Blade.Text.Ellipsis(message, 12), "should be truncated at previous word");
        }

        [TestMethod]
        public void Test_Ellipsis_With_Umlauts()
        {
            var message = "Visit M&uuml;nchen &amp; Z&uuml;rich";
            var msg5 = "Visit" + Defaults.HtmlEllipsisCharacter;
            var msg13 = "Visit M&uuml;nchen" + Defaults.HtmlEllipsisCharacter;
            Assert.AreEqual(msg5, ToSic.Razor.Blade.Text.Ellipsis(message, 5), "very short");
            Assert.AreEqual(msg5, ToSic.Razor.Blade.Text.Ellipsis(message, 10), "very short");
            Assert.AreEqual(msg5, ToSic.Razor.Blade.Text.Ellipsis(message, 12), "just too short");
            Assert.AreEqual(msg13, ToSic.Razor.Blade.Text.Ellipsis(message, 13), "just right");
            Assert.AreEqual(msg13, ToSic.Razor.Blade.Text.Ellipsis(message, 14), "bit longer, ok");
            Assert.AreNotEqual(msg13, ToSic.Razor.Blade.Text.Ellipsis(message, 15), "now has an html-and, so must be different ok");
        }



    }
}
