﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.TextTests
{
  [TestClass]
  public class StripHtmlAll
  {
    [TestMethod]
    public void Basic()
    {
      Assert.AreEqual("Hello there", Text.StripTags("<h1>Hello</h1><strong> there</strong>"));
    }

    [TestMethod]
    public void MultiLine()
    {
      Assert.AreEqual("Hello there", Text.StripTags(@"<h1>
Hello
</h1>
<strong>
there
</strong>"));
    }

    [TestMethod]
    public void MultiLineTag()
    {
      Assert.AreEqual("Hello there", Text.StripTags(@"<h1>
Hello
</h1>
<strong
  class='something'
  onclick='someJs'>
there
</strong>"));
    }
    [TestMethod]
    public void NullCheck()
    {
      Assert.AreEqual(null, Text.StripTags(null));
    }

    [TestMethod]
    public void Test_StripHtml()
    {
        var html = "<div>some text with valid html</div>";
        var clean = "some text with valid html";
        var strip = Text.StripTags(html);

        Assert.AreEqual(clean, strip, "should be the same");
    }
    }
}
