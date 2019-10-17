using Connect.Razor.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Razor_Blades_Tests.InternalTests
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
            Assert.AreEqual("hello", Tag.UriEncode("hello"));

            Assert.AreEqual("hell%C3%B6", Tag.UriEncode("hellö"),
                "check umlauts");

            Assert.AreEqual("hello/there.aspx", Tag.UriEncode("hello/there.aspx"), 
                "check path parts");
            
            Assert.AreEqual("hello?parameter=7", Tag.UriEncode("hello?parameter=7"), 
                "check params");

            Assert.AreEqual("http://azing.org",  Tag.UriEncode("http://azing.org"), 
                "check domains");

            Assert.AreEqual("http://azing.org/homepage?name=m", "http://azing.org/homepage?name=m", 
                "check full url");

            Assert.AreEqual("http://azing.org/home%20page?name=m", Tag.UriEncode("http://azing.org/home page?name=m"), 
                "check spaces");

            Assert.AreEqual("something#hashed", Tag.UriEncode("something#hashed"),
                "check hash");

            Assert.AreEqual("url+plus", Tag.UriEncode("url+plus"),
                "check plus in url = it's a space, and shouldn't be re-encode");


        }

        [TestMethod]
        public void Nulls()
        {
            Assert.AreEqual(null, Tag.UriEncode(null));
        }

        [TestMethod]
        public void ResizeUrls()
        {
            Assert.AreEqual("img.jpg?w=200", Tag.UriEncode("img.jpg?w=200"));
        }

        [TestMethod]
        public void DontDoubleEncode()
        {
            Assert.AreEqual("%20", Tag.UriEncode("%20"),
                "check don't re-encode");

            Assert.AreEqual("hello%20there", Tag.UriEncode(Tag.UriEncode("hello there")));
        }

        [TestMethod]
        public void EncodePercentIfNotUsedForEncoding()
        {
            Assert.AreEqual("I-want-25%25-profit", Tag.UriEncode("I-want-25%-profit"));

            Assert.AreEqual("25%25is%20enough", Tag.UriEncode("25%is enough"));
        }
    }
}
