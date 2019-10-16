using System.Collections.Generic;
using SourceCodeGenerator.Parts;

namespace SourceCodeGenerator.Configuration
{
    internal class TagsLinks : TagsBase
    {
        internal override string GroupName => "Links";

        /// <inheritdoc />
        public override List<TagCodeGenerator> List => SpecialConfigs;

        // ReSharper disable StringLiteralTypo
        public static List<TagCodeGenerator> SpecialConfigs = new List<TagCodeGenerator>
        {
            new TagCodeGenerator("a")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("download"),
                    new AttributeCodeGenerator("href"),
                    new AttributeCodeGenerator("hreflang"),
                    new AttributeCodeGenerator("media"),
                    new AttributeCodeGenerator("ping"),
                    new AttributeCodeGenerator("rel"),
                    new AttributeCodeGenerator("target"),
                    new AttributeCodeGenerator("type"),
                }
            },
            // see https://www.w3schools.com/tags/tag_link.asp
            new TagCodeGenerator("link")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("crossorigin"),
                    new AttributeCodeGenerator("href"),
                    new AttributeCodeGenerator("hreflang"),

                    new AttributeCodeGenerator("media"),
                    new AttributeCodeGenerator("rel"),
                    // sizes not added, as only relevant for rel-icon
                    new AttributeCodeGenerator("type"),
                },
                Standalone = true
            },
            // see https://www.w3schools.com/tags/tag_nav.asp - no special properties
            new TagCodeGenerator("nav")



        };
    }
}
