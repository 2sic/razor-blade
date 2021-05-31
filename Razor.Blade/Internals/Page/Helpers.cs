using System;
using ToSic.Razor.Blade;

namespace ToSic.Razor.Internals.Page
{
    public class Helpers
    {
        public static string UpdateProperty(string original, PagePropertyChange change)
        {
            if (string.IsNullOrEmpty(original)) return change.Value ?? original;

            if (!string.IsNullOrEmpty(change.ReplacementIdentifier))
            {
                var pos = original.IndexOf(change.ReplacementIdentifier, StringComparison.InvariantCultureIgnoreCase);
                if (pos >= 0)
                {
                    var suffixPos = pos + change.ReplacementIdentifier.Length;
                    var suffix = (suffixPos < original.Length ? original.Substring(suffixPos) : "");
                    return original.Substring(0, pos) + change.Value + suffix;
                }

                if (change.ChangeMode == ChangeModes.ReplaceOrSkip) return original;
            }

            switch (change.ChangeMode)
            {
                case ChangeModes.Default:
                case ChangeModes.Auto:
                case ChangeModes.Replace:
                    return change.Value ?? original;
                case ChangeModes.Append:
                    return original + change.Value;
                case ChangeModes.Prepend:
                    return change.Value + original;
                case ChangeModes.ReplaceOrSkip:
                    return original;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
