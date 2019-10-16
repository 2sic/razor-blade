using System.Collections.Generic;
using System.Linq;
using SourceCodeGenerator.Parts;

namespace SourceCodeGenerator.Configuration
{
    internal class TagsScripts : TagsBase
    {
        internal override string GroupName => "Scripts";

        /// <inheritdoc />
        public override List<TagCodeGenerator> List => 
            MakeList(SimpleTags)
                .Concat(SpecialConfigs)
                .ToList();


        // source https://www.w3schools.com/tags/ref_byfunc.asp
        public static string[] SimpleTags
            =
            {
                "noscript", 
            };


        public static List<TagCodeGenerator> SpecialConfigs = new List<TagCodeGenerator>
        {
            new TagCodeGenerator("script")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("async"),
                    new AttributeCodeGenerator("charset"),
                    new AttributeCodeGenerator("defer"),
                    new AttributeCodeGenerator("src"),
                    new AttributeCodeGenerator("type"),

                },
            },

            new TagCodeGenerator("embed")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("height", "int"),
                    new AttributeCodeGenerator("src"),
                    new AttributeCodeGenerator("type"),
                    new AttributeCodeGenerator("width", "int"),
                },
            },

            // https://www.w3schools.com/tags/tag_object.asp
            new TagCodeGenerator("object")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("data"),
                    new AttributeCodeGenerator("form"),
                    new AttributeCodeGenerator("height", "int"),
                    new AttributeCodeGenerator("name"),
                    new AttributeCodeGenerator("type"),
                    new AttributeCodeGenerator("usemap"),
                    new AttributeCodeGenerator("width", "int"),
                },
            },

            // https://www.w3schools.com/tags/tag_param.asp
            new TagCodeGenerator("param")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("name"),
                    new AttributeCodeGenerator("value"),
                },
            },
        };
    }
}
