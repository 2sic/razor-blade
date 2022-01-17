using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using ToSic.RazorBladeTests.TagTests;

namespace ToSic.RazorBladeTests.Html5QuickAccess
{
    [TestClass]
    public class ATests: TagTestBase
    {
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TableBasic()
        {
            Is("<a href='...'>hello there</a>", 
                Tag.A("hello there").Href("..."));
        }

        //[TestMethod]
        //public void TrChaining()
        //{
        //    Is("<table><tr></tr></table>",
        //        TagBase.Table(TagBase.Tr()));
        //    Is("<table><tr></tr><tr></tr></table>",
        //        TagBase.Table(TagBase.Tr(), TagBase.Tr()));
        //    Is("<table><tr><td></td></tr></table>",
        //        TagBase.Table(
        //            TagBase.Tr(
        //                TagBase.Td()
        //            )
        //        )
        //    );

        //    Is("<table><tr><td></td></tr><tr><td></td></tr></table>",
        //        TagBase.Table(
        //            TagBase.Tr(
        //                TagBase.Td()
        //            ),
        //            TagBase.Tr(
        //                TagBase.Td()
        //            )
        //        )

        //    );

        //}


    }
}
