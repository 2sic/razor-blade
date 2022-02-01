namespace ToSic.Razor.Markup
{
    /// <summary>
    /// Describes an attribute on an HTML tag. You usually won't need this API. 
    /// </summary>
    public class Attribute: AttributeBase
    {
        public Attribute(string name, object value = null, AttributeOptions options = null)
            : base(name, value, options) { }

    }
}
