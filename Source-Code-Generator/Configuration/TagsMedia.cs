using System.Collections.Generic;
using SourceCodeGenerator.Parts;

namespace SourceCodeGenerator.Configuration
{
    internal class TagsMedia: TagsBase
    {
        internal override string GroupName => "Media";

        /// <inheritdoc />
        public override List<TagCodeGenerator> List => SpecialConfigs;

        // ReSharper disable StringLiteralTypo
        public static List<TagCodeGenerator> SpecialConfigs = new List<TagCodeGenerator>
        {
            new TagCodeGenerator("audio")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("autoplay"),
                    new AttributeCodeGenerator("controls"),
                    new AttributeCodeGenerator("loop"),
                    new AttributeCodeGenerator("muted"),
                    new AttributeCodeGenerator("preload"),
                    new AttributeCodeGenerator("src"),
                },
            },
            new TagCodeGenerator("source")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("src"),
                    new AttributeCodeGenerator("srcset"),
                    new AttributeCodeGenerator("media"),
                    new AttributeCodeGenerator("sizes"),
                    new AttributeCodeGenerator("type"),
                },
                Standalone = true
            },
            new TagCodeGenerator("track")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("default"),
                    new AttributeCodeGenerator("kind"),
                    new AttributeCodeGenerator("label"),
                    new AttributeCodeGenerator("src"),
                    new AttributeCodeGenerator("srclang"),
                },
                Standalone = true
            },

            // https://www.w3schools.com/tags/tag_video.asp
            new TagCodeGenerator("video")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("autoplay"),
                    new AttributeCodeGenerator("controls"),
                    new AttributeCodeGenerator("height", "int"),
                    new AttributeCodeGenerator("loop"),
                    new AttributeCodeGenerator("muted"),
                    new AttributeCodeGenerator("poster"),
                    new AttributeCodeGenerator("preload"),
                    new AttributeCodeGenerator("src"),
                    new AttributeCodeGenerator("width", "int"),
                },
            },




        };
    }
}
