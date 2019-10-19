namespace ToSic.Razor.Blade
{
    /// <summary>
    /// Helper to quickly generate all HTML5 tags with a <strong>Tag.Img()</strong> syntax.
    /// This is the easiest and safest way to use in in Razor templates because you won't have naming issues etc.
    /// <br/>
    /// The objects are smart - for example <code>Tag.Img().Src("ünsafe.jpg")</code> will automatically uri-encode ;)
    /// <br/>
    /// <em>Important: This can easily be confused with the Tags object which has another purpose.</em>
    /// </summary>
    /// <seealso cref="Tags"/>
    public partial class Tag
    {
    }
}
