using ToSic.Razor.Internals;

namespace ToSic.Razor.Markup
{
    public partial class TagBase
    {
        internal static string UriEncode(string url) => UriHelpers.UriEncode(url);

        internal static string UriEncodeSrcSet(string srcset) => UriHelpers.UriEncodeSrcSet(srcset);

    }
}
