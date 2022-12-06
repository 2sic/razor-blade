using System.Collections.Generic;
using System.Linq;

namespace SourceCodeGenerator.Parts
{
    public class TagCodeGenerator: GeneratorBase
    {
        public const string ContentParamName = "content";

        public string TagName { get; }
        public string ClassName { get; }

        public bool Standalone { get; set; } = false;

        public List<AttributeCodeGenerator> Properties = new List<AttributeCodeGenerator>();

        public TagCodeGenerator(string tagName)
        {
            TagName = tagName.ToLowerInvariant();
            ClassName = FirstCharToUpper(tagName);
        }

        public bool Fluid = false;

        public string Code() => Comment() + Class;

        private string TagOptions => Standalone
            ? ", new TagOptions(close: false)"
            : string.Empty;

        private string TagOptionsWithExplicitNull => TagOptions == string.Empty ? ", null" : TagOptions;

        public string Comment(string name = null) => $@"
    /// <summary>
    /// Generate a standard HTML5 &lt;{TagName}&gt; tag{(name == null ? "" : " with optional contents")}
    /// </summary>
    /// <returns>
    /// A {ClassName} object with all the attributes available in that tag
    /// </returns>
    {(name == ContentParamName ? $@"/// <param name=""{ContentParamName}"">one or more objects (strings or tags) which will be inside the tag</param>" : "")}";

        public string Class => $@"public partial class {ClassName} : Tag<{ClassName}>
    {{
    {Constructor}
    {ConstructorWithParams}
    {ConstructorForClone}
    {CloneWithChanges}
    {Attributes}
    }}";

        public string Constructor => $@"
    /// <summary>
    /// Generate an &lt;{TagName}&gt; tag with optional contents
    /// </summary>
    {(Standalone ? "" : @"/// <param name=""content"">content which will be inside the tag</param>")}
    internal {ClassName
    }({ConstructorParameters}) : {BaseCall}
    {{
    }}";

        public string ConstructorWithParams => $@"
    {Comment(ContentParamName)}
    internal {ClassName}(params object[] {ContentParamName}) : base({Fluid.ToString().ToLower()}, ""{TagName}""{TagOptionsWithExplicitNull}, {ContentParamName})
    {{
    }}";

        #region Fluid Cloning

        public string ConstructorForClone => $@"private {ClassName}({ClassName} original, CloneChanges changes) : base(original, changes) {{ }}";
        public string CloneWithChanges => $@"internal override {ClassName} CwC(CloneChanges changes) => new {ClassName}(this, changes);";
        #endregion

        public string ConstructorParameters =>
            // "bool fluid" +
            (Standalone
            ? ""
            : "object content = null");

        public string CallParameters(bool chain = true) => Standalone ? "" : (chain ? ", " : "") + "content";


        /// <summary>
        /// The first parameter ensures that it's not fluid = false
        /// </summary>
        public string BaseCall => $"base({Fluid.ToString().ToLower()}, \"{TagName}\"{CallParameters(true)}{TagOptions})";

        public string Attributes => string.Join("", Properties.Select(p => p.Code(this)));

        #region Quick Access - ToSic.Razor.Blade.Tag.xxx

        public string QuickAccessCode => $@"{Comment(ContentParamName)}
    /// <code>
    /// var {ClassName.ToLower()} = Tag.{ClassName}();{(
Standalone ? "" : $@"
    /// var {ClassName.ToLower()}2 = Tag.{ClassName}(""hello there"");"
    )}
    /// </code>
    {QuickAccessWithParams}";

        private string QuickAccessWithParams => $"public static {ClassName} {ClassName}(params object[] content) => new {ClassName}(content);";

        #endregion

        #region HtmlTagService & Interface

        public string HtmlTagServiceCode => $@"
    /// <inheritdoc />
    public {ClassName} {ClassName}(params object[] content) => new {ClassName}(true, content);";

        public string HtmlTagServiceInterfaceCode => $@"{Comment(ContentParamName)}
    /// <code>
    /// // This assumes that `tagSvc` was previously retrieved from dependency injection
    /// var {ClassName.ToLower()} = tagSvc.{ClassName}();{(
Standalone ? "" : $@"
    /// var {ClassName.ToLower()}2 = tagSvc.{ClassName}(""hello there"");"
    )}
    /// </code>
    {ClassName} {ClassName}(params object[] content);";

        #endregion
    }
}
