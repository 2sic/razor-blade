using System.Collections.Generic;
using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Markup
{
    /// <summary>
    /// Standardizes what Tag-objects can do - valid for all Html and Svg tags.
    /// </summary>
    public interface ITag: IEnumerable<ITag>
    {
        /// <summary>
        /// All attributes of this tag
        /// </summary>
        Attributes TagAttributes { get; }

        /// <summary>
        /// List of child tags inside this tag.
        /// </summary>
        TagChildren TagChildren { get; }

        /// <summary>
        /// The options which determine how the tag will be generated.
        /// </summary>
        TagOptions TagOptions { get; }

        /// <summary>
        /// The tag name
        /// </summary>
        string TagName { get; }

        /// <summary>
        /// Gets the HTML encoded value.
        /// </summary>
        string ToString();

        /// <summary>
        /// ToString with custom options how to get it done.
        /// </summary>
        /// <param name="optionsOrNull"></param>
        /// <returns></returns>
        [PrivateApi]
        string ToString(TagOptions optionsOrNull);

        #region .Open and .Close

        RawHtmlString TagStart {get; }
        RawHtmlString TagEnd { get; }

        #endregion
    }
}
