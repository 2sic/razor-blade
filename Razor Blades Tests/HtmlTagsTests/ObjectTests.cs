using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Razor_Blades_Tests.HtmlTagsTests
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
