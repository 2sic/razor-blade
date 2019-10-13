﻿using System.Collections.Generic;
using System.Linq;
using SourceCodeGenerator.Parts;

namespace SourceCodeGenerator.Configuration
{
    public class Configuration
    {
        /// <summary>
        /// Target path to store generated code in
        /// </summary>
        public const string GeneratedTargetPath = @"C:\Projects\razor-blades\Razor.Blade\Blade\Html5\";

        /// <summary>
        /// Target file for generated code
        /// </summary>
        public static string GeneratedTags = "GeneratedTags.cs";

        public static List<TagCodeGenerator> GetAll()
        {
            return new TagsFormatting().List
                .Concat(new TagsSimple().List)
                .Concat(new TagsImages().List)
                .Concat(new TagsLinks().List)
                .Concat(new TagsFrames().List)
                // .Concat(new TagsForms().List)
                .Concat(new TagsMedia().List)
                .OrderBy(c => c.ClassName)
                .ToList();
        }


        // ReSharper restore StringLiteralTypo

        // todo: forms/input
        // todo audio/video

        // todo: tables
        // todo: styles/semantics

        // todo: meta
        // todo: programming
    }
}