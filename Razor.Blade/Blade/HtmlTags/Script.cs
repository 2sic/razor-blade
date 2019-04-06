﻿using Connect.Razor.Internals;

namespace Connect.Razor.Blade.HtmlTags
{
    public class Script: Tag
    {
        // todo!
        public Script() : base("script")
        {

        }
    }

    public class ScriptJsonLd : Script
    {
        public ScriptJsonLd(string content)
        {
            Attr("type", "application/ld+json");
            TagContents = content;
        }

        public ScriptJsonLd(object content)
            : this(Html.ToJsonOrErrorMessage(content))
        {}
    }
}
