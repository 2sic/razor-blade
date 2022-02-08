using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    //Tests for TagStripper().Attributes(string original)
    [TestClass]
    public class StripAttributesAll: ScrubBase
    {
        private string StripAttributes(string original) => GetService<IScrub>().Attributes(original);
        private void TestStripOnly(string expected, string original)
            => Assert.AreEqual(expected, GetService<IScrub>().Attributes(original));

        private void TestStripUnchanged(string original) => TestStripOnly(original, original);

        [TestMethod]
        public void NormalNoQuotes() => TestStripOnly("<div >", "<div class=example>");

        [TestMethod]
        public void NormalSingleQuotes() => TestStripOnly("<div >", "<div class='example'>");

        [TestMethod]
        public void NormalDoubleQuotes() => TestStripOnly("<div >", "<div class=\"example\">");

        [TestMethod]
        public void NormalOnlyDeclared() => TestStripOnly("<div >", "<div class>");

        [TestMethod]
        public void MultipleAttributeOnSameTag() => TestStripOnly("<div>", "<div class='example' class='example'>");

        [TestMethod]
        public void MultipleAttributeOnManyTags() => TestStripOnly("<div ></div><div ></div>", "<div class='example'></div><div class='example'></div>");

        [TestMethod]
        public void DoubleSingleNoQuotesOnlyDeclared() => TestStripOnly("<div>", "<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100 class>");

        [TestMethod]
        public void InvalidAttributes() => TestStripUnchanged("<div style=\"background-color:blue'>");

        [TestMethod]
        public void NewLine() => TestStripOnly("<div\n >", "<div\n style=\"backg\nround-\ncolor:\nblue\">");

        [TestMethod]
        public void EmptyStringAttribute() => TestStripOnly("<div >", "<div class=\" \">");

        [TestMethod]
        public void AttributesWithDashNoQuotes() => TestStripOnly("<div ><div ><div ><div =f>", "<div hello=f><div hello-world=f><div hello-small-world=f><div =f>");

        [TestMethod]
        public void AttributesWithDashSingleQuotes() => TestStripOnly("<div ><div ><div >", "<div hello=''><div hello-world=''><div hello-small-world='hello-world'>");

        [TestMethod]
        public void AttributesWithDashDoubleQuotes() => TestStripOnly("<div ><div ><div >", "<div hello=\"\"><div hello-world=\"\"><div hello-small-world=\"\">");

        [TestMethod]
        public void AttributesWithDashOnlyDefined() => TestStripOnly("<div ><div ><div >", "<div hello><div hello-world><div hello-small-world-and-big-world>");
    }
}

