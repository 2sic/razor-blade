using System;
using static System.StringComparison;

namespace ToSic.Razor.Blade
{
    public static partial class Text
    {

        /// <summary>
        /// Get string value before the key.
        /// Case insensitive by default. 
        /// Will return null in various cases which don't make sense or if not found.
        /// Very safe and robust, fully tested.
        /// </summary>
        /// <param name="value">The initial string. If null, will always return null</param>
        /// <param name="key">The key to find. If null, will always return null</param>
        /// <param name="caseSensitive">Set to true if you need case-sensitive compare</param>
        /// <returns></returns>
        /// <remarks>New in v3.09</remarks>
        public static string Before(this string value, string key, bool caseSensitive = false)
            => value.BeforeInternal(key, caseSensitive ? Ordinal : InvariantCultureIgnoreCase);

        /// <summary>
        /// Get string value before the last occurrence of a key.
        /// Case insensitive by default. 
        /// Will return null in various cases which don't make sense or if not found.
        /// Very safe and robust, fully tested.
        /// </summary>
        /// <param name="value">The initial string. If null, will always return null</param>
        /// <param name="key">The key to find. If null, will always return null</param>
        /// <param name="caseSensitive">Set to true if you need case-sensitive compare</param>
        /// <returns></returns>
        /// <remarks>New in v3.09</remarks>
        public static string BeforeLast(this string value, string key, bool caseSensitive = false)
            => value.BeforeInternal(key, caseSensitive ? Ordinal : InvariantCultureIgnoreCase, true);

        private static string BeforeInternal(this string value, string key, StringComparison comparison, bool findLast = false, string fallback = null)
        {
            if (value == null || key == null) return fallback;
            var posA = findLast ? value.LastIndexOf(key, comparison) : value.IndexOf(key, comparison);
            if (posA == -1) return fallback;
            return value.Substring(0, posA);
        }
    }
}
