using System.Collections.Generic;
using System.Linq;
using ToSic.Razor.Blade;

namespace ToSic.Razor.Markup
{
    public partial class TagChildren : RawHtmlString
    {
        #region Constructor and List

        public TagChildren(TagBase parent, IEnumerable<IHtmlTag> list = null, IEnumerable<IHtmlTag> additions = null)
        {
            _parent = parent;
            var newList = list?.ToList() ?? new List<IHtmlTag>();
            if (additions != null) newList.AddRange(additions);
            List = newList.AsReadOnly();
        }

        public TagChildren(TagChildren original): this(original._parent, original.List) { }

        internal readonly IReadOnlyCollection<IHtmlTag> List;

        private readonly TagBase _parent;

        #endregion

        public TagChildren(TagBase parent, params object[] children): this(parent, Add(new List<IHtmlTag>(), children))
        {
        }

        public TagChildren Add(params object[] children)
        {
            var newList = Add(List, children);
            return new TagChildren(_parent, newList);
        }
        
        ///// <inheritdoc />
        public override string ToString() => Build(_parent?.TagOptions);

        internal string Build(TagOptions optionsOrNull)
        {
            if (!this.List.Any()) return "";
            if (optionsOrNull == null) optionsOrNull = TagOptions.DefaultOptions;
            return string.Join("", this.List.Select(c => c.ToString(c.TagOptions ?? optionsOrNull)));
        }

    }
}
