using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Markup;

namespace ToSic.RazorBladeTests.TagBuilderTests
{
    [TestClass]
    public class AttributeBuilderTests
    {
        [TestMethod]
        public void BasicAttributes()
        {
            Assert.AreEqual("name='value'", new Attribute("name", "value").ToString());
            Assert.AreEqual("something='other'", new Attribute("something", "other").ToString());
        }

        [TestMethod]
        public void BasicAttributesQuote()
        {
            var options = new AttributeOptions(quote: "\"");
            Assert.AreEqual("name=\"value\"", 
                new Attribute("name", "value", options).ToString());
            Assert.AreEqual("something=\"other\"",
                new Attribute("something", "other", options).ToString());
        }

        [TestMethod]
        public void UnEncodeQuote()
        {
            var options = new AttributeOptions(encodeQuotes: true);
            Assert.AreEqual("name='{\"name\":\"daniel\"}'", 
                new Attribute("name", "{\"name\":\"daniel\"}").ToString());
            Assert.AreEqual("name='{&quot;name&quot;:&quot;daniel&quot;}'",
                new Attribute("name", "{\"name\":\"daniel\"}", options).ToString());

            options = new AttributeOptions(quote: "\"");
            Assert.AreEqual("name=\"{&quot;name&quot;:&quot;daniel&quot;}\"",
                new Attribute("name", "{\"name\":\"daniel\"}", options).ToString(),
                "with a different quote and encodeQuotes false");

            options = new AttributeOptions(encodeQuotes: true, quote: "\"");
            Assert.AreEqual("name=\"{&quot;name&quot;:&quot;daniel&quot;}\"",
                new Attribute("name", "{\"name\":\"daniel\"}", options).ToString(),
                "with a different quote and encodeQuotes = true");

        }

        [TestMethod]
        public void UnEncodeApostropheInValue()
        {
            var options = new AttributeOptions(quote: "\"");
            Assert.AreEqual("name=\"isn't it ironic\"",
                new Attribute("name", "isn't it ironic", options).ToString(),
                "apostrophe with a different quote and encodeQuotes = false");

            options = new AttributeOptions(encodeQuotes: true);
            Assert.AreEqual("name='isn&apos;t it ironic'",
                new Attribute("name", "isn't it ironic", options).ToString(),
                "apostrophe with a different quote and encodeQuotes = true");

            options = new AttributeOptions(encodeQuotes: true, quote: "\"");
            Assert.AreEqual("name=\"isn&apos;t it ironic\"",
                new Attribute("name", "isn't it ironic", options).ToString(),
                "apostrophe with a different quote and encodeQuotes = true");

        }

        [TestMethod]
        public void BasicAttributesEmpty()
        {
            Assert.AreEqual("name=''", 
                new Attribute("name", "").ToString());
            Assert.AreEqual("name", 
                new Attribute("name", null).ToString());
            Assert.AreEqual("name=''", 
                new Attribute("name", null,
                new AttributeOptions(dropValueIfNull: false)).ToString());

            var options = new AttributeOptions(keepEmpty: false);
            Assert.AreEqual("", 
                new Attribute("name", "", options).ToString());
        }

        [TestMethod]
        public void ObjectValues()
        {
            //var options = new AttributeOptions { KeepEmpty = false };
            Assert.AreEqual("name='54'",
                new Attribute("name", 54).ToString());
            Assert.AreEqual("name='{\"Name\":\"Daniel\"}'",
                new Attribute("name", new { Name = "Daniel" }).ToString());
            Assert.AreEqual("name='Daniel'",
                new Attribute("name", "Daniel" as object).ToString());
        }

    }
}
