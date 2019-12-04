namespace ToSic.Razor.Markup
{
    /// <summary>
    /// Helper commands to enable fluid coding with Tag Attributes and Common Helpers like Add and Wrap.
    /// This allows you to do things like <code>Div().Id("myId").Class("row4").Class("xs")</code>
    /// </summary>
    public class Tag<T>: TagBase where T : Tag<T>
    {
        #region Constructors

        internal Tag(string name = null, TagOptions options = null)
            : base(name, options) { }

        internal Tag(string name, object content, TagOptions options = null)
            : base(name, content, options) { }

        internal Tag(string name, TagOptions options, object[] content) 
            : base(name, options, content) { }

        #endregion

        /// <summary>
        /// Quickly add an attribute
        /// it always returns the tag itself again, allowing chaining of multiple add-calls
        /// </summary>
        /// <param name="name">the attribute name, or a complete value like "name='value'"</param>
        /// <param name="value">optional value - if the attribute already exists, it will be appended</param>
        /// <param name="appendSeparator">attribute appendSeparator in case the value is appended</param>
        /// <returns></returns>
        public T Attr(string name, object value = null, string appendSeparator = null)
            
        {
            TagAttributes.Add(name, value, appendSeparator);
            return (T) this;
        }


        ///// <summary>
        ///// Quickly add a URL attribute which usually needs encoding
        ///// it always returns the tag itself again, allowing chaining of multiple add-calls
        ///// </summary>
        ///// <param name="name">the attribute name, or a complete value like "name='value'"</param>
        ///// <param name="value">optional value - if the attribute already exists, it will be appended</param>
        ///// <param name="appendSeparator">attribute appendSeparator in case the value is appended</param>
        ///// <returns></returns>
        //internal T AttrUrl(string name, object value = null, string appendSeparator = null)
            
        //{
        //    TagAttributes.AddUrl(name, value, appendSeparator);
        //    return this as T;
        //}

        /// <summary>
        /// ID - set multiple times always overwrites previous ID
        /// </summary>
        public T Id(string id) 
            => Attr("id", id, null);

        /// <summary>
        /// class attribute
        /// </summary>
        public T Class(string value) 
            => Attr("class", value, " ");

        /// <summary>
        /// style attribute. If called multiple times, will append styles.
        /// </summary>

        /// <param name="value">Style to add</param>
        /// <returns></returns>
        public T Style(string value) 
            => Attr("style", value, appendSeparator: ";");

        /// <summary>
        /// title attribute
        /// </summary>

        /// <param name="value">new title to set</param>
        /// <returns></returns>
        public T Title(string value) 
            => Attr("title", value, null);

        /// <summary>
        /// Add a data-... attribute
        /// </summary>

        /// <param name="name">the term behind data-, so "name" becomes "data-name"</param>
        /// <param name="value">string or object, objects will be json serialized</param>
        /// <returns></returns>
        public T Data(string name, object value = null) 
            => Attr("data-" + name, value, null);

        /// <summary>
        /// Add a onEventName attribute for javascript events
        /// </summary>

        /// <param name="name">the term behind data-, so "name" becomes "data-name"</param>
        /// <param name="value">string or object, objects will be json serialized</param>
        /// <returns></returns>
        public T On(string name, object value = null) 
            => Attr("on" + name, value, null);


        /// <summary>
        /// Add contents to this tag - at the end of the already added contents.
        /// If you want to replace the contents, use Wrap() instead
        /// </summary>

        /// <param name="child"></param>
        /// <returns></returns>
        public T Add(object child) 
        {
            TagChildren.Add(child);
            return this as T;
        }

        /// <summary>
        /// Add contents to this tag - at the end of the already added contents.
        /// If you want to replace the contents, use Wrap() instead
        /// </summary>

        /// <param name="children">a variable amount of tags / strings to add to the contents of this tag</param>
        /// <returns></returns>
        public T Add(params object[] children) 
        {
            TagChildren.Add(children);
            return this as T;
        }

        /// <summary>
        /// Wrap the tag around the new content, so this replaces all the content with what you give it
        /// </summary>

        /// <param name="content">New content - can be a string, TagBase or list of tags</param>
        /// <returns></returns>
        public T Wrap(object content) 
        {
            TagChildren.Replace(content);
            return this as T;
        }

        /// <summary>
        /// Wrap the tag around the new content, so this replaces all the content with what you give it
        /// </summary>

        /// <param name="content">a variable amount of tags / strings to add to the contents of this tag</param>
        /// <returns></returns>
        public T Wrap(params object[] content) 
        {
            TagChildren.Replace(content);
            return this as T;
        }
    }
}
