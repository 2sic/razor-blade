using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Markup;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ToSic.RazorBladeTests.TagBuilderTests
{
    [TestClass]
    public class AttributesBuilderTest
    {
        [DataRow("Name='Daniel' Age='unknown'", null)]
        [DataRow("Name=\"Daniel\" Age=\"unknown\"", "\"")]
        [TestMethod]
        public void StringQuotes(string expected, string? quote)
        {
            var attributes = (quote == null ? new() : new Attributes(new AttributeOptions(quote: quote)))
                .Add("Name", "Daniel")
                .Add("Age", "unknown");
            AreEqual(expected, attributes.ToString());
        }

        [DataRow("Name='Daniel' Profile='{\"Age\":17}'", null)]
        [DataRow("Name=\"Daniel\" Profile=\"{&quot;Age&quot;:17}\"", "\"")]
        [TestMethod]
        public void ObjectsQuotes(string expected, string? quote)
        {
            var attributes = (quote == null ? new() : new Attributes(new AttributeOptions(quote: quote)))
                .Add("Name", "Daniel")
                .Add("Profile", new { Age = 17 });
            AreEqual(expected, attributes.ToString());
        }

        [TestMethod]
        public void AddSameAttribute()
        {
            var list = new Attributes()
                .Add("name", "value")
                .Add("name", "value2", " ");
            AreEqual("name='value value2'", list.ToString());
        }

        [TestMethod]
        public void AddSameAttributeWithoutSeparator()
        {
            var list = new Attributes()
                .Add("name", "value")
                .Add("name", "value2");
            AreEqual("name='value2'", list.ToString());
        }
        [TestMethod]
        public void AddSameAttributeComma()
        {
            var list = new Attributes()
                .Add("name", "value")
                .Add("name", "value2", appendSeparator:",");
            AreEqual("name='value,value2'", list.ToString());
        }

        [TestMethod]
        public void AddSameAttributeReplace()
        {
            var list = new Attributes()
                .Add("name", "value")
                .Add("name", "value2", null);
            AreEqual("name='value2'", list.ToString());
        }

    }
}
