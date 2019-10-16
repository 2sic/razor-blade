using System.Collections.Generic;
using System.Linq;
using SourceCodeGenerator.Parts;

namespace SourceCodeGenerator.Configuration
{
    internal class TagsFormatting : TagsBase
    {
        internal override string GroupName => "Formatting";

        /// <inheritdoc />
        public override List<TagCodeGenerator> List => 
            MakeList(FormattingTags)
                .Concat(SpecialConfigs)
                .ToList();


        // source https://www.w3schools.com/tags/ref_byfunc.asp
        public static string[] FormattingTags
            =
            {
                "abbr", // could be enhanced
                "address",
                "b",
                "bdi",
                //"bdo|string dir", // https://www.w3schools.com/tags/tag_bdo.asp
                //"blockquote|string cite", // https://www.w3schools.com/tags/tag_blockquote.asp
                "cite",
                "code",
                //"del|string cite,string datetime", // could have cite / datetime https://www.w3schools.com/tags/tag_del.asp
                "dfn",
                "em",
                "i",
                "figure",
                "figcaption",
                //"ins", // cite/datetime https://www.w3schools.com/tags/tag_ins.asp
                "kbd",
                "mark",
                //"meter", // many attributes https://www.w3schools.com/tags/tag_meter.asp
                "pre",
                //"progress", // max value  https://www.w3schools.com/tags/tag_progress.asp
                //"q", // cite https://www.w3schools.com/tags/tag_q.asp
                "rp",
                "rt",
                "ruby",
                "s",
                "samp",
                "small",
                "strong",
                "sub",
                "sup",
                "template",
                //"time", // attribute datetime https://www.w3schools.com/tags/tag_time.asp
                "u",
                "var",
                // "wbr" // it's in the non-closing tags
            };

        public static List<TagCodeGenerator> SpecialConfigs = new List<TagCodeGenerator>
        {

            new TagCodeGenerator("bdo")
            {
                Properties = new List<AttributeCodeGenerator>{ new AttributeCodeGenerator("dir") }
            },
            #region citation, quotes, editing; blockquote, q, del, ins
            new TagCodeGenerator("blockquote")
            {
                Properties = new List<AttributeCodeGenerator>{ new AttributeCodeGenerator("cite") }
            },

            new TagCodeGenerator("del")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("cite"),
                    new AttributeCodeGenerator("datetime", "DateTime")
                }
            },

            new TagCodeGenerator("ins")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("cite"),
                    new AttributeCodeGenerator("datetime", "DateTime")
                }
            },

            new TagCodeGenerator("meter")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("form"),
                    new AttributeCodeGenerator("high"),
                    new AttributeCodeGenerator("low"),
                    new AttributeCodeGenerator("max"),
                    new AttributeCodeGenerator("min"),
                    new AttributeCodeGenerator("optimum"),
                    new AttributeCodeGenerator("value"),
                }
            },
            new TagCodeGenerator("progress")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("max"),
                    new AttributeCodeGenerator("value"),
                }
            },
            new TagCodeGenerator("q")
            {
                Properties = new List<AttributeCodeGenerator>{ new AttributeCodeGenerator("cite") }
            },
            #endregion

            new TagCodeGenerator("time")
            {
                Properties = new List<AttributeCodeGenerator>
                {
                    new AttributeCodeGenerator("datetime", "DateTime")
                }
            },

        };
    }
}
