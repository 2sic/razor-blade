using System.Collections.Generic;
using ToSic.Razor.Blade;

namespace ToSic.Razor.Internals.Page
{
    public partial class Page
    {
        public IList<PagePropertyChange> PropertyChanges { get; } = new List<PagePropertyChange>();

        /// <inheritdoc />
        public void SetTitle(string value, string token = null) => Queue(PageProperties.Title, value, ChangeModes.Prepend, token);

        /// <inheritdoc />
        public void SetDescription(string value, string token = null) => Queue(PageProperties.Description, value, ChangeModes.Prepend, token);

        /// <inheritdoc />
        public void SetKeywords(string value, string token = null) => Queue(PageProperties.Keywords, value, ChangeModes.Append, token);

        /// <inheritdoc />
        public void SetBase(string url) => Queue(PageProperties.Base, url, ChangeModes.Replace, null);

        /// <summary>
        /// Add something to the queue for setting a page property
        /// </summary>
        private void Queue(PageProperties property, string value, ChangeModes change, string token)
        {
            PropertyChanges.Add(new PagePropertyChange
            {
                ChangeMode = GetMode(change),
                Property = property, 
                Value = value,
                ReplacementIdentifier = token,
            });

        }

    }
}
