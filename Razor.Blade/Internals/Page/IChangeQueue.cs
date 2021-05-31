using System.Collections.Generic;

namespace ToSic.Razor.Internals.Page
{
    public interface IChangeQueue
    {
        IList<PagePropertyChange> PropertyChanges { get; }
        IList<HeadChange> Headers { get; }
    }

}
