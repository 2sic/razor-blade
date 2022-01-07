using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ToSic.Razor.Markup
{
    public partial class TagBase
    {
        internal static string UriEncode(string url)
        {
            if (string.IsNullOrEmpty(url)) return url;

            // more difficult case: %-character detected
            // maybe we want it - like in ?title=I want 25%
            // but most likely it's already encoded - like when an umlaut was already converted
            // check if it has any existing encode sequences
            // if it does, don't encode again
            if (url.Contains("%")
                && Regex.IsMatch(url, @"(?:%[0-9A-Fa-f]{2})"))
                return url;

            // simple use case - no % character in url
            // or the % wasn't just used for encoding
            // so just perform standard encoding
            return Uri.EscapeUriString(url).Replace("'", "%27");
        }

        internal static string UriEncodeSrcSet(string srcSet)
        {
            if (string.IsNullOrWhiteSpace(srcSet)) return srcSet;

            // split items and drop new-lines and leading/trailing spaces
            var items = srcSet
                .Split(',')
                .Select(s => Blade.Text.Nl2X(s, "").Trim())
                .Select(CleanASrcSetLine);

            return string.Join(",", items);

            string CleanASrcSetLine(string line)
            {
                var matches = Regex.Matches(line, @"^(.*)(\s\d+[xw])$");
                // we expect 3 hits, #0 is everything, #1 the first hit and #2 the resolution
                if (matches.Count == 0 || matches[0].Groups.Count != 3) return UriEncode(line);

                var url = matches[0].Groups[1].Value;
                var ext = matches[0].Groups[2].Value;
                return UriEncode(url) + ext;
            }
        }

        
    }
}
