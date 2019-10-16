using System.Collections.Generic;
using System.Linq;
using SourceCodeGenerator.Parts;

namespace SourceCodeGenerator.Configuration
{
    internal class TagsHead : TagsBase
    {
        internal override string GroupName => "Head";

        /// <inheritdoc />
        public override List<TagCodeGenerator> List => 
            MakeList(SimpleTags)
                .Concat(SpecialConfigs)
                .ToList();


        // source https://www.w3schools.com/tags/ref_byfunc.asp
        public static string[] SimpleTags
            =
            {
                "head", 
            };


        public static List<TagCodeGenerator> SpecialConfigs = new List<TagCodeGenerator>
        {
            new TagCodeGenerator("meta")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("charset"),
                    new AttributeCodeGenerator("content"),
                    new AttributeCodeGenerator("http-equiv"),
                    new AttributeCodeGenerator("name"),

                },
                Standalone = true
            },

            new TagCodeGenerator("base")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("href"),
                    new AttributeCodeGenerator("target"),

                },
                Standalone = true
            },

        };
    }
}
