using System.Collections.Generic;

namespace ToSic.Razor.Internals.Page
{
    public partial class Page
    {
        public IList<string> Features { get; } = new List<string>();


        /// <inheritdoc />
        public void Enable(string key)
        {
            if (string.IsNullOrWhiteSpace(key)) return;
            Features.Add(key);
        }
    }
}
