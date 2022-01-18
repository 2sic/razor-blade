using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagStripperTests
{
  [TestClass]
  public class Except
  {
    private string StripExcept(string original, params string[] tags) => new TagStripper().Except(original, tags);
    
    [TestMethod]
    public void Normal1()
    {
      string[] testTags = { "div" };
      Assert.AreEqual("<div>Hello small World</div>", StripExcept("<div>Hello <p>small</p> World</div>", testTags));
    }

    [TestMethod]
    public void Normal2()
    {
      string[] testTags = { "div", "a" };
      Assert.AreEqual("<div>Hello <a>small</a> World</div>", StripExcept("<div>Hello <p><a>small</a></p> World</div>", testTags));
    }

    [TestMethod]
    public void Normal3()
    {
      string[] testTags = { "div", "a", "b" };
      Assert.AreEqual("<div>This<a> is </a></div><div><b>an </b>Example</div>", StripExcept("<body><div>This<a> is </a></div></br><div><b>an </b>Example</div></body>", testTags));
    }

  }
}
