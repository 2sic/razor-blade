using System.Linq;

namespace ToSic.Razor.Blade
{
    public static partial class Text
    {
        /// <summary>
        /// Try to return the first possible value, but if it's empty, return null
        /// </summary>
        /// <param name="values">array of values to check consecutively</param>
        /// <returns></returns>
        public static string First(params string[] values)
            => First(true, values);

        /// <summary>
        /// Try to return the first possible value, but if it's empty, return null
        /// </summary>
        /// <param name="values">array of values to check consecutively</param>
        /// <param name="handleHtmlWhitespaces">if true (default) will treat html-whitespace as a space</param>
        /// <returns></returns>
        public static string First(bool handleHtmlWhitespaces = true, params string[] values) 
            => values.FirstOrDefault(value => Has(value, handleHtmlWhitespaces));

    }
}
