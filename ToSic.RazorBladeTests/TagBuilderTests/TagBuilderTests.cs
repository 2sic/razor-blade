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
            Is("<p></p>",
                new TagCustom("p") { TagContents = null });
            Is("<em></em>",
                new TagCustom("em") { TagContents = "" });
            Is("<p> </p>",
                new TagCustom("p") { TagContents = " " });
            Is("<p>...</p>",
                new TagCustom("p") { TagContents = "..." });
            Is("<p>many\nlines</p>",
                new TagCustom("p") { TagContents = "many\nlines" });
        }

        [TestMethod]
        public void ContentWithInvalidClosing()
        {
            Is("<p>...</p>",
                new TagCustom("p", new TagOptions { SelfClose = true }) { TagContents = "..." });

            Is("<p>...</p>",
                new TagCustom("p", new TagOptions { Close = false })
                { TagContents = "..." });

            Is("<p>...</p>", new TagCustom("p", new TagOptions { Close = false, SelfClose = true })
            { TagContents = "..." });
        }


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
                new TagCustom("p", options: new TagOptions { SelfClose = true })
                    );

        [TestMethod]
        public void TagsWithIdAndClassesSelfClose()
            => Is("<p id='myId' class='my-class float-right'/>",
                new TagCustom("p", new TagOptions { SelfClose = true }).Id("myId").Class("my-class float-right"));


        [TestMethod]
        public void TagsWithClassIdAndAttributeListOptionsQuote()
            => Is("<p id=\"myId\" class=\"my-class float-right\" data=\"xyz\" kitchen=\"black\"></p>",
                new TagCustom("p", options: new TagOptions(new AttributeOptions { Quote = "\"" }))
                    .Id("myId").Class("my-class float-right")
                    .Attr("data", "xyz")
                    .Attr("kitchen", "black")

                );

    }
}
