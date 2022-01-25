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
    public void MultipleAttributeOnSameTag()
    {
      Assert.AreEqual("<div>", StripAttributes("<div class='example' class='example'>"));
    }

    [TestMethod]
    public void MultipleAttributeOnManyTags()
    {
      Assert.AreEqual("<div ></div><div ></div>", StripAttributes("<div class='example'></div><div class='example'></div>"));
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

    [TestMethod]
    public void OnlyAttribute()
    //If the attribute is defined without any quotes there can only be one class the rest will be ignored
    {
      Assert.AreEqual("<div >", StripAttributes("<div class>"));
    }

    [TestMethod]
    public void EmptyStringClass()
    //If the attribute is defined without any quotes there can only be one class the rest will be ignored
    {
      Assert.AreEqual("<div >", StripAttributes("<div class=\" \">"));
    }
  }
}

