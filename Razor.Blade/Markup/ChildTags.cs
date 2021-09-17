using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ToSic.Razor.Markup
{
    public class ChildTags: List<TagBase>
    {
        public void Add(object child)
        {
            // Untangle deeper objects if necessary
            // This is because child could be
            // - a single item
            // - an array of items - like a string[]
            // - an array with a single item - which itself is an ienumerable

            // Prevent null problems on further type checks
            if (child is null) return;

            // Check for IEnumerable, but make sure we don't pick up strings
            if (!(child is string) && child is IEnumerable childEnum)
            {
                var tempList = childEnum.Cast<object>().ToList();
                if (!tempList.Any()) return;

                // If it has exactly one item, it's probably an array/enumerable in an array, so unwrap
                if (tempList.Count == 1)
                {
                    var first = tempList.First();
                    if (first == null) return;
                    child = first;
                }
            }


            // if it's a classic tag list - everything is ok
            if (child is IEnumerable<TagBase> list)
                AddRange(list);

            // otherwise check if it's a list, but exclude strings,
            // because otherwise it will try to enumerate each character
            else if(!(child is string) && child is IEnumerable nonTagList)
                foreach (var item in nonTagList)
                    base.Add(TagBase.EnsureTag(item));
            
            // last case: string or tag, just add
            else
                base.Add(TagBase.EnsureTag(child));
        }

        public void Replace(object child)
        {
            Clear();
            Add(child);
        }

        internal string Build(TagOptions options)
        {
            if (!this.Any())
                return "";
            return string.Join("", this.Select(c => c.ToString(c.TagOptions ?? options)));
        }

    }
}
