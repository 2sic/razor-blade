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

    /// regex explained:
    /// 1. Positive lookbehind (basically checks if there is an opening tag before the identifed attribute and only proceds with the match if that is true): 
    ///   (?<=<\w+\s+[^>]*)
    /// 
    /// 2. Match (matches one or more \w characters if there is only spaces or no spaces between it and the = character 
    ///   after it there can also be as zero or more spaces as soon as it detects a character it matches anything one or more times but doesn't match the content of the square brackets): 
    ///   (\w+)\s*=\s*[^ ""'=><`]+
    ///
    /// 3. Negative lookbehind (Basically checks if there is a closing tag somewhere after the attribute to make sure it doesnt match something that just looks like an attribute but isn't inside a HTML Tag):
    ///   (?=[^>]*\/?>)
    /// 
    /// This is only the regex that matches attributes with no quotes but the other work almost the same one just matches ' after the = and the other one " 


    private static string AttributePlaceholder = @"(\w+)"; // language=regex
    private static string AttributeRegexNoQuote = @"(?<=<\w+\s+[^>]*)(\w+)\s*=\s*[^ ""'=><`]+(?=[^>]*\/?>)"; // language=regex

    public string Attributes(string original)
    {
        //Remove all attributes with no quotes
      original = Regex.Replace(original, AttributeRegexNoQuote, "", RegexOptions.IgnoreCase);

      //Remove all attributes with single quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(\w+)\s*=\s*(')[^']*(')(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove all attributes with double quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(\w+)\s*=\s*("")[^""]*("")(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

            //Remove instances attributes where the attribute is declared without assigning an value to it
            original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(?<!(=(""|')([^>]*)|=[\w-]*|=))\b\w*\b(?!=)(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);
            //original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(?<!(=(""|')([^>]*)|=[\w-]*|=))\b(\w+)\b(?!=)(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

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

    ///regex explained: 
    ///Works almost the same as the regex above only instead of matching \w charcters before the = character it only matches the input attribute
    public string Attributes(string original, string attribute)
    {
        var escaped = Regex.Escape(attribute);
        // language=regex
        var regexNoQuotes = AttributeRegexNoQuote.Replace(AttributePlaceholder, escaped);

      //Remove certain attributes with no quotes
      original = Regex.Replace(original, regexNoQuotes, "", RegexOptions.IgnoreCase);

      //Remove certain attributes with single quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(" + escaped + @")\s*=\s*(')[^']*(')(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove certain attributes with double quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(" + escaped + @")\s*=\s*("")[^""]*("")(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove instances of a certain attribute where the attribute is declared without assigning an value to it
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(?<!(=(""|')([^>]*)|=[\\w-]*|=))\b" + escaped + @"\b(?!=)(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Clean up spaces between tag-name and first attribute
      original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\w*=)", " ");

      //Clean up space between tag-name and tag-ending (> or />)
      original = SpaceCleaning(original);

      return original;
    }
    private string AttributesInternal(string original, string attribute = null)
    {
        // todo: null-checks, empty-string checks
        if (string.IsNullOrWhiteSpace(original)) return original;

        var regexNoQuotes = AttributeRegexNoQuote;

        var escaped = Regex.Escape(attribute);
        if (attribute != null)
        {
            regexNoQuotes = regexNoQuotes.Replace(AttributePlaceholder, escaped);
        }

      //Remove certain attributes with no quotes
      original = Regex.Replace(original, regexNoQuotes, "", RegexOptions.IgnoreCase);

      //Remove certain attributes with single quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(" + escaped + @")\s*=\s*(')[^']*(')(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove certain attributes with double quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(" + escaped + @")\s*=\s*("")[^""]*("")(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove instances of a certain attribute where the attribute is declared without assigning an value to it
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(?<!(=(""|')([^>]*)|=[\\w-]*|=))\b" + escaped + @"\b(?!=)(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

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
