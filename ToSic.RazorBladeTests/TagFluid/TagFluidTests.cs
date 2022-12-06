using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.RazorBladeTests.TagTests;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ToSic.RazorBladeTests.TagFluid
{
    [TestClass]
    public class TagFluidTests: TagTestBase
    {
        [TestMethod]
        public void NonFluidAreEqual()
        {
            var divNonFluid = new Div { TagIsFluid = false };
            var divWrap = divNonFluid.Wrap("hello");
            AreEqual(divNonFluid, divWrap);
            Is("<div>hello</div>", divWrap);
        }

        [TestMethod]
        public void FluidAreNotEqual()
        {
            var divNonFluid = new Div();
            var divWrap = divNonFluid.Wrap("hello");
            AreNotEqual(divNonFluid, divWrap);
            Is("<div>hello</div>", divWrap);
        }

    }
}
