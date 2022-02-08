using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    //Tests for TagStripper().Attributes(string original, string attribute)
    [TestClass]
    public class StripAttributesOnlyOne: ScrubBase
    {
        string StripAttributes(string original, string attribute) => GetService<IScrub>().Attributes(original, attribute);
        
        private void TestStripOnly(string expected, string original, string attribute) 
            => Assert.AreEqual(expected, GetService<IScrub>().Attributes(original, attribute));
        
        private void TestStripUnchanged(string original, string attribute) => TestStripOnly(original, original, attribute);

        [TestMethod]
        public void NormalNoQuotes() => TestStripOnly("<div >", "<div class=example>", "class");

        [TestMethod]
        public void NormalSingleQuotes() => TestStripOnly("<div >", "<div class='example'>", "class");

        [TestMethod]
        public void NormalDoubleQuotes() => TestStripOnly("<div >", "<div class=\"example\">", "class");

        [TestMethod]
        public void DoubleSingleNoQuotes() => TestStripOnly("<div src='https://www...' width=100>", "<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>", "style");

        [TestMethod]
        public void DoubleSingleNoQuotes2() => TestStripOnly("<div style=\"background-color:blue; color: yellow;\" width=100>", "<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>", "src");

        [TestMethod]
        public void DoubleSingleNoQuotes3() => TestStripOnly("<div style=\"background-color:blue; color: yellow;\" src='https://www...' >", "<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>", "width");

        [TestMethod]
        public void InvalidAttributes() => TestStripUnchanged("<div style=\"background-color:blue'>", "style");

        [TestMethod]
        public void NewLine() => TestStripOnly("<div\n >", "<div\n style=\"backg\nround-\ncolor:\nblue\">", "style");

        [TestMethod]
        public void OnlyAttribute() => TestStripOnly("<div ><span ><p >", "<div class><span class><p class>", "class");

        [TestMethod]
        //While this example isn't valid HTML because an attribute can only be declared once inside the same Tag
        //it will still delete all instances
        public void OnlyAttributeMultipleInstances() => TestStripOnly("<div>", "<div class class class class>", "class");

        [TestMethod]
        public void EmptyStringClass() => TestStripOnly("<div >", "<div class=\" \">", "class");

        [TestMethod]
        public void AttributeNameWithMinus() => TestStripOnly("<div >", "<div hello-world=hello>", "hello-world");

        [TestMethod]
        public void AttributeNameWithMinusNotFound() => TestStripUnchanged("<div hello-world=hello>", "world-hello");

        [TestMethod]
        public void AttributeNameWithMinusAlternateCase() => TestStripOnly("<div >", "<div HELLO-world=hello>", "hello-world");

        [TestMethod]
        public void AttributeNameWithMinusAlternateCaseNotFound() => TestStripUnchanged("<div HELLO-world=hello>", "world-HELLO");
    }
}
