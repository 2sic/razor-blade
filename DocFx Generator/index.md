
<img src="images/logos/razor-blade-logo.png" width="100%">

# **API Docs of _RazorBlade 3.09_**

These docs are meant for programmers using [RazorBlade](https://github.com/2sic/razor-blade). These will usually be people working with C# and Razor, MVC etc.

## APIs you're probably looking for

1. [APIs for **Text**](xref:ToSic.Razor.Blade.Text) with commands like  
	`Crop(...)`, `Ellipsis(...)`, `First(...)`, `Has(...)`, `Zip(...)`
1. [API for **Tags**](xref:ToSic.Razor.Blade.Tags) with commands like
   1. Text to HTML conversions: `Br2Nl(...)`, `Br2Space(...)`, `Decode(...)`, `Encode(...)`, `Nl2Br(...)`, ...
   1. Html generators: `Attribute(...)`, `Attributes(...)`, `Tag(...)`
1. [API for **Tag**](xref:ToSic.Razor.Blade.Tag) with all known html5 tags like  
   `A(...)`, `Abbr(...)`, `Address(...)`, `Area(...)` all the way to `Wbr(...)`
1. [API for **HtmlPage**](xref:ToSic.Razor.Blade.HtmlPage) with
  1. Page properties (get/set): `Description`, `Keywords`, `Title`, ...
  1. Methods to add headers: `AddIcon(...)`, `AddIconSet(...)`, `AddJsonLd(...)`, `AddMeta(...)`, ...
   

## Tutorials & Blogs

1. An explanation of the [Fluent Tag API](articles/fluent-tag-api.md)
1. We have an extensive [tutorial on 2sxc for using RazorBlade](https://2sxc.org/dnn-tutorials/en/razor/blade/home)
1. We also have many [blog posts on RazorBlade](https://2sxc.org/en/blog/tag/razor-blade)

## What is RazorBlade 3?

A library of common functions for Razor, to lighten Razor templates and make work easier. Some examples:

_You need to change the page title and some headers from a razor template:_

```razor
@using ToSic.Razor.Blade;
HtmlPage.Title = "Title changed using Razor Blade! original";
HtmlPage.Description = "Learn to use Razor Blade " + HtmlPage.Description;
HtmlPage.Keywords = "Tutorial, Razor, Blade" + HtmlPage.Keywords;
HtmlPage.AddMeta("somename", "somevalue");
HtmlPage.AddIcon("iconfile.png");
```

_You need the first 100 characters followed by an ellipsis (if truncated), but umlauts like `&uuml;` will mess up your count or might even be cut off. This is automatically handled by:_

```razor
  @* just cut it off at the visible character count, not splitting words *@
  @Text.Crop(someText, 100)

  @* truncate a text and if necessary, add ellipsis character *@
  @Text.Ellipsis(longText, 100)

  @* now the same thing, with text having html-tags *@
  @Text.Ellipsis(Tags.Strip(longText), 100)
```

_You need a value, but if it's empty (null, spaces, line-breaks, `&nbsp;` etc.), you need another one:_

```razor
  @* Do this *@
  @Text.First(firstName, "nothing found");

  @* instead of this *@
  @if(String.IsNullOrWhiteSpace(firstName as string)) {
    @"nothing found"
  } else {
    @firstName
  }
```

_Note that HTML whitespace like `&nbsp;` will also be treated as empty, unless you add `false` as a last parameter. But RazorBlade does more than just skip empty texts, here some more examples:_

```razor
  @* First non-empty of many possible values *@
  @Text.First(nameFromDb, nameFromProfile, defaultNameForThisCountry, "unknown")

  @* remove html from a wysiwyg-string *@
  @Tags.Strip(formattedText)

  @* the same with a custom ending *@
  @Text.Ellipsis(longText, 100, "...more")

  @* an it won't cut off in the middle of &auml; *@
  @Text.Ellipsis("Visit M&uuml;nchen", 10)

```

## Nice to Know

**RazorBlade** has more than 250 unit tests to make it rock-solid!

## Change History

### V3.00 2019-10

Released V3 which was a complete rework and had a new root namespace.

### V3.01 2019-12

Minor fixes / changes which required a version bump.

### V3.02 2020-04

1. Added Tags.SafeUrl()

### V3.03 - V3.06 2021

1. Added support for .net 5 and Oqtane
1. Deprecating support for the `HtmlPage` because it won't work in .net core

### V3.07 2021-09

1. Created `Tag.RawHtml(...)`
1. `Tag.Attr(...)` now can also accept ITag values like prepared attributes

### V3.08 2022-01

1. Improved `Tag.Custom(...)` and `Tag.RawHtml(...)`

### V3.09 2022-02

1. Added new IScrub system and ca. 100 unit tests
1. Implemented DI support