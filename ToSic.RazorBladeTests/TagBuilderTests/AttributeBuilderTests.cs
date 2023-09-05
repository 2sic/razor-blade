using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Markup;

namespace ToSic.RazorBladeTests.TagBuilderTests
{
    [TestClass]
    public class AttributeBuilderTests
    {
        /// <summary>
        /// Test accessor to reduce use-count
        /// </summary>
        public Attribute NewAttribute(string name, object? value = default, AttributeOptions? options = default)
            => new Attribute(name, value, options);

        [TestMethod]
        public void BasicAttributes()
        {
            Assert.AreEqual("name='value'", NewAttribute("name", "value").ToString());
            Assert.AreEqual("something='other'", NewAttribute("something", "other").ToString());
        }

        [TestMethod] public void BasicAttributesStandalone()
        {
            var o = AttributeOptions.StandaloneOptions;
            Assert.AreEqual(" name='value' ", NewAttribute("name", "value", o).ToString());
            Assert.AreEqual(" something='other' ", NewAttribute("something", "other", o).ToString());

        }

        [TestMethod]
        public void BasicAttributesQuote()
        {
            var options = new AttributeOptions(quote: "\"");
            Assert.AreEqual("name=\"value\"", 
                NewAttribute("name", "value", options).ToString());
            Assert.AreEqual("something=\"other\"",
                NewAttribute("something", "other", options).ToString());
        }

        [TestMethod]
        public void UnEncodeQuote()
        {
            var options = new AttributeOptions(encodeQuotes: true);
            Assert.AreEqual("name='{\"name\":\"daniel\"}'", 
                NewAttribute("name", "{\"name\":\"daniel\"}").ToString());
            Assert.AreEqual("name='{&quot;name&quot;:&quot;daniel&quot;}'",
                NewAttribute("name", "{\"name\":\"daniel\"}", options).ToString());

            options = new AttributeOptions(quote: "\"");
            Assert.AreEqual("name=\"{&quot;name&quot;:&quot;daniel&quot;}\"",
                NewAttribute("name", "{\"name\":\"daniel\"}", options).ToString(),
                "with a different quote and encodeQuotes false");

            options = new AttributeOptions(encodeQuotes: true, quote: "\"");
            Assert.AreEqual("name=\"{&quot;name&quot;:&quot;daniel&quot;}\"",
                NewAttribute("name", "{\"name\":\"daniel\"}", options).ToString(),
                "with a different quote and encodeQuotes = true");

        }

        [TestMethod]
        public void UnEncodeApostropheInValue()
        {
            var options = new AttributeOptions(quote: "\"");
            Assert.AreEqual("name=\"isn't it ironic\"",
                NewAttribute("name", "isn't it ironic", options).ToString(),
                "apostrophe with a different quote and encodeQuotes = false");

            options = new AttributeOptions(encodeQuotes: true);
            Assert.AreEqual("name='isn&apos;t it ironic'",
                NewAttribute("name", "isn't it ironic", options).ToString(),
                "apostrophe with a different quote and encodeQuotes = true");

            options = new AttributeOptions(encodeQuotes: true, quote: "\"");
            Assert.AreEqual("name=\"isn&apos;t it ironic\"",
                NewAttribute("name", "isn't it ironic", options).ToString(),
                "apostrophe with a different quote and encodeQuotes = true");

        }

        [TestMethod]
        public void BasicAttributesEmpty()
        {
            Assert.AreEqual("name=''", 
                NewAttribute("name", "").ToString());
            Assert.AreEqual("name", 
                NewAttribute("name", null).ToString());
            Assert.AreEqual("name=''", 
                NewAttribute("name", null,
                new AttributeOptions(dropValueIfNull: false)).ToString());

            var options = new AttributeOptions(keepEmpty: false);
            Assert.AreEqual("", 
                NewAttribute("name", "", options).ToString());
        }

        [TestMethod]
        public void ObjectValues()
        {
            //var options = new AttributeOptions { KeepEmpty = false };
            Assert.AreEqual("name='54'",
                NewAttribute("name", 54).ToString());
            Assert.AreEqual("name='{\"Name\":\"Daniel\"}'",
                NewAttribute("name", new { Name = "Daniel" }).ToString());
            Assert.AreEqual("name='Daniel'",
                NewAttribute("name", "Daniel" as object).ToString());
        }

    }
}
