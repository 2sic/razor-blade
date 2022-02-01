namespace ToSic.Razor.Blade
{
    public partial class Scrub
    {
        ///<summary>
        /// Remove all class attributes
        /// </summary>
        /// <param name="original">original string containing HTML</param>
        /// <returns>A string without any class=""/class=''/class= attributes</returns>
        public string Classes(string original) => Attributes(original, "class");
    }
}
