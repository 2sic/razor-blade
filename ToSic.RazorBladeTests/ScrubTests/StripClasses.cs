using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    [TestClass]
    public class StripClassesAll: ScrubBase
    {
        private string StripClasses(string original) => GetService<IScrub>().Classes(original);

        private void TestStripClasses(string expected, string original)
            => Assert.AreEqual(expected, GetService<IScrub>().Classes(original));

        private void TestStripUnchanged(string original) => TestStripClasses(original, original);

        [TestMethod]
        public void DoubleQuotes() => TestStripClasses("<div >", "<div class=\"hello-world\">");

        [TestMethod]
        public void SingleQuotes() => TestStripClasses("<div >", "<div class='hello-world'>");

        [TestMethod]
        public void NoQuotes() => TestStripClasses("<div >", "<div class=hello-world>");

        [TestMethod]
        public void MultipleClassesDoubleQuotes() => TestStripClasses("<div >", "<div class=\"hello-world bg-light\">");

        [TestMethod]
        public void MultipleClassesSingleQuotes() => TestStripClasses("<div >", "<div class='hello-world bg-light'>");

        [TestMethod]
        public void MultipleClassesNoQuotes() => TestStripClasses("<div  bg-light>", "<div class=hello-world bg-light>");

        [TestMethod]
        public void Normal() => TestStripClasses("<div style=\"hello-world shadow\" width=100 height=25 >", "<div class=hello-world style=\"hello-world shadow\" class=\"color:blue display:none\" width=100 height=25 class='shadow:none'>");

        [TestMethod]
        public void OnlyAttribute() => TestStripClasses("<div >", "<div class>");

        [TestMethod]
        public void EmptyStringClass() => TestStripClasses("<div >", "<div class=\" \">");

        [TestMethod]
        public void LineBreaks() => TestStripClasses("<div >", "<div class\n='\nhello-world \nbg-light'>");

        [TestMethod]
        //In this case the class attribute is defined wrong and can't be identified 
        public void InvalidQuotes() => TestStripUnchanged("<div class=\"hello-world'>");

        [TestMethod]
        //In this case the class attribute is defined wrong and can't be identified 
        public void InvalidQuotes2() => TestStripUnchanged("<div class=\'hello-world>");
    }
}
