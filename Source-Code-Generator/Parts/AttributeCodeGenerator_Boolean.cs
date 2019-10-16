using System.Linq;

namespace SourceCodeGenerator.Parts
{
    public partial class AttributeCodeGenerator

    {
        private string CodeForBooleanAttribute(TagCodeGenerator tag) =>
            IsBooleanAttribute()
                ? $@"
    /// <summary>
    /// Activate the {Key} attribute on the &lt;{tag.TagName}&gt; tag
    /// </summary>
    /// <returns>a {tag.ClassName} object to enable fluid command chaining</returns>
    {Method(tag.ClassName)}() => this.Attr(""{Key}"");"
                : null;


        /// <summary>
        /// tells us if the desired attribute is a boolean
        /// this means that the attribute can be added by itself, without a value
        /// </summary>
        /// <returns></returns>
        public bool IsBooleanAttribute() => BooleanAttributes.Contains(Key);

        // got from here https://github.com/iandevlin/html-attributes/blob/master/boolean-attributes.json
        // ReSharper disable StringLiteralTypo
        public static string[] BooleanAttributes = {
            "allowfullscreen",
            "allowpaymentrequest",
            "async",
            "autofocus",
            "autoplay",
            "checked",
            "controls",
            "default",
            "defer",
            "disabled",
            "formnovalidate",
            "hidden",
            "ismap",
            "itemscope",
            "loop",
            "multiple",
            "muted",
            "nomodule",
            "novalidate",
            "open",
            "readonly",
            "required",
            "reversed",
            "selected",
            "typemustmatch"};
        // ReSharper restore StringLiteralTypo

    }
}
