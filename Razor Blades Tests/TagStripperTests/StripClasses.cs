using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagStripperTests
{
  [TestClass]
  public class StripClassesAll
  {
    private string StripClasses(string original) => new TagStripper().Classes(original);

    [TestMethod]
    public void Normal()
    {
      Assert.AreEqual("<div >", StripClasses("<div class=\"hello-world\">"));
    }

    [TestMethod]
    public void Normal2()
    {
      Assert.AreEqual("<div >", StripClasses("<div class='hello-world'>"));
    }

    [TestMethod]
    public void Normal3()
    {
      Assert.AreEqual("<div >", StripClasses("<div class=hello-world>"));
    }
  }
}
