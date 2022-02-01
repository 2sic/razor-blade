using System;
using System.Net;
#if NET5_0_OR_GREATER
using System.Text.Json;
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
            // First - try if the environment had provided an Delegate for this
            if (ObjToJsonString != null)
                return ObjToJsonString(jsonObject);
#if NETFRAMEWORK
            return new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(jsonObject);
#elif NETCOREAPP
            return JsonSerializer.Serialize(jsonObject);
#else
            throw new NotImplementedException(
                "Serialization for .net standard doesn't exist, feel free to add this; " +
                "just make sure that the project still compiles and doesn't have new dependencies for the .net40 release");
#endif
        }

        /// <summary>
        /// Special function to create Json which would be provided from external at start-up.
        /// This is to ensure .net standard2 can have a ToJson even if .net standard2 would otherwise need more dependencies.
        /// </summary>
        internal static Func<object, string> ObjToJsonString;

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
    }
}
