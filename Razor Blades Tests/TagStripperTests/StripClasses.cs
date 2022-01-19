using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagStripperTests
{
  [TestClass]
  public class StripClassesAll
  {
    private string StripClasses(string original) => new TagStripper().Classes(original);

    [TestMethod]
    public void DoubleQuotes()
    {
      Assert.AreEqual("<div >", StripClasses("<div class=\"hello-world\">"));
    }

    [TestMethod]
    public void SingleQuotes()
    {
      Assert.AreEqual("<div >", StripClasses("<div class='hello-world'>"));
    }

    [TestMethod]
    public void NoQuotes()
    {
      Assert.AreEqual("<div >", StripClasses("<div class=hello-world>"));
    }

    [TestMethod]
    public void MultipleClassesDoubleQuotes()
    {
      Assert.AreEqual("<div >", StripClasses("<div class=\"hello-world bg-light\">"));
    }

    [TestMethod]
    public void MultipleClassesSingleQuotes()
    {
      Assert.AreEqual("<div >", StripClasses("<div class='hello-world bg-light'>"));
    }

    [TestMethod]
    public void MultipleClassesNoQuotes()
    //If the attribute is defined without any quotes there can only be one class the rest will be ignored
    {
      Assert.AreEqual("<div  bg-light>", StripClasses("<div class=hello-world bg-light>"));
    }

    [TestMethod]
    public void Normal()
    {
      Assert.AreEqual("<div style=\"hello-world shadow\" width=100 height=25 >", StripClasses("<div class=hello-world style=\"hello-world shadow\" class=\"color:blue display:none\" width=100 height=25 class='shadow:none'>"));
    }

    [TestMethod]
    public void OnlyAttribute()
    //If the attribute is defined without any quotes there can only be one class the rest will be ignored
    {
      Assert.AreEqual("<div >", StripClasses("<div class>"));
    }

    [TestMethod]
    public void EmptyStringClass()
    //If the attribute is defined without any quotes there can only be one class the rest will be ignored
    {
      Assert.AreEqual("<div >", StripClasses("<div class=\" \">"));
    }

    [TestMethod]
    public void LineBreaks()
    //If the attribute is defined without any quotes there can only be one class the rest will be ignored
    {
      Assert.AreEqual("<div >", StripClasses("<div class\n='\nhello-world \nbg-light'>"));
    }

    [TestMethod]
    public void InvalidQuotes()
     //In this case the attribute is defined wrong and can't be identified 
    {
      Assert.AreEqual("<div class=\"hello-world'>", StripClasses("<div class=\"hello-world'>"));
    }

    [TestMethod]
    public void InvalidQuotes2()
    //In this case the attribute is defined wrong and can't be identified 
    {
      Assert.AreEqual("<div class='hello-world>", StripClasses("<div class=\'hello-world>"));
    }
  }
}
