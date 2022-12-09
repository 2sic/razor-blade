using System;

namespace SourceCodeGenerator.Generator
{
    internal static class Templates
    {
        public static string Intro = @"
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.Razor.Markup;
using ToSic.Razor.Internals;
using ToSic.Razor.Internals.Documentation;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created [DATE]
//
// Each tag and attributes of it prepare code, and they return an object of the same type again
// to allow fluid chaining of the commands
// ****
// ****
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable UnusedMember.Global

".Replace("[DATE]", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());


        public static CodeFileSpecs Main = new CodeFileSpecs
        {
            FileName = "GeneratedTags.cs",
            Wrapper = @"using System;"
                      + Intro
                      + @"

namespace ToSic.Razor.Html5
{
{Contents}
}
",
        };

        public static CodeFileSpecs BladeDotTag = new CodeFileSpecs
        {
            FileName = "Tag.cs",
            Wrapper = Intro + @"
// ReSharper disable once CheckNamespace
namespace ToSic.Razor.Blade
{
    public static partial class Tag
    {
        {Contents}
    }
}
",
        };

        public static CodeFileSpecs HtmlTagsImplementation = new CodeFileSpecs
        {
            FileName = "HtmlTagServiceImplementation_Generated.cs",
            Wrapper = Intro + @"
// ReSharper disable once CheckNamespace
namespace ToSic.Razor.Blade
{
    public partial class HtmlTagServiceImplementation
    {
        {Contents}
    }
}
",
        };


        public static CodeFileSpecs IHtmlTags => new CodeFileSpecs
        {
            FileName = "IHtmlTagService_Generated.cs",
            Wrapper = Intro + @"
// ReSharper disable once CheckNamespace
namespace ToSic.Razor.Blade
{
    public partial interface IHtmlTagService
    {
        {Contents}
    }
}
",
        };
    }
}
