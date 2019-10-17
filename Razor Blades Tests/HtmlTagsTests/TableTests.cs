using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Razor_Blades_Tests.HtmlTagsTests
{
    [TestClass]
    public class TableTests: TagTestBase
    {
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TableBasic()
        {
            Is("<table></table>", 
                new Table());
        }

        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TableWithRowAnd2Cells()
        {
            Is("<table><tr><td></td><td></td></tr></table>",
                new Table(
                    new Tr(new Td(), new Td())
                )
            );

            Is("<table><tr><td></td><td></td></tr></table>",
                new Table(
                    new Tr(
                        new Td(),
                        new Td()
                    )
                )
            );

            Is("<table><tr><td></td><td></td></tr></table>",
                new Table()
                    .Add(new Tr(new Td(), new Td())));
            Is("<table><tr><td></td><td></td></tr></table>",
                new Table()
                    .Add(new Tr()
                        .Add(new Td(), new Td())));
            Is("<table><tr><td></td><td></td></tr></table>",
                new Table()
                    .Add(new Tr()
                        .Add(new Td())
                        .Add(new Td())
                    )
            );
        }

        [TestMethod]
        public void TrChaining()
        {
            Is("<table><tr></tr></table>",
                new Table(new Tr()));
            Is("<table><tr></tr><tr></tr></table>",
                new Table(new Tr(), new Tr()));
            Is("<table><tr><td></td></tr></table>",
                new Table(
                    new Tr(
                        new Td()
                    )
                )
            );

            Is("<table><tr><td></td></tr><tr><td></td></tr></table>",
                new Table(
                    new Tr(
                        new Td()
                    ),
                    new Tr(
                        new Td()
                    )
                )

            );

        }

    }
}
