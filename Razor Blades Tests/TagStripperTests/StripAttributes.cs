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

    [TestMethod]
    public void NewLine()
    {
      Assert.AreEqual("<div\n >", StripAttributes("<div\n style=\"backg\nround-\ncolor:\nblue\">"));
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
      Assert.AreEqual("<div >", StripAttributes("<div class='example'>", "class"));
    }

    [TestMethod]
    public void Normal3()
    {
      Assert.AreEqual("<div >", StripAttributes("<div class=\"example\">", "class"));
    }

    [TestMethod]
    public void DoubleSingleNoQuotes()
    {
      Assert.AreEqual("<div src='https://www...' width=100>", StripAttributes("<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>", "style"));
    }

    [TestMethod]
    public void DoubleSingleNoQuotes2()
    {
      Assert.AreEqual("<div style=\"background-color:blue; color: yellow;\" width=100>", StripAttributes("<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>", "src"));
    }

    [TestMethod]
    public void DoubleSingleNoQuotes3()
    {
      Assert.AreEqual("<div style=\"background-color:blue; color: yellow;\" src='https://www...' >", StripAttributes("<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>", "width"));
    }

    [TestMethod]
    public void InvalidAttributes()
    {
      Assert.AreEqual("<div style=\"background-color:blue'>", StripAttributes("<div style=\"background-color:blue'>", "style"));
    }

    [TestMethod]
    public void NewLine()
    {
      Assert.AreEqual("<div\n >", StripAttributes("<div\n style=\"backg\nround-\ncolor:\nblue\">", "style"));
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
    public void MultipleAttributes()
    {
      string[] testAttributes = { "class", "href" };
      Assert.AreEqual("<div style='color:blue'>", StripAttributes("<div class=\"hello-world\" href=https:\\... style='color:blue'>", testAttributes));
    }

    [TestMethod]
    public void InvalidAttributes()
    {
      string[] testAttributes = { "style" };
      Assert.AreEqual("<div style=\"background-color:blue'>", StripAttributes("<div style=\"background-color:blue'>", testAttributes));
    }

    [TestMethod]
    public void NewLine()
    {
      string[] testAttributes = { "style" };
      Assert.AreEqual("<div\n >", StripAttributes("<div\n style=\"backg\nround-\ncolor:\nblue\">", testAttributes));
    }
  }
}
