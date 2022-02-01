using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Markup;

namespace ToSic.RazorBladeTests.InternalTests
{
    [TestClass]
    public class UriEncoding
    {
        /// <summary>
        /// Verify that uri-encode works and leaves slashes etc. untouched
        /// </summary>
        [TestMethod]
        public void UriEncode()
        {
            Assert.AreEqual("hello", TagBase.UriEncode("hello"));

            Assert.AreEqual("hell%C3%B6", TagBase.UriEncode("hellö"),
                "check umlauts");

            Assert.AreEqual("hello/there.aspx", TagBase.UriEncode("hello/there.aspx"), 
                "check path parts");
            
            Assert.AreEqual("hello?parameter=7", TagBase.UriEncode("hello?parameter=7"), 
                "check params");

            Assert.AreEqual("http://azing.org",  TagBase.UriEncode("http://azing.org"), 
                "check domains");

            Assert.AreEqual("http://azing.org/homepage?name=m", "http://azing.org/homepage?name=m", 
                "check full url");

            Assert.AreEqual("http://azing.org/home%20page?name=m", TagBase.UriEncode("http://azing.org/home page?name=m"), 
                "check spaces");

            Assert.AreEqual("something#hashed", TagBase.UriEncode("something#hashed"),
                "check hash");

            Assert.AreEqual("url+plus", TagBase.UriEncode("url+plus"),
                "check plus in url = it's a space, and shouldn't be re-encode");


        }

        [TestMethod]
        public void Nulls()
        {
            Assert.AreEqual(null, TagBase.UriEncode(null));
        }

        [TestMethod]
        public void ResizeUrls()
        {
            Assert.AreEqual("img.jpg?w=200", TagBase.UriEncode("img.jpg?w=200"));
        }

        [TestMethod]
        public void DontDoubleEncode()
        {
            Assert.AreEqual("%20", TagBase.UriEncode("%20"),
                "check don't re-encode");

            Assert.AreEqual("hello%20there", TagBase.UriEncode(TagBase.UriEncode("hello there")));
        }

        [TestMethod]
        public void EncodePercentIfNotUsedForEncoding()
        {
            Assert.AreEqual("I-want-25%25-profit", TagBase.UriEncode("I-want-25%-profit"));

            Assert.AreEqual("25%25is%20enough", TagBase.UriEncode("25%is enough"));
        }
    }
}
