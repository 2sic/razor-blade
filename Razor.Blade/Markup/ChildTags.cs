using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static ToSic.Razor.Markup.ToHtmlHybridBase;

namespace ToSic.Razor.Markup
{
    public class ChildTags: List<TagBase>
    {
        public void Add(params object[] children)
        {
            if (children == null || children.Length == 0) return;

            if (children.Length == 1)
            {
                var first = children.First();
                if (first == null) return;
                // Strings, TagBase and any list are now IEnumerable
                if (first is IEnumerable innerList)
                {
                    // Handle null, string, or single TagBase object
                    // Note that TagBase objects also report as being IEnumerable
                    if (AddOrSkipNullOrTagBase(innerList)) return;

                    // it was not a TagBase, string or null, but an IEnumerable
                    // Unwrap and continue normal
                    children = innerList.Cast<object>().ToArray();
                }
            }
            // Untangle deeper objects if necessary
            // This is because child could be
            // - a single item
            // - an array of items - like a string[]
            // - an array with a single item - which itself is an IEnumerable

            // 2. Import a TagBase list
            // if it's a classic tag list - everything is ok
            // This could also be the result of processing #1 before
            if (children is IEnumerable<TagBase> list)
            {
                AddRange(list);
                return;
            }

            // otherwise handle it since it's just an array of different objects
            foreach (var item in children)
                base.Add(TagBase.EnsureTag(item));
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

            if (IsStringOrHtmlString(child, out var childString))
            {
                base.Add(TagBase.EnsureTag(childString));
                return true;
            }

            return false;
        }

        public void Replace(params object[] children)
        {
            Clear();
            Add(children);
        }

        internal string Build(TagOptions optionsOrNull)
        {
            if (!this.Any()) return "";
            if (optionsOrNull == null) optionsOrNull = TagOptions.DefaultOptions;
            return string.Join("", this.Select(c => c.ToString(c.TagOptions ?? optionsOrNull)));
        }

    }
}
