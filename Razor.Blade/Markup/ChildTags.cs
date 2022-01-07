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

            // Handle null, string, or single TagBase object
            if (AddOrSkipNullOrTagBase(child)) return;

            // Check for IEnumerable, but make sure we don't pick up strings
            // This doesn't process it yet, just ensures that in case it's an array/list of real items, that it is unwrapped
            if (!(child is string) && child is IEnumerable childEnum)
            {
                var tempList = childEnum.Cast<object>().ToList();
                if (!tempList.Any()) return;

                // If it has exactly one item, it's probably an array/enumerable in an array, so unwrap
                if (tempList.Count == 1)
                {
                    child = tempList.First();
                    // Handle null, string, or single TagBase object
                    if (AddOrSkipNullOrTagBase(child)) return;
                }
            }


            // if it's a classic tag list - everything is ok
            if (child is IEnumerable<TagBase> list)
            {
                AddRange(list);
                return;
            }

            // otherwise check if it's a list, but exclude strings,
            // because otherwise it will try to enumerate each character
            if(!(child is string) && child is IEnumerable nonTagList)
            {
                foreach (var item in nonTagList)
                    base.Add(TagBase.EnsureTag(item));
                return;
            }
            
            // last case: Used to be (before 2022) string or tag, just add (after 2022) - will probably never be hit
            base.Add(TagBase.EnsureTag(child));
        }

        private bool AddOrSkipNullOrTagBase(object child)
        {
            // Prevent null problems on further type checks
            if (child is null) return true;

            // Do this early on, because all TagBase are now Enumerable (03.08) so they would otherwise get wrong positives
            if (child is TagBase tbChild)
            {
                base.Add(tbChild);
                return true;
            }

            if (child is string)
            {
                base.Add(TagBase.EnsureTag(child));
                return true;
            }

            return false;
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
