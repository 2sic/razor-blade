using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToSic.Razor.Blade;

namespace Razor_Blades_Tests.TagsTests
{
  [TestClass]
  public class StripTestsTagArray 
  {
    [TestMethod]
    public void Normal1()
    {
      string[] testTags = {"a"};
      Assert.AreEqual("<div>Hello World</div>", Tags.Strip("<div>Hello <a>World</a></div>", testTags ));
    }

    [TestMethod]
    public void Normal2()
    {
      string[] testTags = { "p", "a"};
      Assert.AreEqual("<div>HelloWorld</div>", Tags.Strip("<div><p>Hello</p><a>World</a></div>", testTags));
    }

    [TestMethod]
    public void Normal3()
    {
      string[] testTags = { "p", "a" , "body", "div", "span"};
      Assert.AreEqual("<html>Hello World</html>", Tags.Strip("<html><body><div><span>Hello</span> <a>World</a><div></body></html>", testTags));
    }

    [TestMethod]
    public void Normal4()
    {
      string[] testTags = {"br","p"};
      Assert.AreEqual("Hello World", Tags.Strip("Hello</p> </br>World", testTags));
    }

    [TestMethod]
    public void EmptyArray()
    {
      string[] testTags = {};
      Assert.AreEqual("<div>Hello World</div>", Tags.Strip("<div>Hello World</div>", testTags));
    }

    [TestMethod]
    public void ArrayWithEmptyStrings()
    {
      string[] testTags = {"", " ", "  "};
      Assert.AreEqual("<div>Hello World</div>", Tags.Strip("<div>Hello World</div>", testTags));
    }

    [TestMethod]
    public void ArrayWithUnnecessaryStrings()
    {
      string[] testTags = { "div", "a" };
      Assert.AreEqual("Hello", Tags.Strip("<div>Hello</div>", testTags));
    }

    [TestMethod]
    public void ArrayWithWeirdInput()
    {
      string[] testTags = { "div", "4x5" };
      Assert.AreEqual("Hello", Tags.Strip("<div>Hello</div>", testTags));
    }

    [TestMethod]
    public void TagsWithAttributes()
    {
      string[] testTags = { "div", "a"};
      Assert.AreEqual("Hello small World", Tags.Strip("<div style=\"background-color: blue; padding:0\" href=\"https//:www...\">Hello<a style=\"background-color:black;\"> small </a>World</div>", testTags));
    }

    [TestMethod]
    public void TagsWithAttributes2()
    {
      string[] testTags = { "div" };
      Assert.AreEqual("", Tags.Strip("<div style\n=\"background-color: blue;\n padding:0\"\n href=\"https//:www...\"\n>", testTags));
    }

    [TestMethod]
    public void Special()
    //This test is expected to leave some > and < behind because they don't belong to the actuall tags
    {
      string[] testTags = { "body", "a" };
      Assert.AreEqual("<Hello <there<>", Tags.Strip("<<body>Hello <<a>there<</a></body>>", testTags));
    }

    [TestMethod]
    public void WrongTag()
    //Tag.Strip can't detect that this isn't a valid tag and delets it anyway
    {
      string[] testTags = { "p", "a" };
      Assert.AreEqual("", Tags.Strip("</p/></p><p/><p></a/></a><a/><a>", testTags));
    }

  }
}
