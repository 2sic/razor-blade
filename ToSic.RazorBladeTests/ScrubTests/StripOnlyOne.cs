using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    // Tests for the optional input
    [TestClass]
    public class StripOnlyOne: ScrubBase
    {
        private string StripOnly(string original, string tag) => GetService<IScrub>().Only(original, tag);

        private void TestStripOnlyOne(string expected, string original, string tag)
            => Assert.AreEqual(expected, GetService<IScrub>().Only(original, tag));

        private void TestStripUnchanged(string original, string tag) => TestStripOnlyOne(original, original, tag);

        [TestMethod]
        public void Normal() => TestStripOnlyOne("Hello", "<body>Hello</body>", "body");

        [TestMethod]
        public void Normal2() => TestStripOnlyOne("<p> Hello </p>", "<body><p> Hello </p></body>", "body");

        [TestMethod]
        public void Normal3() => TestStripOnlyOne("This is just", "This <b><b></b><b>is</b></b> just", "b");

        [TestMethod]
        public void Normal4() => TestStripOnlyOne("List: <ol>FirstSecond<ul>ThirdFourth</ul></ol>", "List: <ol><li>First</li><li>Second</li><ul><li>Third</li><li>Fourth</li></ul></ol>", "li");

        [TestMethod]
        public void SimilarTags() => TestStripOnlyOne("This <b>is</b> just an example", "This <b>is</b> just<br> an example", "br");

        [TestMethod]
        public void TwoOpeningTags() => TestStripOnlyOne("Hello world", "<b>Hello<b> world", "b");

        [TestMethod]
        public void LineBreak1() => TestStripOnlyOne("", "<p \n >", "p");

        [TestMethod]
        //Since there are LineBreaks where there are none allowed this tag won't be stripped
        public void LineBreak2() => TestStripUnchanged("<\np>", "p");

        [TestMethod]
        //Since there are LineBreaks where there are none allowed this tag won't be stripped
        public void LineBreak3() => TestStripUnchanged("</\np>", "p");

        [TestMethod]
        public void LineBreak4() => TestStripOnlyOne("", "<p \n /></p \n>", "p");

        [TestMethod]
        public void SelfClosingTags() => TestStripOnlyOne("Hello", "Hello<br/>", "br");

        [TestMethod]
        public void TagWithSpaces() => TestStripOnlyOne("Hello", "<p    >Hello</p   ><p   />", "p");

        [TestMethod]
        //These tags are not valid and are not stripped for that reason
        public void TagWithSpaces2() => TestStripUnchanged("< p>< /p></ p>< / p>", "p");

        [TestMethod]
        //This test is an example where it should fail to delete the invalid tags
        public void TagsWithSpaces3() => TestStripOnlyOne("<br/ ><br / >", "<br/><br /><br/ ><br / >", "br");

        [TestMethod]
        public void Special() => TestStripOnlyOne("<Hello there>", "<<body>Hello there</body>>", "body");

        [TestMethod]
        public void TagWithAttributes() => TestStripOnlyOne("", "<p style=\"background-color:blue\">", "p");

        [TestMethod]
        public void TagWithAttributes2() => TestStripOnlyOne("", "<p style=background-color:blue>", "p");

        [TestMethod]
        public void TagWithAttributes3() => TestStripOnlyOne("", "<p style=\"background-color:blue; padding: 0\" href=\"https://www.w3schools.com\">", "p");

        [TestMethod]
        public void TagWithAttributes4() => TestStripOnlyOne("", "<p style=\"background-color:blue; padding: 0\" \n href=\"https://www.w3schools.com\">", "p");

        [TestMethod]
        public void TagWithAttributes5() => TestStripOnlyOne("", "<p style=\"background-color:blue; padding: 0\"                     href=\"https://www.w3schools.com\"\n>", "p");

        [TestMethod]
        //These tags can't be detect as invalid HTMl and are deleted anyway
        public void WrongTag() => TestStripOnlyOne("", "</p />", "p");
    }
}
