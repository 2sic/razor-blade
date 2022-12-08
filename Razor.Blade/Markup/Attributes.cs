using System.Collections.Generic;
using System.Linq;

namespace ToSic.Razor.Markup
{
    public partial class Attributes: RawHtmlString
    {
        #region constructors

        public Attributes(AttributeOptions options = null, IEnumerable<Attribute> list = null, IEnumerable<Attribute> additions = null)
        {
            Options = options;
            var newList = list?.ToList() ?? new List<Attribute>();
            if (additions != null) newList.AddRange(additions);
            List = newList.AsReadOnly();
        }

        public Attributes(Attributes original, AttributeOptions options = null) : this(options ?? original.Options, original.List) { }

        #endregion

        #region List / IEnumerable

        public IReadOnlyCollection<Attribute> List { get; }

        #endregion

        /// <summary>
        /// Serialization options to use for all attributes,
        /// unless an attribute has own options
        /// </summary>
        public AttributeOptions Options;


        internal Attributes Add(string name, object value = null, string appendSeparator = null)
        {
            var newList = Add(List, name, value, appendSeparator);
            return new Attributes(Options, newList);
        }

        /// <summary>
        /// This must have another name than Add, because otherwise it collides with List.Add
        /// </summary>
        /// <param name="nameOrValue"></param>
        internal Attributes AddObject(object nameOrValue) => Add(nameOrValue?.ToString());

        public Attributes AddUrl(string name, object value = null, string appendSeparator = null)
            => Add(name, TagBase.UriEncode(value?.ToString()), appendSeparator);
        

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
