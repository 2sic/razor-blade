using ToSic.Razor.Markup;

namespace ToSic.Razor.Blade
{
    /// <summary>
    /// Public interface for all Html5Tags
    /// </summary>
    public interface IHtmlTag: ITag
    {
        ChildTags TagChildren { get; }
        string TagContents { get; set; }

        IHtmlTag Attr(string name, object value = null, string appendSeparator = null);

        IHtmlTag Attr(object nameWithValue);

        IHtmlTag Id(string id);

        IHtmlTag Class(string value);

        IHtmlTag Style(string value);

        IHtmlTag Title(string value);

        IHtmlTag Data(string name, object value = null);

        IHtmlTag On(string name, object value = null);

        IHtmlTag Add(params object[] children);

        IHtmlTag Wrap(params object[] content);
    }
}
