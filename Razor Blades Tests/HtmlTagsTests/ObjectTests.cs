using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.HtmlTagsTests
{
    [TestClass]
    public class ObjectTests: TagTestBase
    {

        [TestMethod]
        public void ObjectData() =>
            Is(@"<object data='http://xyz.org'>text</object>",
                Tag.Object()
                    .Data("http://xyz.org")
                    .Add("text"));

        [TestMethod]
        public void ObjectDataWithUmlauts() =>
            Is(@"<object data='http://xyz.org/data?name=L%C3%A9onie'>text</object>",
                Tag.Object()
                    .Data("http://xyz.org/data?name=Léonie")
                    .Add("text"));

    }
}
