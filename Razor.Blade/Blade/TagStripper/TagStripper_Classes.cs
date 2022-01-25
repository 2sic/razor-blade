using System.Linq;
using System.Text.RegularExpressions;

namespace ToSic.Razor.Blade
{
  public partial class TagStripper
  {
    ///<summary>
    /// Remove all class attributes
    /// </summary>
    /// <param name="original">original string containing HTML</param>
    /// <returns>A string without any class=""/class=''/class= attributes</returns>
    public string Classes(string original)
    {
      string StripClasses(string originalText, string attribute) => new TagStripper().Attributes(original, attribute);

      original = StripClasses(original, "class");

      return original;
    }
  }
}
