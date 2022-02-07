﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace ToSic.RazorBladeTests.ScrubTests
{
    //Tests for TagStripper().Attributes(string original)
    [TestClass]
    public class StripAttributesAll: ScrubBase
    {
        private string StripAttributes(string original) => GetService<IScrub>().Attributes(original);

        [TestMethod]
        public void Normal()
        {
            Assert.AreEqual("<div >", StripAttributes("<div class=example>"));
        }

        [TestMethod]
        public void MultipleAttributeOnSameTag()
        {
            Assert.AreEqual("<div>", StripAttributes("<div class='example' class='example'>"));
        }

        [TestMethod]
        public void MultipleAttributeOnManyTags()
        {
            Assert.AreEqual("<div ></div><div ></div>", StripAttributes("<div class='example'></div><div class='example'></div>"));
        }

        [TestMethod]
        public void Normal2()
        {
            string[] testAttributes = { "class" };
            Assert.AreEqual("<div >", StripAttributes("<div class='example'>"));
        }

        [TestMethod]
        public void Normal3()
        {
            string[] testAttributes = { "class" };
            Assert.AreEqual("<div >", StripAttributes("<div class=\"example\">"));
        }

        [TestMethod]
        public void Normal4()
        {
            Assert.AreEqual("<div>", StripAttributes("<div style=\"background-color:blue; color: yellow;\" src='https://www...' width=100>"));
        }

        [TestMethod]
        public void InvalidAttributes()
        {
            Assert.AreEqual("<div style=\"background-color:blue'>", StripAttributes("<div style=\"background-color:blue'>"));
        }

        [TestMethod]
        public void NewLine()
        {
            Assert.AreEqual("<div\n >", StripAttributes("<div\n style=\"backg\nround-\ncolor:\nblue\">"));
        }

        [TestMethod]
        public void OnlyAttribute()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div >", StripAttributes("<div class>"));
        }

        [TestMethod]
        public void EmptyStringClass()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div >", StripAttributes("<div class=\" \">"));
        }

        [TestMethod]
        public void AttributeNameWithMinus1()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div >", StripAttributes("<div hello-world>"));
        }

        [TestMethod]
        public void AttributeNameWithMinus2()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div >", StripAttributes("<div hello-world=\"\">"));
        }

        [TestMethod]
        public void AttributeNameWithMinus3()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div >", StripAttributes("<div hello-world=''>"));
        }

        [TestMethod]
        public void AttributeNameWithMinus4()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div >", StripAttributes("<div hello-world=hello>"));
        }

        [TestMethod]
        public void AttributesWithDashNoQuotes()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div ><div ><div ><div =f>", StripAttributes("<div hello=f><div hello-world=f><div hello-small-world=f><div =f>"));
        }

        [TestMethod]
        public void AttributesWithDashSingleQuotes()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div ><div ><div >", StripAttributes("<div hello=''><div hello-world=''><div hello-small-world='hello-world'>"));
        }

        [TestMethod]
        public void AttributesWithDashDoubleQuotes()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div ><div ><div >", StripAttributes("<div hello=\"\"><div hello-world=\"\"><div hello-small-world=\"\">"));
        }

        [TestMethod]
        public void AttributesWithDashOnlyDefined()
        //If the attribute is defined without any quotes there can only be one class the rest will be ignored
        {
            Assert.AreEqual("<div > <div > <div >", StripAttributes("<div hello> <div hello-world> <div hello-small-world-and-big-world>"));
        }
    }
}

