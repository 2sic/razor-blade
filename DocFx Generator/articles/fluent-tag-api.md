<img src="/images/logos/razor-blade-logo.png" width="100%">

# Razor Blade Fluent Tag API _v3.0_

## The Tag Objects

The `Tag` objects generate Html tags inside _RazorBlade_ and provide a powerfull API will let you build html from code. 
These docs will give you what you need to leverage the object. 
Here you'll find:

1. a Quick-Reference for the common API
2. more instructions for doing specific things
3. advanced API for special stuff

To see this in action with many examples, visit the [RazorBlade Tutorials](https://2sxc.org/dnn-tutorials/en/razor/blade/home) on [2sxc.org](https://2sxc.org/).

## How to get Tag Objects

The following APIs will get you `Tag` objects:

1. `Tag.*()` where * is any standard HTML5 term, like `Div`, `Hr`, `IFrame` etc. - returns a typed object with more methods like `Src(url)` on `Tags.Img()` _v2.2_
1. `Tag.*(content)` same thing like above, but with content in the constructor
1. `Tags.*(content1, content2, ...)` same thing like above, but with much content in the constructor
1. `Tag.Custom(string tagName)` ([more](http://razor-blade.dnndev.me/api/ToSic.Razor.Blade.Tag.html#ToSic_Razor_Blade_Tag_Custom_System_String_System_Object___))

## Fluent API for Tag (Chaining)

All these methods of a `Tag` change the object, and return the object itself again. This fluent-API allows chaining them together, like 
```
someTag.Id("someId").Class("float-right")
```

Below we'll explain the methods that _all_ Tag objects have, but many have custom commands as well. 
For example, an `Img` Tag also has a `Src(...)` while an`A` Tag also has `href`. 
Some of the additional commands are extra-smart and automatically URI encode the value if not yet encoded.

## Modifying Tag Attributes

1. `Attr(name, [value], [separator])`  
add an attribute - if it already exists, it will replace the value, unless a separator is specified which will then append the new value.
     * `name`: _`string`, required_
     * `value`: _`string` | `object` | `null`, optional_  
     `Objects` will be JSON serialized; `null` will result in the attribute being added without a value, like `disabled`
     * `separator`: _`string`, default is ""_  
     Separation character if we have to append to an existing value. If null, will replace instead of append.
1. `Class(value)`  
set / add a class to the tag; if called multiple times, will append with a space between the original and new value. When calling with null, will reset the class to empty.
1. `Data(name, [value])`  
will add a `data-{name}='value'` attribute.
1. `Id(value)`  
set the id attribute - if called multiple times, will always replace previous id
1. `On(name, jsCode)`  
add an event-attribute like `onclick`
1. `Style(value)`  
set / add a class to the tag; if called multiple times, will append with a semicolon `;` between the original and new value. When calling with null, will reset the id to empty.
1. `Title(value)`  
set the title attribute - if called multiple times, will always replace previous title

## Modifying the Tag Contents

1. `Add(value)`  
Add something to contents - at the end of existing content.
    * `value`: _`string` | `Tag` | `IEnumerable<string|Tag>`_
1. `Add(value, value, ...)` _v2.2_  
Add a many items to contents - at the end of existing content.
    * `value`: _`string` | `Tag`_
1. `Wrap(value)`  
Replaces the content
    * `value`: _`string` | `Tag` | `IEnumerable<string|Tag>`_
1. `Wrap(value, value, ...)` _v2.2_  
Replaces the content with many items
    * `value`: _`string` | `Tag`_

## Output/Render API

A `Tag` object and the two properties `.Open` and `.Close` all support `IHtmlString`, so you can output them directly:

1. `@myTag`  
will render the tag into the html. Implements IHtmlString and will not be encoded.
2. `@myTag.TagStart`  
will render the opening tag to html. Implements IHtmlString and will not be encoded.
3. `myTag.TagEnd`  
will render the close-tag to html. Implements IHtmlString and will not be encoded.

_Note: the `TagStart` and `TagEnd` have unusually long names, to ensure that the terms won't collide with future attribute names like `Open` etc.


```razor
@using ToSic.Razor.Blade;
@Tags.Tag("br")
@Tags.Tag("div").Wrap("this is my message")
@{
  var myStyle = Tags.Tag("style");
}
@myStyle.Open
  .red { color: red};
@myStyle.Close
```

## All Html5 Tags and Attributes

The `Tag` object provides access to all known Html5 tags. Read the full [API](xref:ToSic.Razor.Blade.Tag)

<!-- 
## Options When Generating Custom Attributes and Tags

Options like `AttributeOptions` and `TagOptions` are an optional parameter in all generator-commands. It allows you to change how attributes are generated, but remember that the default is well thought through, so you usually won't need to use it.

### AttributeOptions _(new in 2.0)_

The object has the following properties and defaults:

1. `Quote` _string, default=`_ - the quote character used for wrapping values. The single-quote is the default, as it allows you to place json (which has double-quotes) in the value without having to encode the double quotes

2. `EncodeQuotes` _boolean, default=false_ - determines if quote-characters inside the value should be encoded when not necessary. So by default `data='{"key":"value"}` is what you get, but if you set it to true, you get `data='{&quot;key&quot;:&quot;value&quot;}`.

3. `KeepEmpty` _boolean, default=true_ - determines if empty attributes like `data` in `<div data=''></div>` are actually placed in the html, or filtered out.

This is how you would use these:

```razor
@* Example without options *@
<div @Attribute("data", "45")>...</div>

@* Example with options directly *@
<div @Attribute("data", "45", new AttributeOptions { KeepEmpty = false })>

@* Example with using options multiple times *@
@{
  var options = new AttributeOptions {
    Quotes = "\"",
    EncodeQuotes = false
  };
}
<div @Attribute("data", "45", options)></div>
```
--> 