using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.RazorBladeTests.TagTests;
using Tag = ToSic.Razor.Blade.Tag;

namespace ToSic.RazorBladeTests.Html5QuickAccess
{
    [TestClass]
    public class TableTestsQa: TagTestBase
    {
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TableBasic()
        {
            Is("<table></table>", 
                Tag.Table());
        }

        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TableWithRowAnd2Cells()
        {
            Is("<table><tr><td></td><td></td></tr></table>",
                Tag.Table(
                    Tag.Tr(Tag.Td(), Tag.Td())
                )
            );

            Is("<table><tr><td></td><td></td></tr></table>",
                Tag.Table(
                    Tag.Tr(
                        Tag.Td(),
                        Tag.Td()
                    )
                )
            );

            Is("<table><tr><td></td><td></td></tr></table>",
                Tag.Table()
                    .Add(Tag.Tr(Tag.Td(), Tag.Td())));
            Is("<table><tr><td></td><td></td></tr></table>",
                Tag.Table()
                    .Add(Tag.Tr()
                        .Add(Tag.Td(), Tag.Td())));
            Is("<table><tr><td></td><td></td></tr></table>",
                Tag.Table()
                    .Add(Tag.Tr()
                        .Add(Tag.Td())
                        .Add(Tag.Td())
                    )
            );

            // the same thing using wrap
            Is("<table><tr><td></td><td></td></tr></table>",
                Tag.Table()
                    .Wrap(Tag.Tr(Tag.Td(), Tag.Td())));
            Is("<table><tr><td></td><td></td></tr></table>",
                Tag.Table()
                    .Wrap(Tag.Tr()
                        .Wrap(Tag.Td(), Tag.Td())));
            Is("<table><tr><td></td></tr></table>",
                Tag.Table()
                    .Wrap(Tag.Tr()
                        .Wrap(Tag.Td())
                        .Wrap(Tag.Td())
                    )
            );

        }

        [TestMethod]
        public void TrChaining()
        {
            Is("<table><tr></tr></table>",
                Tag.Table(Tag.Tr()));
            Is("<table><tr></tr><tr></tr></table>",
                Tag.Table(Tag.Tr(), Tag.Tr()));
            Is("<table><tr><td></td></tr></table>",
                Tag.Table(
                    Tag.Tr(
                        Tag.Td()
                    )
                )
            );

            Is("<table><tr><td></td></tr><tr><td></td></tr></table>",
                Tag.Table(
                    Tag.Tr(
                        Tag.Td()
                    ),
                    Tag.Tr(
                        Tag.Td()
                    )
                )

            );

        }


    }
}
