<img src="/images/logos/razor-blade-logo.png" width="100%">

# RazorBlade ChangeLog

## Version 4

### Version 4.0 (2022-12)

* Created a new interface [`IHtmlTag`](xref:ToSic.Razor.Blade.IHtmlTag) which is supported by all generated code, and ensures you have methods such as `Add(...)` or `Wrap(...)` when using any tag generically.  
  It is available on `ToSic.Razor.Blade` so you don't need to add more namespaces
* Create a new `ToSic.Razor.Blade.IHtmlTagService` which provides the same functionality as the static `Blade.Tag` API, but with immutable objects (see below)
* All generated tags like `Div`, `H2` etc. can now be immutable.
  * The existing `ToSic.Razor.Blade.Tag.TAGNAME(...)` apis continue to deliver mutable objects (like before)
  * The new `IHtmlTagService` provides immutable objects. This can lead to surprising effects when migrating existing code, so that should best continue to use the old `Blade.Tag...`
* .net Core build now requires .net6 (previously .net5)
* Removed the `StartUp.RegisterToJson(...)` method which was used at StartUp in special cases to register alternate json-serializer
* The `AttributeOptions` and `TagOptions` were made read-only for reliable fluid / immutable APIs.
  This is kind of a **breaking change** but we believe it won't affect anybody.
  since it was basically an internal API which nobody used outside of this.
* Changed minimum requirement on `Razor.Blade.Dnn` to be DNN 9.6.1

## Version 3

### Version 3.0 (2019-10-21)

Released V3 which was a complete rework and had a new root namespace.

1. Created website with full API documentation [Razor-Blade.net](https://razor-blade.net)
1. Created all Html5 tags and quick-accessor using Tag.xxx

#### Breaking Changes

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
1. Various null-checks/bugfixes
1. Operators to enable adding Tags like `Tag.P() + Tag.Div()`
1. Adding tag contents with IEnumerable (previously only Arrays worked)
1. Fix Json serialization for Oqtane (previously internal ToJson only worked in .net 451)
1. Will probably be bundled with 2sxc 12.05
1. Removed the `IHtmlPage` interface from the docs as it shouldn't be used any more

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
