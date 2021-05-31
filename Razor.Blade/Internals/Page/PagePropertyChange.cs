using ToSic.Razor.Blade;

namespace ToSic.Razor.Internals.Page
{
    public struct PagePropertyChange
    {
        public ChangeModes ChangeMode;
        
        internal PageProperties Property;
        
        public string Value;

        /// <summary>
        /// This is part of the original property, which would be replaced.
        /// </summary>
        public string ReplacementIdentifier;
    }
}
