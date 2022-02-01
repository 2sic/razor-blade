using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ToSic.RazorBladeTests.TextTests
{
    [TestClass]
    public class TextBefore
    {
        [TestMethod] public void BeforeBasic() => AreEqual("before stuff and ", "before stuff and something=result".Before("something="));
        [TestMethod] public void BeforeEmpty() => AreEqual("", "before stuff and something=result".Before(""));
        [TestMethod] public void BeforeNull() => AreEqual(null, "before stuff and something=result".Before(null));
        [TestMethod] public void BeforeOfNull() => AreEqual(null, ((string)null).Before("something"));
        [TestMethod] public void BeforeNotFound() => AreEqual(null, "before stuff and something=result".Before("doesn't exist"));
        [TestMethod] public void BeforeMultiple() => AreEqual("before stuff ", "before stuff and and something=result".Before("and"));
        [TestMethod] public void BeforeMultipleLast() => AreEqual("before stuff and ", "before stuff and and something=result".BeforeLast("and"));



        [TestMethod] public void BeforeWithStatic() => AreEqual("before stuff and ", "before stuff and something=result".Before("something="));
        [TestMethod] public void BeforeWithTextDot() => AreEqual("before stuff and ", Text.Before("before stuff and something=result","something="));


    }
}
