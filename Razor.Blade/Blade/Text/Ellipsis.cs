using ToSic.Razor.Internals;

namespace ToSic.Razor.Blade
{
    public static partial class Text
    {

        /// <summary>
        /// Crop a text if too long, add in that case, also add an ellipsis &amp;hellip; or a custom suffix (optional)
        /// </summary>
        /// <param name="value">Value to maybe truncate (using safe-truncate - see Text.Crop)</param>
        /// <param name="length">Max length to keep</param>
        /// <param name="suffix">optional suffix, defaults to  &amp;hellip;</param>
        /// <remarks>If you don't need the suffix, use CropText(...) instead</remarks>
        /// <returns></returns>
        public static string Ellipsis(this string value, int length, string suffix = null)
        {
            var truncated = Truncator.SafeTruncate(value, length);
            var addExtension = truncated != value;
            var extension = addExtension ? (suffix ?? Defaults.HtmlEllipsisCharacter) : "";
            return truncated + extension;
        }



    }
}
