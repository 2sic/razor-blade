using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace ToSic.RazorBladeTests.TextTests
{
    [TestClass]
    public class TextAfter
    {

        [TestMethod]
        public void AfterBasic() => AreEqual("result", "before stuff and something=result".After("something="));

        [TestMethod]
        public void AfterBasicCaseInsensitive() => AreEqual("result", "before stuff and something=result".After("SOMETHING="));

        [TestMethod]
        public void AfterBasicCaseSensitive() => AreEqual(null, "before stuff and something=result".After("SOMETHING=", true));

        [TestMethod]
        public void AfterNotFound() => AreEqual(null, "before stuff and something=result".After("doesn't exist"));

        [TestMethod]
        public void AfterNotFoundWithDefined() => AreEqual("", "before stuff and something=result".After("doesn't exist") ?? "");

        [TestMethod]
        public void AfterAtEnd() => AreEqual("", "before stuff and something=result".After("result"));

        [TestMethod]
        public void AfterWithNullValue() => AreEqual(null, ((string)null).After("result"));

        [TestMethod]
        public void AfterWithNullKeyAndValue() => AreEqual(null, ((string)null).After(null));

        [TestMethod]
        public void AfterWithNullKey() => AreEqual(null, "something".After(null));

        [TestMethod]
        public void AfterMultiple() => AreEqual("y x=7 x=99", "before stuff and x=y x=7 x=99".After("x="));

        [TestMethod]
        public void AfterMultipleLast() => AreEqual("99", "before stuff and x=y x=7 x=99".AfterLast("x="));



    }
}
