using System.Collections.Generic;
using System.Linq;
using static System.StringComparison;

namespace ToSic.Razor.Markup
{
    public class Attributes: ToHtmlHybridBase
    {
        #region constructors

        public Attributes(AttributeOptions options = null, IEnumerable<Attribute> list = null, IEnumerable<Attribute> additions = null)
        {
            Options = options;
            var newList = list?.ToList() ?? new List<Attribute>();
            if (additions != null) newList.AddRange(additions);
            List = newList;
        }

        public Attributes(Attributes original, AttributeOptions options = null)
            : this(options ?? original.Options, original.List) { }

        #endregion

        #region List / IEnumerable

        public List<Attribute> List { get; }

        #endregion

        /// <summary>
        /// Serialization options to use for all attributes,
        /// unless an attribute has own options
        /// </summary>
        public AttributeOptions Options;

        /// <summary>
        /// This must have another name than Add, because otherwise it collides with List.Add
        /// </summary>
        /// <param name="nameOrValue"></param>
        internal Attributes AddObject(object nameOrValue)
        {
            Add(nameOrValue?.ToString());
            return this;
        }

        internal Attributes Add(string name, object value = null, string appendSeparator = null)
        {
            Add(List, name, value, appendSeparator);
            return this;
        }

        internal static void Add(List<Attribute> list, string name, object value = null, string appendSeparator = null)
        {
            // bad entry, skip
            if (string.IsNullOrEmpty(name)) return;

            var replace = appendSeparator == null;

            // pre-built entry, use that
            if (name.Contains("="))
            {
                list.Add(new Attribute(name));
                return;
            }

            // check if it has already been added
            // ignore case, as attributes are not case-sensitive
            var attrib = list.FirstOrDefault(a => string.Equals(a.Name, name, InvariantCultureIgnoreCase));

            // if found, try to remove or append
            if (attrib == null)
                list.Add(new Attribute(name, value));
            else
            {
                var newAttrib = ReplaceOrAppendValue(attrib, value, replace, appendSeparator);
                var oldIdx = list.FindIndex(li => li == attrib);
                list.Remove(attrib);
                list.Insert(oldIdx, newAttrib);
            }
        }

        public void AddUrl(string name, object value = null, string appendSeparator = null) 
            => Add(name, TagBase.UriEncode(value?.ToString()), appendSeparator);

        private static Attribute ReplaceOrAppendValue(Attribute attrib, object value, bool replace, string separator)
        {
            var maybeStr = attrib.Value as string;
            // check if we can actually append
            // this requires both values to be strings
            if (!replace)
                replace = string.IsNullOrEmpty(maybeStr)
                          || string.IsNullOrEmpty(value as string);

            var newValue = replace
                ? value
                : maybeStr + separator + value;
            return new Attribute(attrib.Name, newValue);
        }


        /// <summary>
        /// Gets the HTML safe string
        /// </summary>
        public override string ToString() => Build() ?? string.Empty;


        private string Build()
        {
            var options = AttributeOptions.UseOrCreate(Options);
            return string.Join(" ",
                List.Select(a =>
                    {
                        if (a.Options == null) a.Options = options;
                        return a.ToString();
                    })
                    .Where(val => !string.IsNullOrEmpty(val))
            );
        }
    }
}
