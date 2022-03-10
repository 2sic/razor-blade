using System;
using System.Linq;
using System.Text.RegularExpressions;
using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Internals
{
    /// <summary>
    /// Made public to enable consistent use in 2sxc, but can still change at any time so not really public
    /// </summary>
    [PrivateApi]
    public class UriHelpers
    {
        public static string UriEncode(string url)
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

        public static string UriEncodeSrcSet(string srcset)
        {
            if (string.IsNullOrWhiteSpace(srcset)) return srcset;

            // split items and drop new-lines and leading/trailing spaces
            var items = srcset
                .Split(',')
                .Select(s => Blade.Text.Nl2X(s, "").Trim())
                .Select(CleanASrcSetLine);

            // If the original had line breaks, add them in again
            // This is not 100% identical to the original, but in most cases it will be identical
            var nl = Environment.NewLine;
            var noNewLine = !srcset.Contains(nl);
            var prefix = noNewLine ? "" : srcset.StartsWith(nl) ? nl : "";
            var suffix = noNewLine ? "" : srcset.EndsWith(nl) ? nl : "";
            var reJoiner = noNewLine ? "," : "," + nl;

            return prefix + string.Join(reJoiner, items) + suffix;

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
