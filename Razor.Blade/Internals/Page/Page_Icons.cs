using System.Collections.Generic;
using ToSic.Razor.Html5;

namespace ToSic.Razor.Internals.Page
{
    public partial class Page
    {
        /// <inheritdoc />
        public void AddIcon(string path, string doNotRelyOnParameterOrder = EnforceNamedParameters.ProtectionKey, string rel = "",
            int size = 0, string type = null)
        {
            EnforceNamedParameters.VerifyProtectionKey(doNotRelyOnParameterOrder);
            AddToHead(new Icon(path, rel, size, type));
        }

        /// <inheritdoc />
        public void AddIconSet(string path, string doNotRelyOnParameterOrder = EnforceNamedParameters.ProtectionKey,
            object favicon = null, IEnumerable<string> rels = null, IEnumerable<int> sizes = null)
        {
            EnforceNamedParameters.VerifyProtectionKey(doNotRelyOnParameterOrder);
            foreach (var s in IconSet.GenerateIconSet(path, favicon, rels, sizes))
                AddToHead(s);
        }

    }
}
