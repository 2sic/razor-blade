﻿namespace ToSic.Razor.Markup
{
    public class Attribute: RawHtmlString
    {
        /// <summary>
        /// Create an attribute, which can then generated into a name='value' output
        /// </summary>
        /// <param name="name">The attribute name, can also be a prepared attribute. So you can pass in "id" or "id='27'"</param>
        /// <param name="value">The value, if the initial name was really only a name. If it's an object, it will be json serialized</param>
        /// <param name="options">Options how the attribute will be generated</param>
        public Attribute(string name, object value = null, AttributeOptions options = null)
        {
            // If name is a full attribute with value, just put it all in the final prepared string
            // and don't set name/value
            if (name?.IndexOf("=") > 0)
                _prepared = name;
            else
            {
                Name = name;
                Value = value is ITag htmlValue ? htmlValue.ToString() : value;
            }

            Options = options;
        }

        /// <summary>
        /// Attribute name
        /// is null, if a prepared attribute was added
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// Attribute value
        /// can be null if a prepared attribute was added, or no value specified
        /// </summary>
        public readonly object Value;
        public AttributeOptions Options;

        /// <summary>
        /// Gets the HTML encoded string
        /// </summary>
        public override string ToString() => Build();


        #region Build single attribute

        /// <summary>
        /// Internal string-based commands to keep data simple till ready for output
        /// </summary>
        /// <returns></returns>
        private string Build()
        {
            if (_prepared != null) return _prepared;

            var currentOptions = AttributeOptions.UseOrCreate(Options);

            if (Value == null && currentOptions.DropValueIfNull)
                return Name;

            var val = Internals.Html.Encode(ValueStringOrSerialized(Value)) ?? "";

            if (!currentOptions.EncodeQuotes)
            {
                var safeQuote = currentOptions.Quote == "'" ? "\"" : "'";
                val = val.Replace(Internals.Html.Encode(safeQuote), safeQuote);
            }

            return currentOptions.KeepEmpty || !string.IsNullOrEmpty(val)
                ? $"{Name}={currentOptions.Quote}{val}{currentOptions.Quote}"
                : "";
        }
        /// <summary>
        /// An sequence already prepared, so no more building would be necessary
        /// </summary>
        private readonly string _prepared;


        /// <summary>
        /// Will either return the string, empty-string if null, or json-encoded object
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string ValueStringOrSerialized(object value)
            => value as string 
               ?? (value == null ? "" : Internals.Html.ToJsonOrErrorMessage(value));

        #endregion
    }
}
