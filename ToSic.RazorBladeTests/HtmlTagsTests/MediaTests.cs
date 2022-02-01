using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.HtmlTagsTests
{
    [TestClass]
    public class MediaTests: TagTestBase
    {
        //[TestMethod]
        //public void AudioBasic()
        //{
        //}

        [TestMethod]
        public void AudioRealLife()
        {
            const string expected = @"<audio controls><source src='horse.ogg' type='audio/ogg'><source src='horse.mp3' type='audio/mpeg'>Your browser does not support the audio tag.</audio>";
            var result = new Audio().Controls()
                .Add(Tag.Source().Src("horse.ogg").Type("audio/ogg"))
                .Add(new Source().Src("horse.mp3").Type("audio/mpeg"))
                .Add("Your browser does not support the audio tag.");

            Is(expected, result);

        }

    }
}
