using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    [TestClass]
    public class StripStylesAll: ScrubBase
    {
        private string StripStyles(string original) => GetService<IScrub>().Styles(original);

        private void TestStripStyles(string expected, string original)
            => Assert.AreEqual(expected, GetService<IScrub>().Styles(original));

        private void TestStripUnchanged(string original) => TestStripStyles(original, original);

        [TestMethod]
        public void DoubleQuotes() => TestStripStyles("<div >", "<div style=\"hello-world\">");

        [TestMethod]
        public void SingleQuotes() => TestStripStyles("<div >", "<div style='hello-world'>");

        [TestMethod]
        public void NoQuotes() => TestStripStyles("<div >", "<div style=hello-world>");

        [TestMethod]
        public void Normal() => TestStripStyles("<div class=\"hello-world shadow\" width=100 height=25 >", "<div style=hello-world class=\"hello-world shadow\" style=\"color:blue display:none\" width=100 height=25 style='shadow:none'>");

        [TestMethod]
        public void MultipleClassesDoubleQuotes() => TestStripStyles("<div >", "<div style=\"hello-world bg-light\">");

        [TestMethod]
        public void MultipleClassesSingleQuotes() => TestStripStyles("<div >", "<div style='hello-world bg-light'>");


        [TestMethod]
        public void MultipleClassesNoQuotes() => TestStripStyles("<div  bg-light>", "<div style=hello-world bg-light>");

        [TestMethod]
        public void OnlyAttribute() => TestStripStyles("<div >", "<div style>");

        [TestMethod]
        public void EmptyStringStylesAttribute() => TestStripStyles("<div >", "<div style=\" \">");

        [TestMethod]
        public void LineBreaks() => TestStripStyles("<div >", "<div style\n='\nhello-world \nbg-light'>");

        [TestMethod]
        //In this case the style attribute is defined wrong and can't be identified 
        public void InvalidQuotes() => TestStripUnchanged("<div style=\"hello-world'>");
        
        [TestMethod]
        //In this case the style attribute is defined wrong and can't be identified 
        public void InvalidQuotes2() => TestStripUnchanged("<div style=\'hello-world>");
    }
}
