using ToSic.Razor.Blade;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Internals.Page
{
    public struct HeadChange
    {
        public ChangeModes ChangeMode;

        public TagBase Tag;

        /// <summary>
        /// This is part of the original property, which would be replaced.
        /// </summary>
        public string ReplacementIdentifier;
    }
}
