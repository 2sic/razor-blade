namespace ToSic.Razor.Blade
{
    public partial class ScrubImplementation
    {
        ///<summary>
        /// Remove all class attributes
        /// </summary>
        /// <param name="html">original string containing HTML</param>
        /// <returns>A string without any class=""/class=''/class= attributes</returns>
        public string Classes(string html) => Attributes(html, "class");
    }
}
