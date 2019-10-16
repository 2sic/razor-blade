using System.Text.RegularExpressions;

namespace Connect.Razor.Blade
{
    public static partial class Tags
    {

        /// <summary>
        /// Convert \n into &lt;br&gt; line-breaks
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Nl2Br(string value) 
            => Text.Nl2X(value, "<br>");


        private static readonly Regex RelpacerBr = TagReplacer.Replacer("br");

        /// <summary>
        /// Convert &lt;br&gt; and &lt;br/&gt; into line-breaks
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Br2Nl(string value) 
            => RelpacerBr.Replace(value, "\n");

        /// <summary>
        /// Convert &lt;br&gt; and &lt;br/&gt; into line-breaks
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Br2Space(string value) 
            => RelpacerBr.Replace(value, " ");
    }
}
