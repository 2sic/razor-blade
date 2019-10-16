using System.Collections.Generic;
using SourceCodeGenerator.Parts;

namespace SourceCodeGenerator.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Based on https://www.w3schools.com/tags/ref_byfunc.asp - the only frames in html5 are iframes
    /// </remarks>
    internal class TagsFrames: TagsBase
    {
        internal override string GroupName => "Frames";

        /// <inheritdoc />
        public override List<TagCodeGenerator> List => SpecialConfigs;

        // ReSharper disable StringLiteralTypo
        public static List<TagCodeGenerator> SpecialConfigs = new List<TagCodeGenerator>
        {

            new TagCodeGenerator("iframe")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("height", "int"),
                    new AttributeCodeGenerator("name"),
                    new AttributeCodeGenerator("sandbox"),
                    new AttributeCodeGenerator("src"),
                    new AttributeCodeGenerator("srcdoc"),
                    new AttributeCodeGenerator("width", "int"),
                },
                Standalone = true
            },


        };
    }
}
