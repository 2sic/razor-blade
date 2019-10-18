using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ToSic.Razor.Markup
{
    public class ChildTags: List<TagBase>
    {
        public void Add(object child)
        {
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
