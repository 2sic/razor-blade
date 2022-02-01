﻿using System.Collections;
using System.Collections.Generic;
using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Markup
{
    public partial class TagBase: IEnumerable<ITag>
    {
        public ChildTags TagChildren => _children ?? (_children = new ChildTags());
        private ChildTags _children;

        /// <summary>
        /// The contents of this tag
        /// </summary>
        public string TagContents
        {
            get => TagChildren.Build(RealOptions);
            set => TagChildren.Replace(value);
        }

        /// <summary>
        /// A full override of the internal mechanisms of this tag
        /// It's usually used to create very special tags like comments
        /// if it is set, all other mechanisms will not do anything
        /// so no attributes, no content etc.
        /// </summary>
        /// <remarks>Must be null to be deactivated</remarks>
        internal string TagOverride;

        /// <inheritdoc />
        [PrivateApi]
        IEnumerator<ITag> IEnumerable<ITag>.GetEnumerator() => TagChildren.GetEnumerator();

        /// <inheritdoc />
        [PrivateApi]
        public IEnumerator GetEnumerator() => TagChildren.GetEnumerator();
    }
}
