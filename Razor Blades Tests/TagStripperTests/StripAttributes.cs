using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagStripperTests
{
  //Tests for TagStripper().Attributes(string original)
  [TestClass]
  public class StripAttributesAll
  {
    private string StripAttributes(string original) => new TagStripper().Attributes(original);

    [TestMethod]
    public void Normal()
    {
      Assert.AreEqual("<div >", StripAttributes("<div class=example>"));
    }

    [TestMethod]
    public void Normal2()
    {
      string[] testAttributes = { "class" };
      Assert.AreEqual("<div >", StripAttributes("<div class='example'>"));
    }

    [TestMethod]
    public void Normal3()
    {
      string[] testAttributes = { "class" };
      Assert.AreEqual("<div >", StripAttributes("<div class=\"example\">"));
    }

    [TestMethod]
    public void Normal4()
    {
      Assert.AreEqual("<div>", StripAttributes("<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>"));
    }

    [TestMethod]
    public void InvalidAttributes()
    {
      Assert.AreEqual("<div style=\"background-color:blue'>", StripAttributes("<div style=\"background-color:blue'>"));
    }
  }

  //Tests for TagStripper().Attributes(string original, string attribute)
  [TestClass]
  public class StripAttributesOnlyOne
  {
    string StripAttributes(string original, string attribute) => new TagStripper().Attributes(original, attribute);

    [TestMethod]
    public void Normal()
    {
      Assert.AreEqual("<div >", StripAttributes("<div class=example>", "class"));
    }

    [TestMethod]
    public void Normal2()
    {
      string[] testAttributes = { "class" };
      Assert.AreEqual("<div >", StripAttributes("<div class='example'>", "class"));
    }

    [TestMethod]
    public void Normal3()
    {
      string[] testAttributes = { "class" };
      Assert.AreEqual("<div >", StripAttributes("<div class=\"example\">", "class"));
    }
  }

  //Tests for TagStripper().Attributes(string original, params string[] attributes)
  [TestClass]
  public class StripAttributesOnlyMany
  {
    string StripAttributes(string original, params string[] attributes) => new TagStripper().Attributes(original, attributes);

    [TestMethod]
    public void Normal()
    {
      string[] testAttributes = { "class", "href" };
      Assert.AreEqual("<div ><a >", StripAttributes("<div class=\"example\"><a href='https:...'>", testAttributes));
    }

    [TestMethod]
    public void ManyAttributes()
    {
      string[] testAttributes = { "class", "href" };
      Assert.AreEqual("", StripAttributes("<div >", testAttributes));
    }
  }
}
