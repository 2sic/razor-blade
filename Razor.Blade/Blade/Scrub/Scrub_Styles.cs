namespace ToSic.Razor.Blade
{
    public partial class Scrub
    {
        ///<summary>
        /// Remove all style attributes
        /// </summary>
        /// <param name="original">original string containing HTML</param>
        /// <returns>A string without any style=""/style=''/style= attributes</returns>
        public string Styles(string original) => Attributes(original, "style");
    }
}
