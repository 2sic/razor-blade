using System;
using System.Collections.Generic;
using ToSic.Razor.Internals;
using ToSic.Razor.Internals.Documentation;
using ToSic.Razor.Markup;
// ReSharper disable UnusedMember.Global

namespace ToSic.Razor.Interfaces
{
    /// <summary>
    /// Standardizes what an HtmlPage object can do across platforms. 
    /// </summary>
    /// <remarks>
    /// WARNING - this was an implementation for DNN and doesn't use Dependency injection
    /// Because of this we strongly recommend against using it. We assume this interface is actually not used anywhere, so don't start now :).
    /// Use the Connect.Koi implementation instead. 
    /// </remarks>
    [Obsolete("Do not use any more, doesn't scale well in newer .net frameworks")]
    [PrivateApi]
    public interface IHtmlPage
    {

        /// <summary>
        /// The current page title
        /// Will return null if not running in a page context.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Get/Set description of this page
        /// Will return null if not running in a page context.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Get/Set keywords of this page
        /// Will return null if not running in a page context.
        /// </summary>
        string Keywords { get; set; }


        /// <summary>
        /// Add a tag to the header of the page
        /// Will simply not do anything if an error occurs, like if the page object doesn't exist
        /// </summary>
        /// <param name="tag"></param>
        void AddToHead(string tag);

        /// <summary>
        /// Add a tag object to the header of the page
        /// Will simply not do anything if an error occurs, like if the page object doesn't exist
        /// </summary>
        /// <param name="tag"></param>
        /// <remarks>New in 2.1</remarks>
        void AddToHead(TagBase tag);

        /// <summary>
        /// Add a standard base header tag.
        /// <em>new in 3.0</em>
        /// </summary>
        /// <param name="url">the optional url for the base tag - if null, will default to the real url for the current page</param>
        void AddBase(string url = null);

        /// <summary>
        /// Add a standard meta header tag.
        /// You may also want AddOpenGraph or AddJsonLd
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        void AddMeta(string name, string content);

        /// <summary>
        /// Add an open-graph header according to http://ogp.me/
        /// </summary>
        /// <param name="property">Open Graph property name, like title or image:width. 'og:' is automatically prefixed if not included</param>
        /// <param name="content">value of this property</param>
        void AddOpenGraph(string property, string content);


        /// <summary>
        /// Add a JSON-LD header according https://developers.google.com/search/docs/guides/intro-structured-data
        /// </summary>
        /// <param name="jsonString">A prepared JSON string</param>
        void AddJsonLd(string jsonString);

        /// <summary>
        /// Add a JSON-LD header according https://developers.google.com/search/docs/guides/intro-structured-data
        /// </summary>
        /// <param name="jsonObject">A object which will be converted to JSON. We recommend using dictionaries to build the object.</param>
        void AddJsonLd(object jsonObject);

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
        void AddIcon(
            string path,
            string doNotRelyOnParameterOrder = EnforceNamedParameters.ProtectionKey,
            string rel = "", 
            int size = 0, 
            string type = null);

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
        void AddIconSet(
            string path,
            string doNotRelyOnParameterOrder = EnforceNamedParameters.ProtectionKey,
            object favicon = null, 
            IEnumerable<string> rels = null,
            IEnumerable<int> sizes = null);

        #endregion
    }
}
