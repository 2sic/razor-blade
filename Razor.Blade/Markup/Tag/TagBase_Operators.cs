namespace ToSic.Razor.Markup
{
    public partial class TagBase
    {

        public static TagBase operator +(TagBase a) => a;

        public static TagBase operator +(TagBase a, TagBase b) => new TagCustom().Wrap(a, b);

        public static string operator +(string a, TagBase b) => a + b.ToString();

        public static string operator +(TagBase a, string b) => a.ToString() + b;

        public static string operator +(int a, TagBase b) => a + b.ToString();

        public static string operator +(TagBase a, int b) => a.ToString() + b;

        public static string operator +(bool a, TagBase b) => a.ToString().ToLower() + b.ToString();

        public static string operator +(TagBase a, bool b) => a.ToString() + b.ToString().ToLower();
    }
}
