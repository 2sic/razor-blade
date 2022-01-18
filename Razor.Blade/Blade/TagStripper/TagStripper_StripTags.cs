using System.Text.RegularExpressions;

namespace ToSic.Razor.Blade
{
  public partial class TagStripper
  {
    /// <summary>
    /// Remove all HTML tags from a string.
    /// </summary>
    /// <param name="original">original string containing HTML</param>
    /// <returns>A cleaned string without any HTML tags</returns>
    /// <remarks>
    /// Added in v2
    /// </remarks>
    public string All(string original)
    {
      // Extra null check
      if (original is null) return null;
      // remove all tags, replace with spaces to prevent words from sticking together
      var sanitizedText = Regex.Replace(original, "<[^>]*>", " ", RegexOptions.IgnoreCase);

      // remove remaining < and >
      // because there could still be some unmatched "<" or ">" characters 
      // this is unlikely, but otherwise an attacker knowing these internals could abuse this
      sanitizedText = sanitizedText.Replace("<", " ").Replace(">", " ");

      // combine resulting multi-spaces
      sanitizedText = Text.ShrinkSpaces(sanitizedText);

      return sanitizedText.Trim();
    }

    /// <summary>
    /// Remove one specific HTML tag from a string.
    /// </summary>
    /// <param name="original">original string containing HTML</param>
    /// <param name="tag">tag name to remove</param>
    /// <returns></returns>
    /// <remarks>
    /// Added in v3.9
    /// </remarks>
    public string Only(string original, string tag)
    {
      //Remove the selected tags
      var sanitizedText = Regex.Replace(original, @"<\/?" + Regex.Escape(tag) + @"\s*([a-zA-Z\\s]*\s*=(""|')?[^>]*(""|')?\s*)*\s*\/?>", "", RegexOptions.IgnoreCase);
      return sanitizedText;
    }

    /// <summary>
    /// Remove many specific HTML tags from a string.
    /// </summary>
    /// <param name="original">original string containing HTML</param>
    /// <param name="tags">one or more tags to remove</param>
    /// <returns></returns>
    /// <remarks>
    /// Added in v3.9
    /// </remarks>
    public string Only(string text, params string[] tags)
    {
      string StripTags(string original, string tag) => new TagStripper().Only(original, tag);

      foreach (var tag in tags)
      {
        text = StripTags(text, tag);
      }
      return text;
    }

    public string Except(string original, params string[] tags)
    {
      //The pattern that is used to match the tags
      string finalPattern = "<\\/?[a-zA-Z]+\\s*([a-zA-Z\\s]*\\s*=(\"|')?[^>]*(\"|')?\\s*)*\\s*\\/?>";

      //Place defines the value where the first excluding pattern must be inserted 
      int place = 4;

      foreach (var tag in tags)
      {

        //Pattern to exclude inserted tag from the regex match 
        string conditionPattern = "(?!( |>|\\/|\n))";

        //Insert tag into pattern that is needed to exclude the tag from the regex match 
        string insertPattern = conditionPattern.Insert(3, tag);

        //Getting the length of the two 
        int tagLength = tag.Length;

        //Inserting the string with the pattern that was just created into the final pattern 
        finalPattern = finalPattern.Insert(place, insertPattern);

        //Calculating where the insertPattern needs to be inserted into the final pattern in the next pass of the loop
        place = place + tagLength + 14;
      }
      //Use the created pattern to replace the tags 
      var sanitizedText = Regex.Replace(original, finalPattern, "", RegexOptions.IgnoreCase);
      return sanitizedText;
    }

    //Delete all attributes
    public string Attributes(string original)
    {
      //Remove all attributes with no quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(\w+)\s*=\s*[^ ""'=><`]+(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove all attributes with single quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(\w+)\s*=\s*(')[^']*(')(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove all attributes with double quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(\w+)\s*=\s*("")[^""]*("")(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Clean up spaces between tag-name and first attribute
      original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\w*=)", " ");
      //Clean up space between tag-name and tag-ending (> or />)
      original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\/?>)", "");
      return original;
    }

    //Delete all instances of a single attribute
    public string Attributes(string original, string attribute)
    {
      //Remove certain attributes with no quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(" + Regex.Escape(attribute) + @")\s*=\s*[^ ""'=><`]+(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove certain attributes with single quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(" + Regex.Escape(attribute) + @")\s*=\s*(')[^']*(')(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Remove certain attributes with double quotes
      original = Regex.Replace(original, @"(?<=<\w+\s+[^>]*)(" + Regex.Escape(attribute) + @")\s*=\s*("")[^""]*("")(?=[^>]*\/?>)", "", RegexOptions.IgnoreCase);

      //Clean up spaces between tag-name and first attribute
      original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\w*=)", " ");

      //Clean up space between tag-name and tag-ending (> or />)
      original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\/?>)", "");

      return original;
    }

    //Delete all instances of a list of attributes
    public string Attributes(string original, params string[] attributes)
    {
      string StripAttributes(string originalText, string attribute) => new TagStripper().Attributes(original, attribute);

      foreach (var attribute in attributes)
      {
        original = StripAttributes(original, attribute);
      }
      return original;
    }
    public string Classes(string original)
    {
      //Remove class attributes defined with double-quotes
      original = Regex.Replace(original, "(?<=<\\w+\\s+[^>]*)(class)\\s*=\\s*(\")[^\"]*(\")(?=[^>]*\\/?>)", "", RegexOptions.IgnoreCase);

      //Remove class attributes defined with single-quotes
      original = Regex.Replace(original, "(?<=<\\w+\\s+[^>]*)(class)\\s*=\\s*(')[^']*(')(?=[^>]*\\/?>)", "", RegexOptions.IgnoreCase);
      
      //Remove class attributes defined without quotes
      original = Regex.Replace(original, "(?<=<\\w+\\s+[^>]*)(class)\\s*=\\s*[^ \"'=><`]+(?=[^>]*\\/?>)", "", RegexOptions.IgnoreCase);

      //Clean up spaces between tag-name and first attribute
      original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\w*=)", " ");

      //Clean up space between tag-name and tag-ending (> or />)
      original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\/?>)", "");

      return original;
    }
  }

  //Tag sets to be used in combination with TagStripper.Exclude()
  public partial class TagSets
  {
    public static readonly string[] Formatting = { "!DOCTYPE","html","head","title","body","h1","h2","h3","h4","h5","h6","p","br","hr","acronym", "abbr", "address", "b", "bdi", "bdo", "big", "blockquote", "center", "cite", "code", "del", "dfn", "em", "font", "i", "ins", "kbd", "mark", "meter", "pre", "progress", "q", "rp", "rt", "ruby", "s", "samp", "small", "strike", "strong", "sub", "sup", "template", "time", "time", "tt", "u", "var", "wbr" };
    public static readonly string[] FormattingSimple = { "h1", "h2", "h3", "h4", "h5", "h6","b", "big","center","em","i","mark","q","small","strong" };
    public static readonly string[] InlineBasic = {"a", "b","big","br","em","i","img","q", "small","span","strong"};
  }
}

