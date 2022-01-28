using System.Linq;
using System.Text.RegularExpressions;

namespace ToSic.Razor.Blade
{
    public partial class TagStripper
    {
        ///<summary>
        /// Remove all style attributes
        /// </summary>
        /// <param name="original">original string containing HTML</param>
        /// <returns>A string without any style=""/style=''/style= attributes</returns>
        public string Styles(string original)
        {
            // Null check
            if (original == null)
                return original;

            original = Attributes(original, "style");

            return original;
        }
    }
}
