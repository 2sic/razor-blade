<img src="/images/logos/razor-blade-logo.png" width="100%">

# RazorBlade ChangeLog

## Version 4

### Version 4.0 (2022-12)

* Moved `ITag` Interface from `ToSic.Razor.Markup` to `ToSic.Razor.Blade` to make it easier to use in code.  
  **IMPORTANT** this could be a **breaking change** if you were referencing ITag in _compiled_ (dll) source code
* Created a new interface `IHtmlTag` which is supported by all generated code, and ensures you have methods such as `Add(...)` or `Wrap(...)` when using any tag generically.  
  It is available on `ToSic.Razor.Blade` so you don't need to add more namespaces
* .net Core build now requires .net6 (previously .net5)

## Version 3

### Version 3.0 (2019-10-21)

Released V3 which was a complete rework and had a new root namespace.

1. Created website with full API documentation [Razor-Blade.net](https://razor-blade.net)
1. Created all Html5 tags and quick-accessor using Tag.xxx

**Breaking Changes**

We really hate to introduce breaking changes, but 3.0 was a good opportunity for this. 

1. Renamed everything to use the namespace `ToSic.Razor.Blade` from previously `Connect.Razor.Blade`. This was improtant, because we decided to release RazorBlade as a NuGet package, and the previous namespace `Connect` didn't make any sense. 
1. Renamed the DLL to be in-line with the changes, which also means that previous code still works, because the new namespace can run side-by-side with the previous one
1. Reorganized some internal APIs, so they won't disturb in public documentation
1. Modified the `Text.First()` method so it could now take an unlimited amount of strings to pick the first one. 
1. Moved primary repo in Github to [2sic](https://github.com/2sic/razor-blade) 

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
1. Added `Text.After(...)`
1. Added `Text.AfterLast(...)`
1. Added `Text.Before(...)`
1. Added `Text.BeforeLast(...)`
1. Added `Text.Between(...)`

### V3.10 2022-02

1. Minor bugfixes and clean-up of tests

--- 

## Version 2

### Version 2.02 (2019-10-15)

1. Improved the `Add` and `Wrap` on the fluid API
1. `AddIconSet(...)` now defaults to using the provided image as the favicon

### Version 02.01 (2019-10-14)

1. `HtmlPage` got `AddIcon` and `AddIconSet` - see [tutorial](https://2sxc.org/dnn-tutorials/en/razor/blade340/page/mode/set)

### Version 2.00 (2019-04-09)

1. Released first draft of Fluent Tag API which was later brought to final in 3.0

--- 

## Version 1

### Version 1.02 (2019-04-05)

1. Created draft `HtmlTags` API - which was later completed in 3.0

### Version 1.01 (2019-02-27)

1. Created `HtmlPage` API to read/write DNN header properties and add all kind of headers

### Version 1.00 (2019-02-17)

1. Released RazorBlade
1. Created `Text...` and `Tags...` API
1. Released it as a DNN Extension Library on Github