namespace ToSic.Razor.Markup
{
    /// <summary>
    /// Options which determine how the tag is to be generated / rendered.
    /// </summary>
    /// <remarks>In v4.0 it was changed to be read-only for reliably fluid APIs. </remarks>
    public class TagOptions
    {
        #region Constants / Defaults

        /// <summary>
        /// By default, all tags close.
        /// </summary>
        public const bool DefaultClose = true;

        /// <summary>
        /// By default, tags without content don't self close - they add a separate close-tag.
        /// </summary>
        public const bool DefaultSelfCloseIfNoContent = false;

        #endregion


        /// <summary>
        /// Determines if this tag will close - eg. `img` or `br` tags don't close
        /// </summary>
        public bool Close { get; }

        /// <summary>
        /// Determines if this tag self-closes, like an HTML4 br tag.
        /// Not really in use in HTML5
        /// </summary>
        public bool SelfClose { get; }


        public AttributeOptions Attribute { get; }

        public TagOptions() : this(attributeOptions: null) { }

        public TagOptions(TagOptions original = null, AttributeOptions attributeOptions = null, bool? close = null, bool? selfClose = null)
        {
            Attribute = attributeOptions ?? original?.Attribute ?? AttributeOptions.DefaultOptions;
            Close = close ?? original?.Close ?? DefaultClose;
            SelfClose = selfClose ?? original?.SelfClose ?? DefaultSelfCloseIfNoContent;
        }

        #region Cloning / Re-Using / Re-Generating options
        /// <summary>
        /// Check if options were already provided, or create new default options
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        internal static TagOptions UseOrCreate(TagOptions original) => original ?? DefaultOptions;

        public static TagOptions DefaultOptions = new TagOptions();

        #endregion
    }
}
