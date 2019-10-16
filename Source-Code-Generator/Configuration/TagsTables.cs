using System.Collections.Generic;
using System.Linq;
using SourceCodeGenerator.Parts;

namespace SourceCodeGenerator.Configuration
{
    internal class TagsTables : TagsBase
    {
        internal override string GroupName => "Tables";

        /// <inheritdoc />
        public override List<TagCodeGenerator> List => 
            MakeList(SimpleTags)
                .Concat(SpecialConfigs)
                .ToList();


        // source https://www.w3schools.com/tags/ref_byfunc.asp
        public static string[] SimpleTags
            =
            {
                "table", 
                "caption",
                "tr",
                "thead",
                "tbody",
                "tfoot",
            };

        public static List<TagCodeGenerator> SpecialConfigs = new List<TagCodeGenerator>
        {
            new TagCodeGenerator("col")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("span", "int"),
                }
            },

            new TagCodeGenerator("colgroup")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("span", "int"),
                }
            },

            new TagCodeGenerator("th")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("abbr"),
                    new AttributeCodeGenerator("colspan", "int"),
                    new AttributeCodeGenerator("headers"),
                    new AttributeCodeGenerator("rowspan", "int"),
                    new AttributeCodeGenerator("scope"),
                    new AttributeCodeGenerator("sorted"),
                }
            },

            new TagCodeGenerator("td")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("colspan", "int"),
                    new AttributeCodeGenerator("headers"),
                    new AttributeCodeGenerator("rowspan", "int"),
                }
            },

        };
    }
}
