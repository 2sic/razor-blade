﻿
namespace ToSic.Razor.Blade
{
    // Encode a string for placing in the source of html or an attribute
    partial class Tags
    {
        /// <summary>
        /// Safely encode a string for representation into html.
        /// Special note: apostrophes are encoded as &apos;, not as &#34;
        /// </summary>
        /// <param name="value">original value</param>
        /// <returns>encoded string</returns>
        public static string Encode(string value) 
            => Internals.Html.Encode(value);

        /// <summary>
        /// Decode an encoded html back into a normal string.
        /// </summary>
        /// <param name="value">encoded string</param>
        /// <returns>shorter, unencoded string</returns>
        public static string Decode(string value) 
            => Internals.Html.Decode(value);
    }
}
