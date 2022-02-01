using System;

namespace ToSic.Razor.Blade
{
  public static partial class Tags
  {
    /// <summary>
    /// Remove all HTML tags from a string.
    /// </summary>
    /// <param name="original">original string containing HTML</param>
    /// <returns>A cleaned string without any HTML tags</returns>
    /// <remarks>
    /// Added in v2
    /// </remarks>
    [Obsolete("Starting in V3.9 we suggest you use Scrub.All(...) instead")]
    public static string Strip(string original) => new Scrub().All(original);
  }
}
