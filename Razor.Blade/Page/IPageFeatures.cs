using System.Collections.Generic;

namespace ToSic.Razor.Page
{
    public interface IPageFeatures
    {
        IReadOnlyDictionary<string, IPageFeature> Features { get; }
    }
}
