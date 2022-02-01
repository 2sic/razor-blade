using ToSic.Razor.Internals;
// ReSharper disable UnusedMember.Global

namespace ToSic.Razor.Blade
{
    public static partial class Text
    {
        /// <summary>
        /// Cut off a text at the best possible place with a max-length. 
        /// This will count html-entities like &amp;, &amp;nbsp; or umlauts as 1 character, 
        /// and will try to cut off between words if possible.
        /// So it will backtrack to the previous space.
        /// </summary>
        /// <param name="value">String to cut off. Can contain umlauts and html-entities, but should not contain html-tags as there are not treated properly.</param>
        /// <param name="length">length to cut off at</param>
        /// <returns></returns>
        public static string Crop(this string value, int length) => Truncator.SafeTruncate(value, length);
    }
}
