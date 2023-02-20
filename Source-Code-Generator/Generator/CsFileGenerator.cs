using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SourceCodeGenerator.Parts;

namespace SourceCodeGenerator.Generator
{
    public class CsFileGenerator
    {
        /// <summary>
        /// Target path to store generated code in
        /// </summary>
        public const string GeneratedTargetPath = @"C:\Projects\razor-blade\Razor.Blade\Html5\";
        

        public const string PathForTagService = @"C:\Projects\razor-blade\Razor.Blade\Blade\HtmlTagService\";

        public static void GenerateFormatting()
        {
            var specs = Templates.Main;
            var files = Generate(specs);

            foreach (var tuple in files)
            {
                var fileName = GeneratedTargetPath + specs.FileName.Replace("Tags", tuple.Item1);
                ReplaceFile(fileName, tuple.Item2);
            }

            // Generate Razor.Blade.Tag quick access
            specs = Templates.BladeDotTag;
            var quickAccess = GenerateQuickAccess(specs);
            var qaFile = GeneratedTargetPath + specs.FileName;
            ReplaceFile(qaFile, quickAccess);

            // Generate HtmlTagService
            specs = Templates.HtmlTagsImplementation;
            var htmlTagService = GenerateHtmlTagService(specs);
            var htFile = PathForTagService + specs.FileName;
            ReplaceFile(htFile, htmlTagService);

            // Generate IHtmlTagService
            specs = Templates.IHtmlTags;
            htmlTagService = GenerateHtmlTagServiceInterface(specs);
            htFile = PathForTagService + Templates.IHtmlTags.FileName;
            ReplaceFile(htFile, htmlTagService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="fileBody"></param>
        /// <code>
        /// </code>
        private static void ReplaceFile(string fileName, string fileBody)
        {
            // Check if file already exists. If yes, delete it.     
            if (File.Exists(fileName)) File.Delete(fileName);

            using var fs = File.CreateText(fileName);
            fs.Write(fileBody);
        }

        private static IEnumerable<Tuple<string, string>> Generate(CodeFileSpecs specs)
        {
            var tuples = Configuration.Configuration.GetTagGroupsToGenerate()
                .Select(set =>
                    new Tuple<string, string>(
                        set.GroupName,
                        specs.Wrapper.Replace("{Contents}", set.GenerateCode()
                        )));

            return tuples;
        }

        private static string GenerateQuickAccess(CodeFileSpecs specs)
        {
            var list = CommandsList().Select(c => c.QuickAccessCode);

            var template = specs.Wrapper.Replace("{Contents}", string.Join("\n", list));
            return template;
        }
        private static string GenerateHtmlTagService(CodeFileSpecs specs)
        {
            var list = CommandsList().Select(c => c.HtmlTagServiceCode);
            var template = specs.Wrapper.Replace("{Contents}", string.Join("\n", list));
            return template;
        }
        private static string GenerateHtmlTagServiceInterface(CodeFileSpecs specs)
        {
            var list = CommandsList().Select(c => c.HtmlTagServiceInterfaceCode);
            var template =  specs.Wrapper.Replace("{Contents}", string.Join("\n", list));
            return template;
        }

        private static IOrderedEnumerable<TagCodeGenerator> CommandsList()
        {
            var commands = Configuration.Configuration.GetTagGroupsToGenerate()
                .SelectMany(g => g.List)
                .OrderBy(t => t.ClassName);
            return commands;
        }
    }
}
