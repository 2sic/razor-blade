using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TagStripperTests
{
  // Tests for the optional input
  [TestClass]
  public class StripOnlyOne
  {
    private static string StripOnly(string original, string tag) => new TagStripper().Only(original, tag);

    [TestMethod]
    public void Normal()
    {
      Assert.AreEqual("Hello", StripOnly("<body>Hello</body>", "body"));
    }

    [TestMethod]
    public void Normal2()
    {
      Assert.AreEqual("<p> Hello </p>", StripOnly("<body><p> Hello </p></body>", "body"));
    }

    [TestMethod]
    public void Normal3()
    {
      Assert.AreEqual("This is just", StripOnly("This <b><b></b><b>is</b></b> just", "b"));
    }

    [TestMethod]
    public void Normal4()
    {
      Assert.AreEqual("List: <ol>FirstSecond<ul>ThirdFourth</ul></ol>", StripOnly("List: <ol><li>First</li><li>Second</li><ul><li>Third</li><li>Fourth</li></ul></ol>", "li"));
    }

    [TestMethod]
    public void SimilarTags()
    {
      Assert.AreEqual("This <b>is</b> just an example", StripOnly("This <b>is</b> just<br> an example", "br"));
    }

    [TestMethod]
    public void TwoOpeningTags()
    {
      Assert.AreEqual("Hello world", StripOnly("<b>Hello<b> world", "b"));
    }

    [TestMethod]
    public void LineBreak1()
    {
      Assert.AreEqual("", StripOnly("<p \n >", "p"));
    }

    [TestMethod]
    public void LineBreak2()
    {
      Assert.AreEqual("<\np>", StripOnly("<\np>", "p"));
    }

    [TestMethod]
    public void LineBreak3()
    {
      Assert.AreEqual("</\np>", StripOnly("</\np>", "p"));
    }

    [TestMethod]
    public void LineBreak4()
    {
      Assert.AreEqual("", StripOnly("<p \n /></p \n>", "p"));
    }

    [TestMethod]
    public void SelfClosingTags()
    {
      Assert.AreEqual("Hello", StripOnly("Hello<br/>", "br"));
    }

    [TestMethod]
    public void TagWithSpaces()
    {
      Assert.AreEqual("Hello", StripOnly("<p    >Hello</p   ><p   />", "p"));
    }

    [TestMethod]
    public void TagWithSpaces2()
    //This test is an example where Tag.Strip should fail
    {
      Assert.AreEqual("< p>< /p></ p>< / p>", StripOnly("< p>< /p></ p>< / p>", "p"));
    }

    [TestMethod]
    public void TagsWithSpaces3()
    //This test is an example where Tag.Strip should fail to delete some of the tags
    {
      Assert.AreEqual("<br/ ><br / >", StripOnly("<br/><br /><br/ ><br / >", "br"));
    }

    [TestMethod]
    public void Special()
    {
      Assert.AreEqual("<Hello there>", StripOnly("<<body>Hello there</body>>", "body"));
    }

    [TestMethod]
    public void TagWithAttributes()
    {
      Assert.AreEqual("", StripOnly("<p style=\"background-color:blue\">", "p"));
    }

    [TestMethod]
    public void TagWithAttributes2()
    {
      Assert.AreEqual("", StripOnly("<p style=background-color:blue>", "p"));
    }

    [TestMethod]
    public void TagWithAttributes3()
    {
      Assert.AreEqual("", StripOnly("<p style=\"background-color:blue; padding: 0\" href=\"https://www.w3schools.com\">", "p"));
    }

    [TestMethod]
    public void TagWithAttributes4()
    {
      Assert.AreEqual("", StripOnly("<p style=\"background-color:blue; padding: 0\" \n href=\"https://www.w3schools.com\">", "p"));
    }

    [TestMethod]
    public void TagWithAttributes5()
    {
      Assert.AreEqual("", StripOnly("<p style=\"background-color:blue; padding: 0\"                     href=\"https://www.w3schools.com\"\n>", "p"));
    }

    [TestMethod]
    public void WrongTag()
    //Tag.Strip can't detect that this isn't a valid tag and delets it anyway
    {
      Assert.AreEqual("", StripOnly("</p />", "p"));
    }
  }
}
