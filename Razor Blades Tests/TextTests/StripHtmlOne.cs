using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace Razor_Blades_Tests.TextTests
{
  [TestClass]
  public class StripHtmlOne 
  {
    [TestMethod]
    public void Normal1()
    {
      string[] testTags = {"a"};
      Assert.AreEqual("<div>Hello World</div>", Text.StripTags("<div>Hello <a>World</a></div>", testTags ));
    }

    [TestMethod]
    public void Normal2()
    {
      string[] testTags = { "p", "a"};
      Assert.AreEqual("<div>HelloWorld</div>", Text.StripTags("<div><p>Hello</p><a>World</a></div>", testTags));
    }

    [TestMethod]
    public void Normal3()
    {
      string[] testTags = { "p", "a" , "body", "div", "span"};
      Assert.AreEqual("<html>Hello World</html>", Text.StripTags("<html><body><div><span>Hello</span> <a>World</a><div></body></html>", testTags));
    }

    [TestMethod]
    public void Normal4()
    {
      string[] testTags = {"br","p"};
      Assert.AreEqual("Hello World", Text.StripTags("Hello</p> </br>World", testTags));
    }

    [TestMethod]
    public void EmptyArray()
    {
      string[] testTags = {};
      Assert.AreEqual("<div>Hello World</div>", Text.StripTags("<div>Hello World</div>", testTags));
    }

    [TestMethod]
    public void ArrayWithEmptyStrings()
    {
      string[] testTags = {"", " ", "  "};
      Assert.AreEqual("<div>Hello World</div>", Text.StripTags("<div>Hello World</div>", testTags));
    }

    [TestMethod]
    public void ArrayWithUnnecessaryStrings()
    {
      string[] testTags = { "div", "a" };
      Assert.AreEqual("Hello", Text.StripTags("<div>Hello</div>", testTags));
    }

    [TestMethod]
    public void ArrayWithWeirdInput()
    {
      string[] testTags = { "div", "4x5" };
      Assert.AreEqual("Hello", Text.StripTags("<div>Hello</div>", testTags));
    }

    [TestMethod]
    public void TagsWithAttributes()
    {
      string[] testTags = { "div", "a"};
      Assert.AreEqual("Hello small World", Text.StripTags("<div style=\"background-color: blue; padding:0\" href=\"https//:www...\">Hello<a style=\"background-color:black;\"> small </a>World</div>", testTags));
    }

    [TestMethod]
    public void TagsWithAttributes2()
    {
      string[] testTags = { "div" };
      Assert.AreEqual("", Text.StripTags("<div style\n=\"background-color: blue;\n padding:0\"\n href=\"https//:www...\"\n>", testTags));
    }

    [TestMethod]
    public void Special()
    //This test is expected to leave some > and < behind because they don't belong to the actuall tags
    {
      string[] testTags = { "body", "a" };
      Assert.AreEqual("<Hello <there<>", Text.StripTags("<<body>Hello <<a>there<</a></body>>", testTags));
    }

    [TestMethod]
    public void WrongTag()
    //Tag.Strip can't detect that this isn't a valid tag and delets it anyway
    {
      string[] testTags = { "p", "a" };
      Assert.AreEqual("", Text.StripTags("</p/></p><p/><p></a/></a><a/><a>", testTags));
    }

  }
}
