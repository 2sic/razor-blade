namespace ToSic.Razor.Blade
{
  /// <summary>
  /// Tag sets to be used in combination with TagStripper.Exclude()
  /// </summary>
  public class TagSets
  {
    /// <summary>
    /// array containing all formatting HTML Tags 
    /// </summary>
    public static readonly string[] Formatting = {
      "acronym",
      "abbr",
      "address",
      "b",
      "bdi",
      "bdo",
      "big",
      "blockquote",
      "center",
      "cite",
      "code",
      "del",
      "dfn",
      "em",
      "font",
      "i",
      "ins",
      "kbd",
      "mark",
      "meter",
      "pre",
      "progress",
      "q",
      "rp",
      "rt",
      "ruby",
      "s",
      "samp",
      "small",
      "strike",
      "strong",
      "sub",
      "sup",
      "template",
      "time",
      "time",
      "tt",
      "u",
      "var",
      "wbr"
    };

    /// <summary>
    /// array containing a list of common formatting HTML Tags
    /// </summary>
    public static readonly string[] FormattingSimple = {
      "h1",
      "h2",
      "h3",
      "h4",
      "h5",
      "h6",
      "b",
      "big",
      "center",
      "em",
      "i",
      "mark",
      "q",
      "small",
      "strong"
    };

    /// <summary>
    /// array containing the most common inline HTML Tags
    /// </summary>
    public static readonly string[] InlineBasic = {
      "a",
      "b",
      "big",
      "br",
      "em",
      "i",
      "img",
      "q",
      "small",
      "span",
      "strong"
    };
  }
}