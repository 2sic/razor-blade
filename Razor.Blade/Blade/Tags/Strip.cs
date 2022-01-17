using System.Text.RegularExpressions;

namespace ToSic.Razor.Blade
{
  public static partial class Tags
  {
    public static string Strip(string original)
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

    public static string Strip(string original, string removeTag)
    {
      //Remove the selected tags
      var sanitizedText = Regex.Replace(original, @"<\/?" + Regex.Escape(removeTag) + @"\s*([a-zA-Z]*\s*=""?[^>]*""?\s*)*\s*\/?>", "", RegexOptions.IgnoreCase);

      sanitizedText = Regex.Replace(sanitizedText, "^ ", "", RegexOptions.IgnoreCase);
      sanitizedText = Regex.Replace(sanitizedText, " $", "", RegexOptions.IgnoreCase);

      return sanitizedText;
    }

    public static string Strip(string original, params string[] tags)
    {
      foreach (var tag in tags)
      {
        original = Regex.Replace(original, @"<\/?" + Regex.Escape(tag) + @"\s*([a-zA-Z]*\s*=""?[^>]*""?)*\s*\/?>", "", RegexOptions.IgnoreCase);
      }
      return original;
    }
  }
}

