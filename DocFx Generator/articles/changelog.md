<img src="/images/logos/razor-blade-logo.png" width="100%">

# RazorBlade ChangeLog

## Version 3

### Version 3.0 (2019-10-21)

1. Created website with full API documentation [Razor-Blade.net](https://razor-blade.net)
1. Created all Html5 tags and quick-accessor using Tag.xxx

**Breaking Changes**

We really hate to introduce breaking changes, but 3.0 was a good opportunity for this. 

1. Renamed everything to use the namespace `ToSic.Razor.Blade` from previously `Connect.Razor.Blade`. This was improtant, because we decided to release RazorBlade as a NuGet package, and the previous namespace `Connect` didn't make any sense. 
1. Renamed the DLL to be in-line with the changes, which also means that previous code still works, because the new namespace can run side-by-side with the previous one
1. Reorganized some internal APIs, so they won't disturb in public documentation
1. Modified the `Text.First()` method so it could now take an unlimited amount of strings to pick the first one. 
1. Moved primary repo in Github to [2sic](https://github.com/2sic/razor-blade) 

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