using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;

namespace Razor_Blades_Tests.Html5QuickAccess
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
        //        Tag.Table(Tag.Tr()));
        //    Is("<table><tr></tr><tr></tr></table>",
        //        Tag.Table(Tag.Tr(), Tag.Tr()));
        //    Is("<table><tr><td></td></tr></table>",
        //        Tag.Table(
        //            Tag.Tr(
        //                Tag.Td()
        //            )
        //        )
        //    );

        //    Is("<table><tr><td></td></tr><tr><td></td></tr></table>",
        //        Tag.Table(
        //            Tag.Tr(
        //                Tag.Td()
        //            ),
        //            Tag.Tr(
        //                Tag.Td()
        //            )
        //        )

        //    );

        //}


    }
}
