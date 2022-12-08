using System;
using ToSic.Razor.Blade;
using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Markup
{
    /// <summary>
    /// Helper commands to enable fluid coding with Tag Attributes and Common Helpers like Add and Wrap.
    /// This allows you to do things like <code>Div().Id("myId").Class("row4").Class("xs")</code>
    /// </summary>
    public abstract class Tag<T>: TagBase, IHtmlTag where T : Tag<T>
    {
        #region Constructors

        protected Tag(string name = null, TagOptions options = null)
            : base(name: name, options: options) { }

        protected Tag(string name, object content, TagOptions options = null)
            : base(name: name, options: options, content: new [] { content }) { }

        protected Tag(string name, TagOptions options, object[] content) 
            : base(name: name, options: options, content: content) { }

        protected Tag(string name, string tagOverride, TagOptions options = null) 
            : base(name: name, options: options, tagOverride: tagOverride ) { }

        /// <summary>
        /// Special constructor just for cloning with changes
        /// </summary>
        /// <param name="original"></param>
        protected internal Tag(TagBase original, CloneChanges changes)
            : base(original: original, name: null, tagOverride: null, children: changes.Children, attributes: changes.Attributes, options: changes.Options)
        { }

        #endregion

        #region Self-Clone

        /// <summary>
        /// Clone / change if fluid... otherwise just change
        /// </summary>
        internal T CloneIfFunctional(CloneChanges changes)
        {
            if (IsImmutable) return CwC(changes);
            ApplyChanges(changes);
            return (T) this;
        }
        
        /// <summary>
        /// Clone with Changes
        /// </summary>
        internal abstract T CwC(CloneChanges changes);

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
            var newList = GetOrCloneAttributeList()
                .Add(name, value, appendSeparator);
            return CloneIfFunctional(new CloneChanges { Attributes = newList });
        }


        /// <summary>
        /// Quickly add an attribute
        /// it always returns the tag itself again, allowing chaining of multiple add-calls
        /// </summary>
        /// <param name="nameWithValue">Object which can be ToString()ed</param>
        /// <returns></returns>
        public T Attr(object nameWithValue)
        {
            var newList = GetOrCloneAttributeList()
                .AddObject(nameWithValue);
            return CloneIfFunctional(new CloneChanges { Attributes = newList });
        }

        private Attributes GetOrCloneAttributeList() => IsImmutable ? new Attributes(TagAttributes) : TagAttributes;

        /// <summary>
        /// Special initializer of attributes, because otherwise attributes will not be available in the final object
        /// because of the functional nature of the API.
        /// </summary>
        /// <param name="initializer"></param>
        [PrivateApi]
        protected void InitAttributes(Action initializer)
        {
            var before = IsImmutable;
            IsImmutable = false; // necessary, to not generate new objects during init
            initializer();
            IsImmutable = before;
        }

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
        /// <param name="name">the term behind data-, so "name" becomes "data-name". If empty, will just create a "data" attribute</param>
        /// <param name="value">string or object, objects will be json serialized</param>
        /// <returns></returns>
        public T Data(string name, object value = null)
            => Attr("data" + (string.IsNullOrEmpty(name) ? "" : "-" + name), value, null);

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
        /// <param name="children">a variable amount of tags / strings to add to the contents of this tag</param>
        /// <returns></returns>
        public T Add(params object[] children)
        {
            var newChildren = (IsImmutable ? new TagChildren(TagChildren) : TagChildren)
                .Add(children);
            return CloneIfFunctional(new CloneChanges { Children = newChildren });
        }


        /// <summary>
        /// Wrap the tag around the new content, so this replaces all the content with what you give it
        /// </summary>
        /// <param name="content">a variable amount of tags / strings to add to the contents of this tag</param>
        /// <returns></returns>
        public T Wrap(params object[] content) 
            => CloneIfFunctional(new CloneChanges { Children = new TagChildren(this, content) });

        [PrivateApi("WIP v4 - should be exclusively fluid!")]
        public T WithOptions(TagOptions options) => CloneIfFunctional(new CloneChanges { Options = options });

        /// <inheritdoc />
        public IHtmlTag AsHtmlTag() => this;


        [PrivateApi("Explicit implementation for when this tag is generic without known specific type")]
        IHtmlTag IHtmlTag.Attr(string name, object value, string appendSeparator) => Attr(name, value, appendSeparator);

        [PrivateApi("Explicit implementation for when this tag is generic without known specific type")]
        IHtmlTag IHtmlTag.Attr(object nameWithValue) => Attr(nameWithValue);

        [PrivateApi("Explicit implementation for when this tag is generic without known specific type")]
        IHtmlTag IHtmlTag.Id(string id) => Id(id);

        [PrivateApi("Explicit implementation for when this tag is generic without known specific type")]
        IHtmlTag IHtmlTag.Class(string value) => Class(value);

        [PrivateApi("Explicit implementation for when this tag is generic without known specific type")]
        IHtmlTag IHtmlTag.Style(string value) => Style(value);

        [PrivateApi("Explicit implementation for when this tag is generic without known specific type")]
        IHtmlTag IHtmlTag.Title(string value) => Title(value);

        [PrivateApi("Explicit implementation for when this tag is generic without known specific type")]
        IHtmlTag IHtmlTag.Data(string name, object value) => Data(name, value);

        [PrivateApi("Explicit implementation for when this tag is generic without known specific type")]
        IHtmlTag IHtmlTag.On(string name, object value) => On(name, value);

        [PrivateApi("Explicit implementation for when this tag is generic without known specific type")]
        IHtmlTag IHtmlTag.Add(params object[] children) => Add(children);

        [PrivateApi("Explicit implementation for when this tag is generic without known specific type")]
        IHtmlTag IHtmlTag.Wrap(params object[] content) => Wrap(content);
    }
}
