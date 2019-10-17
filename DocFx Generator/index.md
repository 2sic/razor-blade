
<img src="images/logos/razor-blade-logo.png" width="100%">

# **API Docs** of _RazorBlade 3.0_

These docs are meant for programmers using [RazorBlade](https://github.com/DNN-Connect/razor-blade). These will usually be people working with C# and Razor, MVC etc.

## What you're probably looking for

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

1. We have an extensive [tutorial on 2sxc for using RazorBlade](https://2sxc.org/dnn-tutorials/en/razor/blade/home)
1. We also have many [blog posts on RazorBlade](https://2sxc.org/en/blog/tag/razor-blade)