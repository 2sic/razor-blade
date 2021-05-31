using System;
using System.Collections.Generic;
using ToSic.Razor.Blade;

namespace ToSic.Razor.Internals.Page
{
    public partial class Page: IPage, IChangeQueue
    {

        public IList<HeadChange> Headers { get; } = new List<HeadChange>();

        

        /// <summary>
        /// How the changes given to this object should be processed.
        /// </summary>
        public ChangeModes ChangeMode { get; set; } = ChangeModes.Auto;

        protected ChangeModes GetMode(ChangeModes modeForAuto)
        {
            switch (ChangeMode)
            {
                case ChangeModes.Default:
                case ChangeModes.Auto:
                    return modeForAuto;
                case ChangeModes.Replace:
                case ChangeModes.Append:
                case ChangeModes.Prepend:
                    return ChangeMode;
                default:
                    throw new ArgumentOutOfRangeException(nameof(ChangeMode), ChangeMode, null);
            }
        }
    }
}
