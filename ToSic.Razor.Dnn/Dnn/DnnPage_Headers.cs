using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using DotNetNuke.Entities.Portals;
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.Razor.Markup;

namespace ToSic.Razor.Dnn
{
    public partial class DnnHtmlPage 
    {

        /// <inheritdoc />
        public void AddBase(string url = null)
        {
            if (url == null)
            {
                try
                {
                    var currentPage = PortalSettings.Current.ActiveTab.TabID;
                    // helper to generate a base path which is also valid on home (special DNN behaviour)
                    const string random = "this-should-never-exist-in-the-url";
                    var basePath = DotNetNuke.Common.Globals.NavigateURL(currentPage, "", random + "=1");
                    url = basePath.Substring(0, basePath.IndexOf(random, StringComparison.Ordinal));
                }
                catch { /* ignore */ }
            }

            if (url != null)
                AddToHead(Tag.Base().Href(url));
        }


        /// <summary>
        /// Add a string to the header
        /// </summary>
        /// <param name="tag"></param>
        public void AddToHead(string tag)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tag)) return;
                var control = new LiteralControl(tag);
                Page?.Header.Controls.Add(control);
            }
            catch {  /* ignore */ }
        }

        /// <summary>
        /// Add a tag to the header
        /// </summary>
        /// <param name="tag"></param>
        public void AddToHead(TagBase tag) => AddToHead(tag?.ToString());



        /// <summary>
        /// Generate and add a meta-tag
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        public void AddMeta(string name, string content) =>
            AddToHead(new Meta(name, content));

        /// <summary>
        /// Generate and add an open-graph header
        /// </summary>
        /// <param name="property"></param>
        /// <param name="content"></param>
        public void AddOpenGraph(string property, string content) =>
            AddToHead(new MetaOg(property, content));

        /// <summary>
        /// Generate and add a json-ld header
        /// </summary>
        /// <param name="jsonString"></param>
        public void AddJsonLd(string jsonString) 
            => AddToHead(new ScriptJsonLd(jsonString));

        /// <summary>
        /// Generate and add a json-ld header, by serializing an object
        /// </summary>
        /// <param name="jsonObject"></param>
        public void AddJsonLd(object jsonObject) 
            => AddToHead(new ScriptJsonLd(jsonObject));

        private void EnsureFieldVisibleAndSetValueAgain(string id, string value)
        {
            if (!(Page?.FindControl(id) is HtmlMeta metaTag)) return;
            metaTag.Visible = true;

            // this seems like a patch around some DNN bugs (probably specific versions)
            // I would leave it for now
            metaTag.Content = ToSic.Razor.Internals.Html.Encode(value);
        }



    }
}