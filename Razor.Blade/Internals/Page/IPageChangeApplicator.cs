using ToSic.Razor.Blade;

namespace ToSic.Razor.Internals.Page
{
    public interface IPageChangeApplicator
    {
        IPage HtmlPage { get; }
        int Apply();
    }
}
