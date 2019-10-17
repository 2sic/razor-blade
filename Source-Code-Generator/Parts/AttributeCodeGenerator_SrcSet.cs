namespace SourceCodeGenerator.Parts
{
    public partial class AttributeCodeGenerator
    {
        private bool IsSrcSetAttribute => Key == "srcset";

        private string CodeForSrcSetAttribute(TagCodeGenerator tag) =>
            !IsSrcSetAttribute
                ? null
                : $@"
    /// <summary>
    /// Add another name/number pair to the {Key} attribute on the &lt;{tag.TagName}&gt; tag
    /// </summary>
    /// <param name=""name"">image name</param>
    /// <param name=""multiplier"">what the images is for - numbers below 8 are used for resolution densities, larger numbers for pixel widths</param>  
    /// <returns>a {tag.ClassName} object to enable fluid command chaining</returns>
    {Method(tag.ClassName)}(string name, int multiplier) => {Name}(UriEncode(name) + "" "" + multiplier + (multiplier > 8 ? ""w"" : ""x""));";

    }
}
