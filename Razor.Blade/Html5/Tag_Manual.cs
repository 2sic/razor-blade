using ToSic.Razor.Html5;

// ReSharper disable once CheckNamespace
namespace ToSic.Razor.Blade
{
    public static partial class Tag
    {
        public static Comment Comment(string content = null) => new Comment(content) { IsImmutable = false };
    }
}
