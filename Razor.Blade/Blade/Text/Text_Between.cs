using System;
using static System.StringComparison;

namespace ToSic.Razor.Blade
{
    public static partial class Text
    {
        /// <summary>
        /// Get the text between two keys
        /// </summary>
        /// <param name="value">The initial string. If null, will always return null</param>
        /// <param name="before">The key to find in front of what we're looking for. If null, will always return null</param>
        /// <param name="after">The key to find in front of what we're looking for. If null, will always return null</param>
        /// <param name="goToEndIfEndNotFound">If true and the end isn't found, it will return the rest of the string</param>
        /// <param name="caseSensitive">Set to true if you need case-sensitive compare</param>
        /// <returns></returns>
        /// <remarks>New in v3.09</remarks>
        public static string Between(this string value, string before, string after, bool goToEndIfEndNotFound = false, bool caseSensitive = false)
            => value.BetweenInternal(before, after, goToEndIfEndNotFound, null, caseSensitive ? Ordinal : InvariantCultureIgnoreCase);


        /// <summary>
        /// Get string value between [first] a and [last] b.
        /// </summary>
        private static string BetweenInternal(
            this string value,
            string before,
            string after,
            bool goToEndIfEndNotFound = false,
            string fallback = null,
            StringComparison comparison = InvariantCultureIgnoreCase
        )
        {
            if (value == null || before == null || after == null) return fallback;

            var trimStart = value.AfterInternal(before, comparison);
            if (trimStart == null) return fallback;
            var result = trimStart.BeforeInternal(after, comparison);
            if (result == null && goToEndIfEndNotFound) return trimStart;
            return result;
        }
    }
}
