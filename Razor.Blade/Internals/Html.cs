using System;
using System.Linq;
using System.Net;
#if !NETSTANDARD
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;
#endif

namespace ToSic.Razor.Internals
{
    internal class Html
    {
        /// <summary>
        /// Internal string-based commands to keep data simple till ready for output
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal static string Encode(string value)
            => WebUtility.HtmlEncode(value)
                ?.Replace("&#39;", "&apos;");

       
        /// <summary>
        /// Internal string-based commands to keep data simple till ready for output
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal static string Decode(string value)
            => WebUtility.HtmlDecode(value);

        internal static string ToJson(object jsonObject)
        {
            // 2022-12-06 2dm - removed in v4, not used in 2sxc any more
            // First - try if the environment had provided an Delegate for this
            //if (ObjToJsonString != null)
            //    return ObjToJsonString(jsonObject);
#if !NETSTANDARD
            // return new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(jsonObject);
            return JsonSerializer.Serialize(jsonObject, options: JsonOptions.SafeJsonForHtmlAttributes);
#else
            throw new NotImplementedException(
                "Serialization for .net standard doesn't exist, feel free to add this; " +
                "just make sure that the project still compiles and doesn't have new dependencies for the .net40 release");
#endif
        }

        // 2022-12-06 2dm - removed in v4, not used in 2sxc any more
        ///// <summary>
        ///// Special function to create Json which would be provided from external at start-up.
        ///// This is to ensure .net standard2 can have a ToJson even if .net standard2 would otherwise need more dependencies.
        ///// </summary>
        //internal static Func<object, string> ObjToJsonString;

        internal const string SerializationErrorIntro = "Error: could not convert object to json - ";

        internal static string ToJsonOrErrorMessage(object jsonObject)
        {
            try
            {
                return ToJson(jsonObject);
            }
            catch (Exception e)
            {
                return SerializationErrorIntro + e.Message;
            }
        }

#if !NETSTANDARD
        public static class JsonOptions
        {
            public const int DefaultMaxModelBindingRecursionDepth = 32;

            /// <summary>
            /// Common, shared, default, base JsonSerializerOptions for JsonSerializer
            /// provided to all other concrete JsonSerializerOptions implementations 
            /// also to preserve json compatibility with older apis used by Newtonsoft.Json.
            /// </summary>
            // ReSharper disable once InconsistentNaming
            private static readonly JsonSerializerOptions DefaultOptions = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                Converters = { new JsonDateTimeConverter(), new JsonStringEnumConverter()/*, new ObjectToInferredTypesConverter()*/ },
                //DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
                IncludeFields = true,
                // Limit the object graph we'll consume to a fixed depth. This prevents stackoverflow exceptions
                // from deserialization errors that might occur from deeply nested objects.
                // This value is the same for model binding and Json.Net's serialization.
                MaxDepth = DefaultMaxModelBindingRecursionDepth,
                NumberHandling = JsonNumberHandling.AllowReadingFromString,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = null, // leave property names unchanged (PascalCase for c#)
                ReadCommentHandling = JsonCommentHandling.Skip,
                WriteIndented = false,
            };

            /// <summary>
            /// Most used set of JsonSerializerOptions for use in every JsonSerializer.
            /// Provided as default set of options for SystemTextJsonMediaTypeFormatter used by our apis in DNN.
            /// Provided as default set of options for SystemTextJsonOutputFormatter used by apis in Oqtane.
            /// Compared to the default encoder, the UnsafeRelaxedJsonEscaping encoder is more permissive about allowing characters to pass through unescaped:
            /// - It doesn't escape HTML-sensitive characters such as <, >, &, and '.
            /// - It doesn't offer any additional defense-in-depth protections against XSS or information disclosure attacks, such as those which might result from the client and server disagreeing on the charset.
            /// Use the unsafe encoder only when it's known that the client will be interpreting the resulting payload as UTF-8 encoded JSON.
            /// For example, you can use it if the server is sending the response header Content-Type: application/json; charset=utf-8.
            /// Never allow the raw UnsafeRelaxedJsonEscaping output to be emitted into an HTML page or a <script> element.
            /// https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-character-encoding#serialize-all-characters
            /// </summary>
            public static JsonSerializerOptions UnsafeJsonWithoutEncodingHtml = new JsonSerializerOptions(DefaultOptions)
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            /// <summary>
            /// When json is used in html attributes, everything except basic charters should be encoded:
            /// - escape HTML-sensitive characters such as <, >, &, and '.
            /// - additional defense-in-depth protections against XSS or information disclosure attacks, such as those which might result from the client and server disagreeing on the charset.
            /// This is alternative to UnsafeJsonWithoutEncodingHtml that is using UnsafeRelaxedJsonEscaping encoder.
            /// </summary>
            public static JsonSerializerOptions SafeJsonForHtmlAttributes = new JsonSerializerOptions(DefaultOptions)
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.CurrencySymbols/*, UnicodeRanges.Latin1Supplement, UnicodeRanges.LatinExtendedA, UnicodeRanges.LatinExtendedB, UnicodeRanges.LatinExtendedC, UnicodeRanges.LatinExtendedD, UnicodeRanges.LatinExtendedE, UnicodeRanges.LatinExtendedAdditional*/),
            };
        }

        public class JsonDateTimeConverter : JsonConverter<DateTime>
        {
            public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return reader.GetDateTime().ToUniversalTime();
            }

            public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
            {
                // fix: 2 hours are subtracted from the time on each load
                // less decimals after seconds are to preserve compatibility with older api that used Newtonsoft
                writer.WriteStringValue(value/*.ToUniversalTime()*/.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            }
        }
#endif
    }
}
