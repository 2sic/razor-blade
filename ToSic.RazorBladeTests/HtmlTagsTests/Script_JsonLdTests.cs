using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Html5;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.HtmlTagsTests
{
    [TestClass]
    public class Script_JsonLdTests : TagTestBase
    {

        [TestMethod]
        public void JsonLdString()
        {
            Is("<script type='application/ld+json'>some text</script>",
                new ScriptJsonLd("some text"));
            Is("<script type='application/ld+json'>{\"key\":\"value\"}</script>",
                new ScriptJsonLd("{\"key\":\"value\"}"));
        }

        [TestMethod]
        public void JsonLdObject()
        {
            Is("<script type='application/ld+json'>{\"key\":\"value\"}</script>",
                new ScriptJsonLd(new { key = "value" }));
        }

        //[TestMethod]
        //public void JsonLdStringXssExists()
        //{
        //    Is("<script type='application/ld+json'>{\"key\":\"</script>\"}</script>",
        //        new ScriptJsonLd("{\"key\":\"</script>\"}"));
        //}

        [TestMethod]
        public void ValidJsonLdString()
        {
            Is("<script type='application/ld+json'>{ \"name\": \"Jane Doe\", \"@context\": \"http://schema.org/\", \"@type\": \"Person\" }</script>",
                new ScriptJsonLd("{ \"name\": \"Jane Doe\", \"@context\": \"http://schema.org/\", \"@type\": \"Person\" }"));
        }

        [TestMethod]
        public void ValidJsonLdStringWithXss()
        {
            Is("<script type='application/ld+json'>{ \"name\": \"\\u003C/script>\\u003Cscript>\", \"@context\": \"http://schema.org/\", \"@type\": \"Person\" }</script>",
                new ScriptJsonLd("{ \"name\": \"</script><script>\", \"@context\": \"http://schema.org/\", \"@type\": \"Person\" }"));
            Is("<script type='application/ld+json'>{ \"name\": \"\\u003C!-- html comment --\\u003E\", \"@context\": \"http://schema.org/\", \"@type\": \"Person\" }</script>",
                new ScriptJsonLd("{ \"name\": \"<!-- html comment -->\", \"@context\": \"http://schema.org/\", \"@type\": \"Person\" }"));
        }

        [TestMethod]
        public void JsonLdObjectWithXssScript()
        {
            Is("<script type='application/ld+json'>{\"name\":\"\\u003C/script\\u003E\\u003Cscript\\u003E\"}</script>",
                new ScriptJsonLd(new { name = "</script><script>" }));
        }
        [TestMethod]
        public void JsonLdObjectWithXssComment()
        {
            Is("<script type='application/ld+json'>{\"name\":\"\\u003C!-- html comment --\\u003E\"}</script>",
                new ScriptJsonLd(new { name = "<!-- html comment -->" }));
        }
    }
}
