using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagStripperTests
{
  [TestClass]
  public class StripAttributesAll
  {
    private string StripAttributes(string original) => new TagStripper().Attributes(original);

    [TestMethod]
    public void Normal()
    {
      Assert.AreEqual("<div   >", StripAttributes("<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>"));
    }
  }
  public class StripAttributesOnlyOne
  {

  }
  public class StripAttributesOnlyMany
  {

  }
}
