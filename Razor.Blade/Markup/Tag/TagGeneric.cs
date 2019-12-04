using System;
using System.Collections.Generic;
using System.Text;

namespace ToSic.Razor.Markup
{
    public class TagGeneric: Tag<TagGeneric>
    {
        #region Constructors

        internal TagGeneric(string name = null, TagOptions options = null)
            : base(name, options) { }

        internal TagGeneric(string name, object content, TagOptions options = null)
            : base(name, options) { }

        internal TagGeneric(string name, TagOptions options, object[] content)
            : base(name, options, content) { }

        #endregion

    }
}
