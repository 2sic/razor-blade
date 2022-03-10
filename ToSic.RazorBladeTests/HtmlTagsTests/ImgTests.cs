using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.HtmlTagsTests
{
    [TestClass]
    public class ImgTests: TagTestBase
    {

        [TestMethod]
        public void Img()
        {
            Is("<img src='abc.jpg'>", Tag.Img().Src("abc.jpg"));
        }


        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void Img2()
        {
            Is("<img>", new Img());
            Is("<img src='https://azing.org'>", new Img("https://azing.org"));
            Is("<img src='https://azing.org'>", new Img().Src("https://azing.org"));
        }

        [TestMethod]
        public void ImgWithUnexpectedContent()
            => Is("<img src='abc%20def.jpg'>content</img>", Tag.Img("content").Src("abc def.jpg"));


        [TestMethod]
        public void ImgWithSpace() 
            => Is("<img src='abc%20def.jpg'>", Tag.Img().Src("abc def.jpg"));

        [TestMethod]
        public void ImgWithUmlaut() 
            => Is("<img src='L%C3%A9onie%20M%C3%BCller.jpg'>", Tag.Img().Src("Léonie Müller.jpg"));

        [TestMethod]
        public void ImgWithUmlautAndResizer() 
            => Is("<img src='L%C3%A9onie%20M%C3%BCller.jpg?w=17'>", Tag.Img().Src("Léonie Müller.jpg?w=17"));

        [TestMethod]
        public void ImgWithMultipleParamsShouldConvertAmp() 
            => Is("<img src='test.jpg?w=100&amp;h=100'>", Tag.Img().Src("test.jpg?w=100&h=100"));


        [TestMethod]
        public void ImgSizes()
        {
            Is("<img src='xyz' height='8' width='7'>", 
                new Img("xyz", 7, 8));

            Is("<img src='xyz' height='8' width='7'>",
                new Img("xyz").Height(8).Width(7));
        }

        [TestMethod]
        public void ImgSrcSetX()
        {
            Is("<img src='xyz.jpg' srcset='xyz.jpg?w=400 2x'>", 
                new Img("xyz.jpg").Srcset("xyz.jpg?w=400", 2));

            Is("<img src='xyz.jpg' srcset='xyz.jpg?w=400 2x,xyz.jpg?w=600 3x'>", 
                new Img("xyz.jpg")
                    .Srcset( "xyz.jpg?w=400", 2)
                    .Srcset( "xyz.jpg?w=600", 3));

            Is("<img src='xyz.jpg' srcset='xyz.jpg?w=400 2x,xyz.jpg?w=600 3x,xyz-large.jpg 4x'>",
                new Img("xyz.jpg")
                    .Srcset("xyz.jpg?w=400", 2)
                    .Srcset( "xyz.jpg?w=600", 3)
                    .Srcset( "xyz-large.jpg", 4));

            Is("<img src='xyz' height='8' width='7' srcset='xyz.jpg?w=400 2x'>", 
                new Img("xyz", 7, 8)
                    .Srcset( "xyz.jpg?w=400", 2));
        }

        [TestMethod]
        public void ImgSrcSetW()
        {
            Is("<img src='xyz.jpg' srcset='xyz.jpg?w=400 100w'>",
                new Img("xyz.jpg")
                    .Srcset( "xyz.jpg?w=400", 100));

            Is("<img src='xyz.jpg' srcset='xyz.jpg?w=400 100w,xyz.jpg?w=600 200w'>",
                new Img("xyz.jpg")
                    .Srcset( "xyz.jpg?w=400", 100)
                    .Srcset( "xyz.jpg?w=600", 200));

            Is("<img src='xyz.jpg' srcset='xyz.jpg?w=400 100w,xyz.jpg?w=600 300w,xyz-large.jpg 1000w'>",
                new Img("xyz.jpg")
                    .Srcset( "xyz.jpg?w=400", 100)
                    .Srcset( "xyz.jpg?w=600", 300)
                    .Srcset( "xyz-large.jpg", 1000));

            Is("<img src='xyz' height='8' width='7' srcset='xyz.jpg?w=400 100w'>",
                new Img("xyz", 7, 8)
                    .Srcset( "xyz.jpg?w=400", 100));
        }

        [TestMethod]
        public void ImgSrcSetUmlautsNoXw() 
            => Is("<img srcset='L%C3%A9onie%20M%C3%BCller.jpg?w=17'>", Tag.Img().Srcset("Léonie Müller.jpg?w=17"));

        [TestMethod]
        public void ImgSrcSetUmlautsXorW()
        {
            Is("<img srcset='L%C3%A9onie%20M%C3%BCller.jpg?w=17 2x'>", Tag.Img().Srcset("Léonie Müller.jpg?w=17", 2));
            Is("<img srcset='L%C3%A9onie%20M%C3%BCller.jpg?w=17 2x'>", Tag.Img().Srcset("Léonie Müller.jpg?w=17 2x"));

            Is("<img srcset='L%C3%A9onie%20M%C3%BCller.jpg?w=17 700w'>", Tag.Img().Srcset("Léonie Müller.jpg?w=17", 700));
            Is("<img srcset='L%C3%A9onie%20M%C3%BCller.jpg?w=17 700w'>", Tag.Img().Srcset("Léonie Müller.jpg?w=17 700w"));
        }

        [TestMethod]
        public void ImgSrcSetUmlautsMultiline()
        {
            Is(@"<img srcset='
L%C3%A9onie%20M%C3%BCller.jpg?w=17 2x,
L%C3%A9onie%20M%C3%BCller.jpg?w=17 700w'>",
                Tag.Img().Srcset(@"
Léonie Müller.jpg?w=17 2x,
Léonie Müller.jpg?w=17 700w"));

        }

        [TestMethod]
        public void ImgSrcSetUmlautsMultiple()
        {
            Is("<img srcset='L%C3%A9onie%20M%C3%BCller.jpg?w=17 2x,L%C3%A9onie%20M%C3%BCller.jpg?w=17 700w'>", Tag.Img()
                .Srcset("Léonie Müller.jpg?w=17", 2)
                .Srcset("Léonie Müller.jpg?w=17 700w"));
        }

        [TestMethod]
        public void NoDuplicateAttributes()
        {
            Is("<img src='xyz' width='12'>", 
                new Img("xyz", 7).Width(12));

            Is("<img src='xyz' width='15'>",
                new Img("xyz").Width(14).Width("15"));
        }

        [TestMethod]
        public void PictureBasic()
        {
            Is("<picture></picture>", new Picture());
            Is("<picture><img src='https://azing.org'></picture>",
                new Picture(new Img("https://azing.org")));

        }

        [TestMethod]
        public void PictureWithSources()
        {
            Is("<picture>" +
               "<source srcset='something.jpg'>" +
               "<source srcset='other.webp' type='image/webp'>" +
               "<img src='https://azing.org'>" +
               "</picture>",
                new Picture(new PictureSource("something.jpg"), new PictureSource("other.webp", type: "image/webp"), new Img("https://azing.org")));

        }

    }
}
