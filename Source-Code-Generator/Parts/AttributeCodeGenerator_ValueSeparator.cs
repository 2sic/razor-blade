namespace SourceCodeGenerator.Parts
{
    /// <summary>
    /// This is all about attributes which contain multiple values, like class-attributes (where values are separated by spaces) or srcset attributes (where they are separated by commas)
    /// </summary>
    public partial class AttributeCodeGenerator
    {
        public string Separator;

        private string GetSeparator()
        {
            string result = null;
            if (!string.IsNullOrEmpty(Separator)) result = Separator;
            else if (Key == "srcset") result = ",";
            return result == null ? "" : $", \"{result}\"";
        }

        private string SeparatorComment() => Separator == null
            ? "If called multiple times, later values replace the previous value."
            : "If called multiple times, additional values are appended and separated by a '{Separator}'.";


    }
}
