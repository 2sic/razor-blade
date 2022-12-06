﻿namespace ToSic.Razor.Markup
{
    /// <summary>
    /// Basis for either tags where the tag-name is given as parameter, or special tags like comments.
    /// </summary>
    public class TagCustom: Tag<TagCustom>
    {
        #region Constructors

        protected internal TagCustom(string name = null, TagOptions options = null)
            : base(name, options) { }

        protected internal TagCustom(string name, TagOptions options, object[] content)
            : base(name, options, content) { }

        #endregion

    }
}
