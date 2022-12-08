using ToSic.Razor.Internals.Documentation;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Blade
{
    /// <summary>
    /// Public interface for all Html5Tags
    /// </summary>
    public interface IHtmlTag: ITag
    {
        /// <summary>
        /// Quickly add an attribute
        /// it always returns the tag itself again, allowing chaining of multiple add-calls
        /// </summary>
        /// <param name="name">the attribute name, or a complete value like "name='value'"</param>
        /// <param name="value">optional value - if the attribute already exists, it will be appended</param>
        /// <param name="appendSeparator">attribute appendSeparator in case the value is appended</param>
        /// <returns>A new <see cref="IHtmlTag"/> object with the changes, allowing a fluid API</returns>
        IHtmlTag Attr(string name, object value = null, string appendSeparator = null);

        /// <summary>
        /// Quickly add an attribute
        /// it always returns the tag itself again, allowing chaining of multiple add-calls
        /// </summary>
        /// <param name="nameWithValue">Object which can be ToString()ed</param>
        /// <returns>A new <see cref="IHtmlTag"/> object with the changes, allowing a fluid API</returns>
        IHtmlTag Attr(object nameWithValue);

        /// <summary>
        /// ID - set multiple times always overwrites previous ID
        /// </summary>
        /// <returns>A new <see cref="IHtmlTag"/> object with the changes, allowing a fluid API</returns>
        IHtmlTag Id(string id);

        /// <summary>
        /// class attribute
        /// </summary>
        /// <returns>A new <see cref="IHtmlTag"/> object with the changes, allowing a fluid API</returns>
        IHtmlTag Class(string value);

        /// <summary>
        /// style attribute. If called multiple times, will append styles.
        /// </summary>
        /// <param name="value">Style to add</param>
        /// <returns>A new <see cref="IHtmlTag"/> object with the changes, allowing a fluid API</returns>
        IHtmlTag Style(string value);

        /// <summary>
        /// title attribute
        /// </summary>
        /// <param name="value">new title to set</param>
        /// <returns>A new <see cref="IHtmlTag"/> object with the changes, allowing a fluid API</returns>
        IHtmlTag Title(string value);

        /// <summary>
        /// Add a data-... attribute
        /// </summary>
        /// <param name="name">the term behind data-, so "name" becomes "data-name". If empty, will just create a "data" attribute</param>
        /// <param name="value">string or object, objects will be json serialized</param>
        /// <returns>A new <see cref="IHtmlTag"/> object with the changes, allowing a fluid API</returns>
        IHtmlTag Data(string name, object value = null);

        /// <summary>
        /// Add a onEventName attribute for javascript events
        /// </summary>
        /// <param name="name">the term behind data-, so "name" becomes "data-name"</param>
        /// <param name="value">string or object, objects will be json serialized</param>
        /// <returns>A new <see cref="IHtmlTag"/> object with the changes, allowing a fluid API</returns>
        IHtmlTag On(string name, object value = null);

        /// <summary>
        /// Add contents to this tag - at the end of the already added contents.
        /// If you want to replace the contents, use Wrap() instead
        /// </summary>
        /// <param name="children">a variable amount of tags / strings to add to the contents of this tag</param>
        /// <returns>A new <see cref="IHtmlTag"/> object with the changes, allowing a fluid API</returns>
        IHtmlTag Add(params object[] children);

        /// <summary>
        /// Wrap the tag around the new content, so this replaces all the content with what you give it
        /// </summary>
        /// <param name="content">a variable amount of tags / strings to add to the contents of this tag</param>
        /// <returns>A new <see cref="IHtmlTag"/> object with the changes, allowing a fluid API</returns>
        IHtmlTag Wrap(params object[] content);


        /// <summary>
        /// Cast a Tag to <see cref="IHtmlTag"/>, as it will make certain changes easier to manage.
        ///
        /// Example: You may have different code returning a span, div, whatever and need to add the link.
        /// In this case each code would return a different object, which may make it hard to program.
        /// So just run AsHtmlTag() so it becomes a more generic object but still has all the common Id, Class, Wrap etc.
        /// </summary>
        /// <returns></returns>
        IHtmlTag AsHtmlTag();
    }
}
