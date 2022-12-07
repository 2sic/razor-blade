using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Markup
{
    [PrivateApi]
    public class CloneChanges
    {
        internal ChildTags Children;
        internal AttributeList Attributes;
        internal TagOptions Options;
    }
}
