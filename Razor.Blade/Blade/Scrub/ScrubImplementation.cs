using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Blade
{
    /// <summary>
    /// Scrub helps wash/clean html from things you want removed. It can take care of all tags, just specific tags or certain attributes.
    ///
    /// IMPORTANT: It has a long, cumbersome name on purpose, to ensure it's not accidentally used from external code.
    /// So don't rename it to "Scrub" because that increases the risk that it just gets used without us intending it.
    /// </summary>
    [PrivateApi]
    public partial class ScrubImplementation: IScrub
    {
        public ScrubImplementation() {}
    }
}
