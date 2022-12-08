using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Internals;

namespace ToSic.RazorBladeTests.InternalTests
{
    [TestClass]
    public class UriEncoding
    {
        /// <summary>
        /// Test Accessor
        /// </summary>
        private string EncodeTestAccessor(string url) => UriHelpers.UriEncode(url);

        /// <summary>
        /// Test Accessor
        /// </summary>
        private string EncodeSrcSetTestAccessor(string srcset) => UriHelpers.UriEncodeSrcSet(srcset);

        /// <summary>
        /// Verify that uri-encode works and leaves slashes etc. untouched
        /// </summary>
        [TestMethod]
        public void UriEncode()
        {
            Assert.AreEqual("hello", EncodeTestAccessor("hello"));

            Assert.AreEqual("hell%C3%B6", EncodeTestAccessor("hellö"),
                "check umlauts");

            Assert.AreEqual("hello/there.aspx", EncodeTestAccessor("hello/there.aspx"), 
                "check path parts");
            
            Assert.AreEqual("hello?parameter=7", EncodeTestAccessor("hello?parameter=7"), 
                "check params");

            Assert.AreEqual("http://azing.org",  EncodeTestAccessor("http://azing.org"), 
                "check domains");

            Assert.AreEqual("http://azing.org/homepage?name=m", "http://azing.org/homepage?name=m", 
                "check full url");

            Assert.AreEqual("http://azing.org/home%20page?name=m", EncodeTestAccessor("http://azing.org/home page?name=m"), 
                "check spaces");

            Assert.AreEqual("something#hashed", EncodeTestAccessor("something#hashed"),
                "check hash");

            Assert.AreEqual("url+plus", EncodeTestAccessor("url+plus"),
                "check plus in url = it's a space, and shouldn't be re-encode");


        }

        [TestMethod]
        public void Nulls()
        {
            Assert.AreEqual(null, EncodeTestAccessor(null));
        }

        [TestMethod]
        public void ResizeUrls()
        {
            Assert.AreEqual("img.jpg?w=200", EncodeTestAccessor("img.jpg?w=200"));
        }

        [TestMethod]
        public void DontDoubleEncode()
        {
            Assert.AreEqual("%20", EncodeTestAccessor("%20"),
                "check don't re-encode");

            Assert.AreEqual("hello%20there", EncodeTestAccessor(EncodeTestAccessor("hello there")));
        }

        [TestMethod]
        public void EncodePercentIfNotUsedForEncoding()
        {
            Assert.AreEqual("I-want-25%25-profit", EncodeTestAccessor("I-want-25%-profit"));

            Assert.AreEqual("25%25is%20enough", EncodeTestAccessor("25%is enough"));
        }

        [TestMethod]
        public void SrcSetUnchanged()
        {
            var original = "something.jpg 1x";
            Assert.AreEqual(original, EncodeSrcSetTestAccessor(original));
        }

        [TestMethod]
        public void SrcSetUnchanged2()
        {
            var original = "something.jpg?test=true 1x";
            Assert.AreEqual(original, EncodeSrcSetTestAccessor(original));
        }

        [TestMethod]
        public void SrcSetAmp()
        {
            var original = "something.jpg?x=1&y=z 1x";
            Assert.AreEqual(original, EncodeSrcSetTestAccessor(original));
        }
        [TestMethod]
        public void SrcSetOneLine()
        {
            var original = "something.jpg?x=1&y=z 1x,something.jpg?x=1&y=z 2x";
            Assert.AreEqual(original, EncodeSrcSetTestAccessor(original));
        }

        [TestMethod]
        public void SrcSetMultiline()
        {
            var original = "something.jpg?x=1&y=z 1x,\nsomething.jpg?x=1&y=z 2x";
            Assert.AreEqual(original.Replace("\n", ""), EncodeSrcSetTestAccessor(original));
        }
    }
}
