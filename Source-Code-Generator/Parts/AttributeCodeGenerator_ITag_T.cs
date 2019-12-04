//using System.Linq;

//namespace SourceCodeGenerator.Parts
//{
//    public partial class AttributeCodeGenerator

//    {
//        internal static string CodeForITagT(TagCodeGenerator tag) =>
//                $@"
//    #region Standard {tag.ClassName} Attributes from ITag<T>
//        {TagTCalls(tag)}
//    #endregion";
                

//        private static string TagTCalls(TagCodeGenerator tag) => $@"
///// <inheritdoc />
//public {tag.ClassName} Attr(string name, object value = null, string appendSeparator = null) => this.InternalAttr(name, value, appendSeparator);

///// <inheritdoc />
//public {tag.ClassName} AttrUrl(string name, object value = null, string appendSeparator = null) => this.InternalAttrUrl(name, value, appendSeparator);

///// <inheritdoc />
//public {tag.ClassName} Id(string id) => this.InternalId(id);

///// <inheritdoc />
//public {tag.ClassName} Class(string value) => this.InternalClass(value);

///// <inheritdoc />
//public {tag.ClassName} Style(string value) => this.InternalStyle(value);

///// <inheritdoc />
//public {tag.ClassName} Data(string name, object value = null) => this.InternalData(name, value);

///// <inheritdoc />
//public {tag.ClassName} On(string name, object value = null) => this.InternalOn(name, value);

///// <inheritdoc />
//public {tag.ClassName} Add(object child) => this.InternalAdd(child);


///// <inheritdoc />
//public {tag.ClassName} Add(params object[] children) => this.InternalAdd(children);

///// <inheritdoc />
//public {tag.ClassName} Title(string title) => this.InternalTitle(title);


///// <inheritdoc />
//public {tag.ClassName} Wrap(object content) => this.InternalWrap(content);

///// <inheritdoc />
//public {tag.ClassName} Wrap(params object[] content) => this.InternalWrap(content);
//";


//    }
//}
