namespace ToSic.Razor.Markup
{
    internal class TagBuilder
    {
        /// <summary>
        /// Generate an html tag as a string for further processing
        /// </summary>
        internal static string Tag(string name,
            Attributes attributes,
            string content,
            TagOptions optionsOrNull)
        {
            optionsOrNull = string.IsNullOrEmpty(content) || optionsOrNull == null
                // default case, no content or no options, get default options or create new
                ? TagOptions.UseOrCreate(optionsOrNull)
                // special case: we have content AND options, so we must ensure that it will close correctly
                : new TagOptions(optionsOrNull, close: TagOptions.DefaultClose, selfClose: TagOptions.DefaultSelfCloseIfNoContent);

            var open = Open(name, attributes, optionsOrNull);
            return $"{open}{content}"
                   + (optionsOrNull.Close && !optionsOrNull.SelfClose ? Close(name) : "");
        }


        internal static string Open(
            string name,
            Attributes attributes,
            TagOptions options)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "";

            options = TagOptions.UseOrCreate(options);

            // if we have a data-list of attributes, add to object
            if (attributes.Options == null)
                attributes.Options = options.Attribute;
            var attributeText = attributes?.ToString() ?? "";

            // ensure attributes have space in front
            if (!string.IsNullOrEmpty(attributeText) && attributeText[0] != ' ')
                attributeText = " " + attributeText;

            var selfClose = options.Close && options.SelfClose ? "/" : "";

            return $"<{name}{attributeText}{selfClose}>";
        }

        internal static string Close(string name)
            => string.IsNullOrWhiteSpace(name)
                ? ""
                : $"</{name}>";
    }
}
