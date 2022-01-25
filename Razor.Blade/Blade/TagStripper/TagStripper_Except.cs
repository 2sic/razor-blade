using System.Linq;
using System.Text.RegularExpressions;

namespace ToSic.Razor.Blade
{
  public partial class TagStripper
  {
    ///<summary>
    /// Remove all HTML Tags exept of a specified list
    /// </summary>
    /// <param name="original">original string containing HTML</param>
    /// <param name="tags">array defining the HTML Tags which shouldn't be removed</param>
    /// <returns>A string which doesn't contain the specified HTML Tags</returns>
    public string Except(string original, params string[] tags)
    {
      //Pattern that is used to build the exeption to the normal tag searching regex
      var insertPattern = "";
      var i = 0;

      // Null check
      if (tags == null || tags.Length == 0)
      {
        return original;
      }

      foreach (var tag in tags)
      {
        //If else condition determins if it is the first pass through the loop if it is it doesn't add a "|" on every other pass it does
        if (i == 0)
        {
          insertPattern = insertPattern + tag + "( |>|\\/|\n)";
          i++;
        }
        else
        {
          insertPattern = insertPattern + "|" + tag + "( |>|\\/|\n)";
        }
      }

      insertPattern = "(?!" + insertPattern + ")";

      //Combines the created pattern with the final pattern 
      insertPattern = "<\\/?" + insertPattern + "[a-zA-Z]+\\s*([a-zA-Z\\s]*\\s*=(\"|')?[^>]*(\"|')?\\s*)*\\s*\\/?>";

      //Use the created pattern to replace the tags 
      var sanitizedText = Regex.Replace(original, insertPattern, "", RegexOptions.IgnoreCase);

      return sanitizedText;
    }
  }
}
