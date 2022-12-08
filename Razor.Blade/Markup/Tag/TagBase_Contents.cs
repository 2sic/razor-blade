using System.Collections;
using System.Collections.Generic;
using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Markup
{
    public partial class TagBase: IEnumerable<ITag>
    {
        /// <remarks>Set may only be called once, on ApplyChanges</remarks>
        public TagChildren TagChildren { get; private set; }

        // set => TagChildren.Replace(value);
        /// <summary>
        /// A full override of the internal mechanisms of this tag
        /// It's usually used to create very special tags like comments
        /// if it is set, all other mechanisms will not do anything
        /// so no attributes, no content etc.
        /// </summary>
        /// <remarks>Must be null to be deactivated</remarks>
        internal string TagOverride { get; }

        /// <inheritdoc />
        [PrivateApi]
        IEnumerator<ITag> IEnumerable<ITag>.GetEnumerator() => TagChildren.List.GetEnumerator();

        /// <inheritdoc />
        [PrivateApi]
        public IEnumerator GetEnumerator() => TagChildren.List.GetEnumerator();
    }
}
