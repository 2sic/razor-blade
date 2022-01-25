using System.Linq;
using System.Text.RegularExpressions;

namespace ToSic.Razor.Blade
{
  public partial class TagStripper
  {
    //Clean up space between tag-name and tag-ending (> or />)
    private string SpaceCleaning(string original)
    {
      original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\/?>)", "");
      return original;
    }

    ///<summary>
    /// Remove all HTML attributes.
    /// </summary>
    /// <param name="original">original string containing HTML</param>
    /// <returns>A string without any attributes inside the HTML Tags</returns>
    public string Attributes(string original)
    {
      //Remove all attributes with no quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(\w+)\s*=\s*[^ ""'=><`]+(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove all attributes with single quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(\w+)\s*=\s*(')[^']*(')(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove all attributes with double quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(\w+)\s*=\s*("")[^""]*("")(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove instances attributes where the attribute is declared without assigning an value to it
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(?<!(=(""|')([^>]*)|=[\w-]*|=))\b\w*\b(?!=)(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Clean up spaces between tag-name and first attribute
      original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\w*=)", " ");

      //Clean up space between tag-name and tag-ending (> or />)
      original = SpaceCleaning(original);

      return original;
    }

    ///<summary>
    /// Remove all instances of a specified attribute.
    /// </summary>
    /// <param name="original">original string containing HTML</param>
    /// <param name="attribute">string defining the attribute to remove</param>
    /// <returns>A string which doesn't contain the specified attribute</returns>
    public string Attributes(string original, string attribute)
    {
      //Remove certain attributes with no quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(" + Regex.Escape(attribute) + @")\s*=\s*[^ ""'=><`]+(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove certain attributes with single quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(" + Regex.Escape(attribute) + @")\s*=\s*(')[^']*(')(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove certain attributes with double quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(" + Regex.Escape(attribute) + @")\s*=\s*("")[^""]*("")(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove instances of a certain attribute where the attribute is declared without assigning an value to it
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(?<!(=(""|')([^>]*)|=[\\w-]*|=))\b" + Regex.Escape(attribute) + @"\b(?!=)(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Clean up spaces between tag-name and first attribute
      original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\w*=)", " ");

      //Clean up space between tag-name and tag-ending (> or />)
      original = SpaceCleaning(original);

      return original;
    }

    ///<summary>
    /// Remove all instances of an array of specified attributes.
    /// </summary>
    /// <param name="original">original string containing HTML</param>
    /// <param name="attributes">array defining the attributes to remove</param>
    /// <returns>A string which doesn't contain the specified attributes</returns>
    public string Attributes(string original, params string[] attributes)
    {
      foreach (var attribute in attributes)
      {
        original = Attributes(original, attribute);
      }
      return original;
    }
  }
}
