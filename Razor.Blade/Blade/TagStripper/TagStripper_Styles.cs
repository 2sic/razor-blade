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
      string StripClasses(string originalText, string attribute) => new TagStripper().Attributes(original, attribute);

      original = StripClasses(original, "style");

      return original;
    }
  }
}
