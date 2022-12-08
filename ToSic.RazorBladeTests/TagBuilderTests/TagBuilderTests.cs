using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Markup;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.TagBuilderTests
{
    [TestClass]
    public class TagBuilderTests : TagTestBase
    {
        [TestMethod]
        public void BasicTags()
        {
            Is("<p></p>", new TagCustom("p"));
            Is("<em></em>", new TagCustom("em"));
            Is("<EM></EM>", new TagCustom("EM"));
            Is("<ng-template></ng-template>", new TagCustom("ng-template"));
        }


        [TestMethod]
        public void Content()
        {
            // ReSharper disable once RedundantArgumentDefaultValue
            Is("<p></p>", new TagCustom("p").Wrap(null));
            Is("<em></em>", new TagCustom("em").Wrap(""));
            Is("<p> </p>", new TagCustom("p").Wrap(" "));
            Is("<p>...</p>", new TagCustom("p").Wrap("..."));
            Is("<p>many\nlines</p>", new TagCustom("p").Wrap("many\nlines"));
        }

        [DataRow("<p>...</p>", "p", "...", null, true)]
        [DataRow("<p>...</p>", "p", "...", false, null)]
        [DataRow("<p>...</p>", "p", "...", false, true)]
        [DataRow("<p>", "p", "", false, true)]
        [DataRow("<p>", "p", null, false, true)]
        [TestMethod]
        public void ContentWithInvalidClosing(string expected, string tag, string content, bool? close, bool? selfClose, string? message = null) 
            => Is(expected, new TagCustom(tag, new(close: close, selfClose: selfClose)).Wrap(content), message);


        [TestMethod]
        public void TagsWithIdAndClasses()
            => Is("<p id='myId' class='my-class float-right'></p>",
                new TagCustom("p").Id("myId").Class("my-class float-right"));

        [TestMethod]
        public void TagsWithAttributeString()
            => Is("<p data='xyz'></p>",
                new TagCustom("p").Attr("data='xyz'"));

        [TestMethod]
        public void TagsWithAttributeList()
            => Is("<p data='xyz' kitchen='black'></p>",
                new TagCustom("p")
                    .Attr("data", "xyz").Attr("kitchen", "black")
                    );

        [TestMethod]
        public void TagsWithClassIdAndAttributeString()
            => Is("<p id='myId' class='my-class float-right' data='xyz'></p>",
                new TagCustom("p").Id("myId").Class("my-class float-right")
                    .Attr("data='xyz'"));

        [TestMethod]
        public void TagsWithClassIdAndAttributeList()
            => Is("<p id='myId' class='my-class float-right' data='xyz' kitchen='black'></p>",
                new TagCustom("p")
                    .Id("myId").Class("my-class float-right")
                    .Attr("data", "xyz").Attr("kitchen", "black")
                    );

        [TestMethod]
        public void TagWithSelfClose()
            => Is("<p/>",
                new TagCustom("p", options: new(selfClose: true))
                    );

        [TestMethod]
        public void TagsWithIdAndClassesSelfClose()
            => Is("<p id='myId' class='my-class float-right'/>",
                new TagCustom("p", new(selfClose: true)).Id("myId").Class("my-class float-right"));


        [TestMethod]
        public void TagsWithClassIdAndAttributeListOptionsQuote()
            => Is("<p id=\"myId\" class=\"my-class float-right\" data=\"xyz\" kitchen=\"black\"></p>",
                new TagCustom("p", options: new(attributeOptions: new(quote: "\"")))
                    .Id("myId").Class("my-class float-right")
                    .Attr("data", "xyz")
                    .Attr("kitchen", "black")
            );

    }
}
