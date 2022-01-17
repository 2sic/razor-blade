using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToSic.Razor.Blade;

namespace Razor_Blades_Tests.TagsTests
{
  [TestClass]
  public class StripTests
  {
    [TestMethod]
    public void Basic()
    {
      Assert.AreEqual("Hello there", Tags.Strip("<h1>Hello</h1><strong> there</strong>"));
    }

    [TestMethod]
    public void NullCheck()
    {
      Assert.AreEqual(null, Tags.Strip(null));
    }
  }
}
