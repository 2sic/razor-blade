using System.Linq;

namespace SourceCodeGenerator.Parts
{
    public partial class AttributeCodeGenerator: GeneratorBase
    {
        public string Name;
        public string Type;
        public string Key;

        public string Help;

        // ReSharper disable once InconsistentNaming
        public const string DefaultType = "string";

        public AttributeCodeGenerator(string name, string type = DefaultType, string separator = null, string help = null)
        {
            // The name of the method - some attributes have "-" in them, so we do some extra magic to change http-equiv to HttpEquiv
            Name = string.Join("", name.Split('-').Select(FirstCharToUpper));
            Key = name;
            Type = type;
            Separator = separator;
            Help = help;
        }


        private string Method(string className) => $"    public {className} {Name}";

        public string Code(TagCodeGenerator tag)
        {
            var valueType = Type;
            var allMethods = new[]
            {
                // url attributes have a different inner call to use
                //IsUrlAttribute() 
                //    ? CodeForUrlAttribute(tag, valueType)
                    // : 
                    MethodString(tag),
                MethodTyped(tag, valueType), // optional second signature with a int-type or something
                CodeForBooleanAttribute(tag),
                CodeForSrcSetAttribute(tag),
                "" // empty, to ensure trailing enters in generated code
            };
            return string.Join("\n\n", allMethods.Where(sc => sc != null));
        }

        private string Method(TagCodeGenerator tag, string valueType) => 
            $@"
    /// <summary>
    /// Set the {Key} attribute on the &lt;{tag.TagName}&gt; tag {CommentForPreprocessing}
    /// </summary>
    /// <param name=""value"">what should be in {Key}='...'.
    /// {SeparatorComment()}</param>
    /// <returns>a {tag.ClassName} object to enable fluid command chaining</returns>
    {Method(tag.ClassName)}({valueType} value) => this.Attr(""{Key}"", {ValuePreprocessor("value")}{GetSeparator()});";


        private string MethodString(TagCodeGenerator tag) => Method(tag, DefaultType);

        private string MethodTyped(TagCodeGenerator tag, string type) =>
            type == DefaultType 
                ? "" 
                : Method(tag, type);

    }

    // todo: maybe add enumerated attributes like 
    // https://github.com/iandevlin/html-attributes/blob/master/enumerated-attributes.json
}
