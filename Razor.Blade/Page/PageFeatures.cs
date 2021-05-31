using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ToSic.Razor.Page
{
    public class PageFeatures: IPageFeatures
    {
        private readonly Dictionary<string, IPageFeature> _features = new Dictionary<string, IPageFeature>(StringComparer.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        public IReadOnlyDictionary<string, IPageFeature> Features { get; private set; }

        public void Register(IPageFeature newFeature)
        {
            _features.Add(newFeature.Key, newFeature);
            Features = new ReadOnlyDictionary<string, IPageFeature>(_features);
        }
    }
}
