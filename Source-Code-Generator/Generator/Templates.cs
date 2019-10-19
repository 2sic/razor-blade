using System;

namespace SourceCodeGenerator.Generator
{
    public class Templates
    {
        public static string Wrapper =
            @"using System;
using ToSic.Razor.Blade;
using ToSic.Razor.Markup;
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
namespace ToSic.Razor.Html5
{
{Contents}
}
".Replace("[DATE]", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());



    public static string QuickAccessWrapper = @"
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.Razor.Markup;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created 15.10.2019 10:11
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
// ReSharper disable once CheckNamespace
namespace ToSic.Razor.Blade
{
    public static partial class Tag
    {
        {Contents}
    }
}
";
    }
}
