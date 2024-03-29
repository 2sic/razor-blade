﻿using System.Linq;
using System.Text.RegularExpressions;

namespace ToSic.Razor.Blade
{
    public partial class ScrubImplementation
    {
        /// <summary>
        /// Clean up space between tag-name and tag-ending (&gt; or /&gt;)
        /// </summary>
        /// <returns></returns>
        private string SpaceCleaning(string original)
        {
            original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\/?>)", "");
            original = Regex.Replace(original, "(?<=<\\w+[^>/]*) {2,}(?=\\w*=)", " ");

            return original;
        }

        /// regex explained:
        /// 1. Positive lookbehind (basically checks if there is an opening tag before the identified attribute and only proceeds with the match if that is true): 
        ///   (?<=<\w+\s+[^>]*)
        /// 
        /// 2. Match (matches one or more \w characters if there is only spaces or no spaces between it and the = character 
        ///   after it there can also be as zero or more spaces as soon as it detects a character it matches anything one or more times but doesn't match the content of the square brackets): 
        ///   (\w+)\s*=\s*[^ ""'=><`]+
        ///
        /// 3. Negative lookbehind (Basically checks if there is a closing tag somewhere after the attribute to make sure it doesnt match something that just looks like an attribute but isn't inside a HTML Tag):
        ///   (?=[^>]*\/?>)
        /// 
        /// This is only the regex that matches attributes with no quotes but the other work almost the same one just matches ' after the = and the other one " 

        private const string AttributePlaceholder = @"[^""'>,= ]+"; // language=regex
        private const string AttributeRegexNoQuote = @"(?<=<\w+\s+[^>]*)[^""'>,= ]+\s*=\s*[^ ""'=><`\s]+(?=[^>]*\/?>)"; // language=regex
        private const string AttributeRegexSingleQuote = @"(?<=<\w+\s+[^>]*)[^""'>,= ]+\s*=\s*(')[^']*(')(?=[^>]*\/?>)"; // language=regex
        private const string AttributeRegexDoubleQuote = @"(?<=<\w+\s+[^>]*)[^""'>,= ]+\s*=\s*("")[^""]*("")(?=[^>]*\/?>)"; // language=regex
        private const string AttributeOnlyDeclared = @"(?<=<\w+\s+[^>]*)(?<!(=(""|')([^>]*)|=[\w-]*|=))\b[^""'>,= ]+\b(?!=)(?=[^>]*\/?>)"; // language=regex

        /// <summary>
        /// Remove all HTML attributes.
        /// </summary>
        /// <param name="html">original string containing HTML</param>
        /// <returns>A string without any attributes inside the HTML Tags</returns>
        public string Attributes(string html)
        {
            //Null check
            if (html == null) return null;

            //Remove all attributes with no quotes
            html = Regex.Replace(html, AttributeRegexNoQuote, "", RegexOptions.IgnoreCase);

            //Remove all attributes with single quotes
            html = Regex.Replace(html, AttributeRegexSingleQuote, "", RegexOptions.IgnoreCase);

            //Remove all attributes with double quotes
            html = Regex.Replace(html, AttributeRegexDoubleQuote, "", RegexOptions.IgnoreCase);

            //Remove instances attributes where the attribute is declared without assigning an value to it
            html = Regex.Replace(html, AttributeOnlyDeclared, "", RegexOptions.IgnoreCase);

            //Clean up spaces
            html = SpaceCleaning(html);

            return html;
        }

        /// <summary>
        /// Remove all instances of a specified attribute.
        /// </summary>
        /// <param name="html">original string containing HTML</param>
        /// <param name="attribute">string defining the attribute to remove</param>
        /// <returns>A string which doesn't contain the specified attribute</returns>

        public string Attributes(string html, string attribute)
        {
            // Null check
            if (attribute == null || html == null)
                return html;

            //Set the attribute that should be replaced
            var escaped = Regex.Escape(attribute);

            //Replace the attribute placeholder in all the regex patterns with the actual attribute
            var regexNoQuotes = AttributeRegexNoQuote.Replace(AttributePlaceholder, escaped);
            var regexSingleQuotes = AttributeRegexSingleQuote.Replace(AttributePlaceholder, escaped);
            var regexDoubleQuotes = AttributeRegexDoubleQuote.Replace(AttributePlaceholder, escaped);
            var regexOnlyDeclared = AttributeOnlyDeclared.Replace(AttributePlaceholder, escaped);

            //Remove all attributes with no quotes
            html = Regex.Replace(html, regexNoQuotes, "", RegexOptions.IgnoreCase);

            //Remove all attributes with single quotes
            html = Regex.Replace(html, regexSingleQuotes, "", RegexOptions.IgnoreCase);

            //Remove all attributes with double quotes
            html = Regex.Replace(html, regexDoubleQuotes, "", RegexOptions.IgnoreCase);

            //Remove instances attributes where the attribute is declared without assigning an value to it
            html = Regex.Replace(html, regexOnlyDeclared, "", RegexOptions.IgnoreCase);

            //Clean up spaces
            html = SpaceCleaning(html);

            return html;
        }

        /// <summary>
        /// Remove all instances of an array of specified attributes.
        /// </summary>
        /// <param name="html">original string containing HTML</param>
        /// <param name="attributes">array defining the attributes to remove</param>
        /// <returns>A string which doesn't contain the specified attributes</returns>
        public string Attributes(string html, params string[] attributes)
        {
            // Null check
            if (attributes == null || !attributes.Any() || html == null)
                return html;

            html = attributes.Aggregate(html,(previous, attribute) => previous = Attributes(previous, attribute));

            return html;
        }
    }
}
