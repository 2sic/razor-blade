namespace ToSic.Razor.Blade
{
    public partial class ScrubImplementation
    {
        ///<summary>
        /// Remove all style attributes
        /// </summary>
        /// <param name="html">original string containing HTML</param>
        /// <returns>A string without any style=""/style=''/style= attributes</returns>
        public string Styles(string html) => Attributes(html, "style");
    }
}
