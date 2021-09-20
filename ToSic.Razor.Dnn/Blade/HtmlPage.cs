using System;
using System.Collections.Generic;
using ToSic.Razor.Dnn;
using ToSic.Razor.Internals;

// ReSharper disable UnusedMember.Global

namespace ToSic.Razor.Blade
{
    /// <summary>
    /// Access the surrounding page and read/modify some properties, 
    /// and add various kinds of headers to the &lt;head&gt; of the current page.
    /// </summary>
    /// <remarks>
    /// This is now obsolete. The concept doesn't scale with Blazor (.net core), so we recommend you use the newer ToSic.Sxc.Web.IPageService instead.
    /// </remarks>
    [Obsolete("This used to be a good idea, but doesn't scale well with blazor. Please use the newer ToSic.Sxc.Web.IPageService instead.")]
    public static class HtmlPage
    {
        public static Interfaces.IHtmlPage GetPage() => new DnnHtmlPage();

        /// <summary>
        /// The current page title
        /// Will return null if not running in a page context.
        /// </summary>
        /// <param name="value">a new title</param>
        public static string Title
        {
            get => GetPage().Title;
            set => GetPage().Title = value;
        }

        /// <summary>
        /// Get/Set description of this page
        /// Will return null if not running in a page context.
        /// </summary>
        /// <param name="value">a new description</param>
        public static string Description
        {
            get => GetPage().Description;
            set => GetPage().Description = value;
        }

        /// <summary>
        /// Get/Set keywords of this page
        /// Will return null if not running in a page context.
        /// </summary>
        /// <param name="value">the new keywords</param>
        public static string Keywords
        {
            get => GetPage().Keywords;
            set => GetPage().Keywords = value;
        }

        /// <summary>
        /// Add a tag to the header of the page
        /// Will simply not do anything if an error occurs, like if the page object doesn't exist
        /// </summary>
        /// <param name="tag"></param>
        public static void AddToHead(string tag) => GetPage().AddToHead(tag);


        /// <summary>
        /// Add a tag object to the header of the page
        /// Will simply not do anything if an error occurs, like if the page object doesn't exist
        /// </summary>
        /// <param name="tag"></param>
        /// <remarks>New in 2.1</remarks>
        public static void AddToHead(Markup.TagBase tag) => GetPage().AddToHead(tag);


        /// <summary>
        /// Add a standard base header tag.
        /// <em>new in 3.0</em>
        /// </summary>
        /// <param name="url">the optional url for the base tag - if null, will default to the real url for the current page</param>
        public static void AddBase(string url = null) => GetPage().AddBase(url);


        /// <summary>
        /// Add a standard meta header tag.
        /// If you need to add more attributes, use AddHeader(...) instead
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        public static void AddMeta(string name, string content) => GetPage().AddMeta(name, content);

        /// <summary>
        /// Add an open-graph header according to http://ogp.me/
        /// </summary>
        /// <param name="property">Open Graph property name, like title or image:width. 'og:' is automatically prefixed if not included</param>
        /// <param name="content">value of this property</param>
        public static void AddOpenGraph(string property, string content) => GetPage().AddOpenGraph(property, content);

        /// <summary>
        /// Add a JSON-LD header according https://developers.google.com/search/docs/guides/intro-structured-data
        /// </summary>
        /// <param name="jsonString">A prepared JSON string</param>
        public static void AddJsonLd(string jsonString) => GetPage().AddJsonLd(jsonString);

        /// <summary>
        /// Add a JSON-LD header according https://developers.google.com/search/docs/guides/intro-structured-data
        /// </summary>
        /// <param name="jsonObject">A object which will be converted to JSON. We recommend using dictionaries to build the object.</param>
        public static void AddJsonLd(object jsonObject) => GetPage().AddJsonLd(jsonObject);



        #region Icon stuff

        /// <summary>
        /// Add an icon tag to the page
        /// <em>new in 3.0</em>
        /// </summary>
        /// <param name="path">Path to the image/icon file</param>
        /// <param name="doNotRelyOnParameterOrder">This is a dummy parameter to force the developer to name the remaining parameters - like size: 75 etc.
        /// This allows us to add more parameters in future without worrying that existing code could break. 
        /// </param>
        /// <param name="rel">the rel-text, default is 'icon'. common terms are also 'shortcut icon' or 'apple-touch-icon'</param>
        /// <param name="size">Will be used in size='#x#' tag; only relevant if you want to provide multiple separate sizes</param>
        /// <param name="type">An optional type. If not provided, will be auto-detected from known types or remain empty</param>
        public static void AddIcon(
            string path,
            string doNotRelyOnParameterOrder = EnforceNamedParameters.ProtectionKey,
            string rel = "",
            int size = 0,
            string type = null) 
            => GetPage().AddIcon(path, rel: rel, size: size, type: type);


        /// <summary>
        /// Add a set of icons to the page
        /// <em>new in 3.0</em>
        /// </summary>
        /// <param name="path">Path to the image/icon file</param>
        /// <param name="doNotRelyOnParameterOrder">This is a dummy parameter to force the developer to name the remaining parameters - like size: 75 etc.
        /// This allows us to add more parameters in future without worrying that existing code could break. 
        /// </param>
        /// <param name="favicon">path to favicon, default is '/favicon.ico' </param>
        /// <param name="rels"></param>
        /// <param name="sizes"></param>
        public static void AddIconSet(
            string path,
            string doNotRelyOnParameterOrder = EnforceNamedParameters.ProtectionKey,
            object favicon = null,
            IEnumerable<string> rels = null,
            IEnumerable<int> sizes = null)
            => GetPage().AddIconSet(path, favicon:favicon, rels:rels, sizes:sizes);

        #endregion
    }
}