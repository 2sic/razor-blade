namespace ToSic.Razor.Blade
{
    /// <summary>
    /// IScrub helps wash/clean html from things you want removed. It can take care of all tags, just specific tags or certain attributes.
    ///
    /// Note that it is implemented as an interface, so you must use **Dependency Injection** to get it. 
    /// </summary>
    /// <remarks>
    /// Added in v3.9
    /// </remarks>
    public interface IScrub
    {
        /// <summary>
        /// Remove all HTML tags from a string.
        /// </summary>
        /// <param name="original">Original HTML</param>
        /// <returns>A cleaned string without any HTML tags</returns>
        string All(string original);

        /// <summary>
        /// Remove one specific HTML tag from a string.
        /// </summary>
        /// <param name="original">Original HTML</param>
        /// <param name="tag">tag name to remove</param>
        /// <returns></returns>
        string Only(string original, string tag);

        /// <summary>
        /// Remove many specific HTML tags from a string.
        /// </summary>
        /// <param name="original">Original HTML</param>
        /// <param name="tags">one or more tags to remove</param>
        /// <returns></returns>
        string Only(string original, params string[] tags);

        ///<summary>
        /// Remove all HTML Tags except of a specified list
        /// </summary>
        /// <param name="original">Original HTML</param>
        /// <param name="tags">array defining the HTML Tags which shouldn't be removed</param>
        /// <returns>A string which doesn't contain the specified HTML Tags</returns>
        string Except(string original, params string[] tags);

        ///<summary>
        /// Remove all class attributes
        /// </summary>
        /// <param name="original">Original HTML</param>
        /// <returns>A string without any class=""/class=''/class= attributes</returns>
        string Classes(string original);

        /// <summary>
        /// Remove all HTML attributes.
        /// </summary>
        /// <param name="original">Original HTML</param>
        /// <returns>A string without any attributes inside the HTML Tags</returns>
        string Attributes(string original);

        /// <summary>
        /// Remove all instances of a specified attribute.
        /// </summary>
        /// <param name="original">Original HTML</param>
        /// <param name="attribute">string defining the attribute to remove</param>
        /// <returns>A string which doesn't contain the specified attribute</returns>
        string Attributes(string original, string attribute);

        /// <summary>
        /// Remove all instances of an array of specified attributes.
        /// </summary>
        /// <param name="original">Original HTML</param>
        /// <param name="attributes">array defining the attributes to remove</param>
        /// <returns>A string which doesn't contain the specified attributes</returns>
        string Attributes(string original, params string[] attributes);

        ///<summary>
        /// Remove all style attributes
        /// </summary>
        /// <param name="original">Original HTML</param>
        /// <returns>A string without any style=""/style=''/style= attributes</returns>
        string Styles(string original);

    }
}