using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagStripperTests
{
  [TestClass]
  public class StripStylesAll
  {
    private string StripStyles(string original) => new TagStripper().Styles(original);

    [TestMethod]
    public void DoubleQuotes()
    {
      Assert.AreEqual("<div >", StripStyles("<div style=\"hello-world\">"));
    }

    [TestMethod]
    public void SingleQuotes()
    {
      Assert.AreEqual("<div >", StripStyles("<div style='hello-world'>"));
    }

    [TestMethod]
    public void NoQuotes()
    {
      Assert.AreEqual("<div >", StripStyles("<div style=hello-world>"));
    }

    [TestMethod]
    public void Normal()
    {
      Assert.AreEqual("<div class=\"hello-world shadow\" width=100 height=25 >", StripStyles("<div style=hello-world class=\"hello-world shadow\" style=\"color:blue display:none\" width=100 height=25 style='shadow:none'>"));
    }

    [TestMethod]
    public void MultipleClassesDoubleQuotes()
    {
      Assert.AreEqual("<div >", StripStyles("<div style=\"hello-world bg-light\">"));
    }

    [TestMethod]
    public void MultipleClassesSingleQuotes()
    {
      Assert.AreEqual("<div >", StripStyles("<div style='hello-world bg-light'>"));
    }

    [TestMethod]
    public void MultipleClassesNoQuotes()
    //If the attribute is defined without any quotes there can only be one class the rest will be ignored
    {
      Assert.AreEqual("<div  bg-light>", StripStyles("<div style=hello-world bg-light>"));
    }

    [TestMethod]
    public void OnlyAttribute()
    //If the attribute is defined without any quotes there can only be one class the rest will be ignored
    {
      Assert.AreEqual("<div >", StripStyles("<div style>"));
    }

    [TestMethod]
    public void EmptyStringClass()
    //If the attribute is defined without any quotes there can only be one class the rest will be ignored
    {
      Assert.AreEqual("<div >", StripStyles("<div style=\" \">"));
    }

    [TestMethod]
    public void LineBreaks()
    //If the attribute is defined without any quotes there can only be one class the rest will be ignored
    {
      Assert.AreEqual("<div >", StripStyles("<div style\n='\nhello-world \nbg-light'>"));
    }

    [TestMethod]
    public void InvalidQuotes()
     //In this case the attribute is defined wrong and can't be identified 
    {
      Assert.AreEqual("<div style=\"hello-world'>", StripStyles("<div style=\"hello-world'>"));
    }

    [TestMethod]
    public void InvalidQuotes2()
    //In this case the attribute is defined wrong and can't be identified 
    {
      Assert.AreEqual("<div style='hello-world>", StripStyles("<div style=\'hello-world>"));
    }
  }
}
