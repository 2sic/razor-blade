using ToSic.Razor.Internals.Documentation;

namespace ToSic.Razor.Markup
{
    /// <summary>
    /// Configure how attributes will be serialized.
    /// It's a read-only object to ensure fluid APIs.
    /// Properties cannot be modified.
    /// To modify a property, create a new one to clone the settings of the previous.
    /// </summary>
    /// <remarks>In v4.0 it was changed to be read-only for reliably fluid APIs. </remarks>
    public class AttributeOptions
    {
        #region Constants / Defaults

        /// <summary>
        /// By default quotes will not be encoded if this results in valid html.
        /// </summary>
        public const bool DefaultEncodeQuotes = false;

        /// <summary>
        /// By default, empty attributes are preserved.
        /// </summary>
        public const bool DefaultKeepEmpty = true;

        /// <summary>
        /// By default, use the `'` quote for attributes since it allows for storing json in attributes which is fairly common.
        /// </summary>
        public const string DefaultQuote = "'";

        /// <summary>
        /// By default a null-value will result in an attribute-name only. 
        /// </summary>
        public const bool DefaultDropValueIfNull = true;

        public const bool DefaultAddSpacePaddings = false;

        #endregion

        #region Constructor to enforce fluid API

        public AttributeOptions(AttributeOptions original = null, string quote = null, bool? encodeQuotes = null, bool? keepEmpty = null, bool? dropValueIfNull = null)
        {
            Quote = quote ?? original?.Quote ?? DefaultQuote;
            EncodeQuotes = encodeQuotes ?? original?.EncodeQuotes ?? DefaultEncodeQuotes;
            KeepEmpty = keepEmpty ?? original?.KeepEmpty ?? DefaultKeepEmpty;
            DropValueIfNull = dropValueIfNull ?? original?.DropValueIfNull ?? DefaultDropValueIfNull;
        }

        #endregion

        /// <summary>
        /// What character is used for wrapping attribute values
        /// </summary>
        public string Quote { get; }

        /// <summary>
        /// Encode quotes or apostrophes in attributes which clearly don't need encoding
        /// </summary>
        public bool EncodeQuotes { get; }

        /// <summary>
        /// Place empty attributes on the tag anyhow.
        /// </summary>
        public bool KeepEmpty { get; }

        /// <summary>
        /// Drop the value part of the attribute if the value would be null.
        /// When true, `name=null` will result in `name` - when false it will be `name=''`
        /// </summary>
        public bool DropValueIfNull { get; }

        public bool AddPaddings { get; private set; }

        [PrivateApi]
        internal static AttributeOptions UseOrCreate(AttributeOptions original) => original ?? DefaultOptions;

        [PrivateApi]
        internal static AttributeOptions DefaultOptions = new AttributeOptions();

        [PrivateApi]
        internal static AttributeOptions StandaloneOptions = new AttributeOptions() { AddPaddings = true };
    }
}
