﻿using System;
using System.Collections.Generic;
using ToSic.Razor.Html5;

namespace ToSic.Razor.Page
{
    /// <summary>
    /// A feature describes something that can be enabled on a page. It can be a script, some css, an inline JS or combinations thereof. 
    /// </summary>
    public class PageFeature : IPageFeature
    {
        public PageFeature(string key, string name, string description = null, 
            List<Script> scriptFiles = null, 
            List<Link> styleFiles = null,
            List<Script> scripts = null, 
            List<Style> styles = null,
            string[] requires = null)
        {
            Key = key ?? throw new Exception("key is required");
            Name = name ?? throw new Exception("name is required");
            Description = description ?? "";
            ScriptFiles = scriptFiles ?? new List<Script>();
            StyleFiles = styleFiles ?? new List<Link>();
            Scripts = scripts ?? new List<Script>();
            Styles = styles ?? new List<Style>();
            Requires = requires ?? new string[0];
        }
        
        /// <summary>
        /// Primary identifier to activate the feature
        /// </summary>
        public string Key { get; }
        
        /// <summary>
        /// Name of this feature. 
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Nice description of the feature.
        /// </summary>
        public string Description { get; }

        public IList<Script> ScriptFiles { get; }

        public IList<Script> Scripts { get; }

        public IList<Link> StyleFiles { get; }

        public IList<Style> Styles { get; }
        
        /// <summary>
        /// List of other features required to run this feature.
        /// </summary>
        public IEnumerable<string> Requires { get; }
    }
}
