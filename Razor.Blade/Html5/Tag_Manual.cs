using Connect.Razor.Html5;

// ReSharper disable once CheckNamespace
namespace Connect.Razor.Blade
{
    public static partial class Tag
    {
        public static Comment Comment(string content = null) => new Comment(content);
    }
}
