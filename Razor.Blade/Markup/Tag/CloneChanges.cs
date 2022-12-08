using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Markup
{
    [PrivateApi]
    public class CloneChanges
    {
        internal TagChildren Children;
        internal Attributes Attributes;
        internal TagOptions Options;
    }
}
