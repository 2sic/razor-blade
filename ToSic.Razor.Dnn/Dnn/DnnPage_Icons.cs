﻿using System.Collections.Generic;
using ToSic.Razor.Internals;
using ToSic.Razor.Html5;

namespace ToSic.Razor.Dnn
{
    public partial class DnnHtmlPage
    {
        /// <inheritdoc />
        public void AddIcon(
            string path,
            string doNotRelyOnParameterOrder = EnforceNamedParameters.ProtectionKey,
            string rel = null, 
            int size = Icon.SizeUndefined, 
            string type = null)
        {
            EnforceNamedParameters.VerifyProtectionKey(doNotRelyOnParameterOrder);
            AddToHead(new Icon(path, rel, size, type));
        }

        /// <inheritdoc />
        public void AddIconSet(
            string path,
            string doNotRelyOnParameterOrder = EnforceNamedParameters.ProtectionKey,
            object favicon = null, 
            IEnumerable<string> rels = null, 
            IEnumerable<int> sizes = null
            )
        {
            EnforceNamedParameters.VerifyProtectionKey(doNotRelyOnParameterOrder);
            foreach (var s in Internals.Page.IconSet.GenerateIconSet(path, favicon, rels, sizes))
                AddToHead(s);
        }

    }
}