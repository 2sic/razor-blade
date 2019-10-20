namespace ToSic.Razor.Blade
{
    /// <summary>
    /// Helper to quickly generate <em>all</em> HTML5 tags with a <strong>Tag.Img()</strong> or <strong>Tag.Table()</strong> syntax.
    /// This is the easiest and safest way to use in in Razor templates because you won't have naming issues etc.
    /// <br/>
    /// The objects are smart - for example this will automatically uri-encode 😎
    /// <code>Tag.Img().Src("ünsafe.jpg")</code> 
    /// <em>Important: <em>Tag</em> can easily be confused with the <em>Tags</em> object.</em> <br/>
    /// <em>new in 3.0</em>
    /// </summary>
    /// <seealso cref="Tags"/>
    public partial class Tag
    {
    }
}
