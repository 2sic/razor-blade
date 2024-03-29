﻿using System.Linq;

namespace SourceCodeGenerator.Parts
{
    public partial class AttributeCodeGenerator

    {

        private string ValuePreprocessor(string valueName)
        {
            return IsUrlAttribute 
                ? $"UriHelpers.UriEncode({valueName})" 
                : IsSrcSetAttribute 
                    ? $"UriHelpers.UriEncodeSrcSet({valueName})" 
                    : valueName;
        }


    //    private string CodeForUrlAttribute(TagCodeGenerator tag, string valueType) =>
    //        IsUrlAttribute
    //            ? $@"
    ///// <summary>
    ///// Set the {Key} attribute on the &lt;{tag.TagName}&gt; tag {CommentForPreprocessing}
    ///// </summary>
    ///// <returns>a {tag.ClassName} object to enable fluid command chaining</returns>
    //{Method(tag.ClassName)}({valueType} value) => this.AttrUrl(""{Key}"", value{GetSeparator()});"
    //            : null;

        public bool MustPreprocess() => IsUrlAttribute || IsSrcSetAttribute;

        public string CommentForPreprocessing => MustPreprocess()
            ? "\n    /// Automatically url-encode it if contains spaces, umlauts or other unexpected chars"
            : "";

        public bool IsUrlAttribute => UrlAttributes.Contains(Key);

        // list taken from https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes
        // ReSharper disable StringLiteralTypo
        public static string[] UrlAttributes = {
            "src",
            "href",
            "poster", // in video tag
            "data", // in object tag
        };
        // ReSharper restore StringLiteralTypo
    }
}
