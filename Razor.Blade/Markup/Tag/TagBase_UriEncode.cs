using ToSic.Razor.Internals;
using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Markup
{
    public partial class TagBase
    {
        [PrivateApi("Should remove soon, after auto-generated code is updated")]
        internal static string UriEncode(string url) => UriHelpers.UriEncode(url);

        [PrivateApi("Should remove soon, after auto-generated code is updated")]
        internal static string UriEncodeSrcSet(string srcset) => UriHelpers.UriEncodeSrcSet(srcset);

    }
}
