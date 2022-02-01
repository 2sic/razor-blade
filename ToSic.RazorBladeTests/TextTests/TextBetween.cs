using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace ToSic.RazorBladeTests.TextTests
{
    [TestClass]
    public class TextBetween
    {
        [TestMethod] public void BetweenBasic() => AreEqual(" stuff ", "before stuff and something=result".Between("before", "and"));
        [TestMethod] public void BetweenNull() => AreEqual(null, ((string)null).Between("before", "and"));
        [TestMethod] public void BetweenStartNotFound() => AreEqual(null, "before stuff and something=result".Between("don't exist", "and"));
        [TestMethod] public void BetweenEndNotFound() => AreEqual(null, "before stuff and something=result".Between("before", "not found"));
        [TestMethod] public void BetweenEndNotFoundToEnd() => AreEqual(" stuff and something=result", "before stuff and something=result".Between("before", "not found", true));

    }
}
