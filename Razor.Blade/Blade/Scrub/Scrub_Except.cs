using System.Linq;
using System.Text.RegularExpressions;

namespace ToSic.Razor.Blade
{
    public partial class ScrubImplementation
    {
        ///<summary>
        /// Remove all HTML Tags exept of a specified list
        /// </summary>
        /// <param name="html">original string containing HTML</param>
        /// <param name="tags">array defining the HTML Tags which shouldn't be removed</param>
        /// <returns>A string which doesn't contain the specified HTML Tags</returns>
        public string Except(string html, params string[] tags)
        {
            // Null check
            if (tags == null || !tags.Any() || html == null)
                return html;

            //var exceptList = string.Join("|", tags.Select(t => t + "( |>|\\/|\n)"));
            var exceptList = string.Join("|", tags.Select(tag => tag + "( |>|\\/|\n)"));

            var exceptRule = "(?!" + exceptList + ")";

            //Combines the created pattern with the final pattern 
            exceptRule = "<\\/?" + exceptRule + "[a-zA-Z]+\\s*([a-zA-Z\\s]*\\s*=(\"|')?[^>]*(\"|')?\\s*)*\\s*\\/?>"; // language=regex

            //Use the created pattern to replace the tags 
            var sanitizedText = Regex.Replace(html, exceptRule, "", RegexOptions.IgnoreCase);

            return sanitizedText;
        }
    }
}
