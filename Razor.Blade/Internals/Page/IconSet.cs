using System.Collections.Generic;
using System.Linq;
using ToSic.Razor.Html5;

namespace ToSic.Razor.Internals.Page
{
    public class IconSet
    {
        internal static readonly string[] IconSetDefaultRelationships = {
            Icon.RelIcon,
            Icon.RelShortcut,
            Icon.RelApple,
        };

        public static List<Icon> GenerateIconSet(bool fluid, string path, object favicon = null, IEnumerable<string> rels = null, IEnumerable<int> sizes = null)
        {
            // if no sizes given, just assume the default size only
            sizes = sizes ?? new[] { Icon.SizeUndefined };

            // if no rels are given, use default list
            var relList = (rels ?? IconSetDefaultRelationships).ToList();

            // generate the icons
            var result = relList.SelectMany(relationship => sizes,
                    (relationship, size) => new Icon(fluid, path, relationship, size))
                .ToList();

            // if we need a favicon, add it as well
            switch (favicon)
            {
                case null:
                    result.Add(new Icon(fluid, path, Icon.RelShortcut));
                    break;
                case bool favBool when favBool:
                    result.Add(new Icon(fluid, Icon.RootFavicon, Icon.RelShortcut));
                    break;
                case string favString when !string.IsNullOrEmpty(favString):
                    result.Add(new Icon(fluid, favString, Icon.RelShortcut));
                    break;
            }
            return result;
        }
        
    }
}
