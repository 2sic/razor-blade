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
      var sanitizedText = Regex.Replace(original, @"<\/?" + Regex.Escape(tag) + @"\s*([a-zA-Z]*\s*=""?[^>]*""?\s*)*\s*\/?>", "", RegexOptions.IgnoreCase);
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
      string finalPattern = "<\\/?[a-zA-Z]*\\s*([a-zA-Z]*=\"?[^>]*\"?\\s*)*\\s*\\/?>";
      int place = 4;
      foreach (var tag in tags)
      {
        string conditionPattern = "(?!( |>|\\/|\n))";
        string insert = conditionPattern.Insert(3, tag);
        int tagLength = tag.Length;
        int insertLength = insert.Length;
        finalPattern = finalPattern.Insert(place, insert);
        place = place + tagLength + 14;
      }
      var sanitizedText = Regex.Replace(original, finalPattern, "", RegexOptions.IgnoreCase);
      return sanitizedText;
    }
  }
}

