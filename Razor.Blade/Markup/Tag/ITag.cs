using System.Collections.Generic;

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
        /// The tag name
        /// </summary>
        string TagName { get; }

        /// <summary>
        /// Gets the HTML encoded value.
        /// </summary>
        string ToString();

        #region .Open and .Close

        RawHtmlString TagStart {get; }
        RawHtmlString TagEnd { get; }

        #endregion
    }
}
