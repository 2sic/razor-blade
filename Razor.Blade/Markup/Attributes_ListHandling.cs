using System.Collections.Generic;
using System.Linq;
using static System.StringComparison;

namespace ToSic.Razor.Markup
{
    public partial class Attributes
    {

        internal static IReadOnlyCollection<Attribute> Add(IReadOnlyCollection<Attribute> list, string name, object value = null, string appendSeparator = null)
        {
            // bad entry, skip
            if (string.IsNullOrEmpty(name)) return list;

            // Clone the list now
            var newList = new List<Attribute>(list);

            // pre-built entry, use that
            if (name.Contains("="))
            {
                newList.Add(new Attribute(name));
                return newList;
            }

            // check if it has already been added
            // ignore case, as attributes are not case-sensitive
            var attrib = newList.FirstOrDefault(a => string.Equals(a.Name, name, InvariantCultureIgnoreCase));

            // if found, try to remove or append
            if (attrib == null)
                newList.Add(new Attribute(name, value));
            else
            {
                var newAttrib = ReplaceOrAppendValue(attrib, value, appendSeparator);
                var oldIdx = newList.FindIndex(li => li == attrib);
                newList.Remove(attrib);
                newList.Insert(oldIdx, newAttrib);
            }
            return newList;
        }


        private static Attribute ReplaceOrAppendValue(Attribute attrib, object value, string separator)
        {
            var maybeStr = attrib.Value as string;
            // check if we can actually append
            // this requires both values to be strings
            var replace = separator == null;
            if (!replace)
                replace = string.IsNullOrEmpty(maybeStr)
                          || string.IsNullOrEmpty(value as string);

            var newValue = replace
                ? value
                : maybeStr + separator + value;
            return new Attribute(attrib.Name, newValue);
        }

        
    }
}
