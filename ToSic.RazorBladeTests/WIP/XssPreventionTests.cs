using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Wip;

namespace ToSic.RazorBladeTests.WIP
{
    [TestClass]
    public class XssPreventionTests
    {
        [TestMethod]
        [DataRow("<script>alert('xss')</script><!-- html comment -->", @"\u003Cscript>alert('xss')\u003C/script>\u003C!-- html comment --\u003E")]
        [DataRow(null, null)]
        [DataRow("", "")]
        [DataRow("nothing to do", "nothing to do")]
        [DataRow("</script", "\\u003C/script")]
        [DataRow("</scriptnewtag", "\\u003C/scriptnewtag")]
        [DataRow("</ScRiPt>", "\\u003C/ScRiPt>")]
        [DataRow("</script   >", "\\u003C/script   >")]
        [DataRow("  </script", "  \\u003C/script")]
        [DataRow("\n</script\n\t>", "\n\\u003C/script\n\t>")]
        [DataRow("<<<</script", "<<<\\u003C/script")]
        [DataRow("<><></script", "<><>\\u003C/script")]
        [DataRow("</  script   >", "</  script   >")]
        [DataRow("<  /  script   >", "<  /  script   >")]
        [DataRow("-->", "--\\u003E")]
        [DataRow("-->>", "--\\u003E>")]
        [DataRow("<-->>", "<--\\u003E>")]
        [DataRow("-- >", "-- >")]
        [DataRow("  --\t\n>\n ", "  --\t\n>\n ")]
        public void JsonLdScriptEncoding(string content, string expected) => Assert.AreEqual(expected, XssPrevention.JsonLdScriptEncoding(content));
    }
}
