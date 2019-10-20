<img src="/images/logos/razor-blade-logo.png" width="100%">

# Razor Guide to HtmlPage _v3.0_

## Properties To Change Title, Description, Keywords

1. `HtmlPage.Description` (get/set) - Read/Write the page description. _v1.1_

1. `HtmlPage.Keywords` (get/set) - Read/Write the page keywords. _v1.1_

1. `HtmlPage.Title` (get/set) - Read/Write the page title. _v1.1_

## Commands to Add Headers

1. `HtmlPage.AddMeta(name, content)` - Adds a meta-tag with this name and content to the header. _v1.1_

1. `HtmlPage.AddJsonLd(...)` create a [JSON-LD (linked data) header](https://en.wikipedia.org/wiki/JSON-LD) see also [google guideline](https://developers.google.com/search/docs/guides/intro-structured-data) and [Schema.org](https://schema.org/). _v1.1_
    1. `HtmlPage.AddToJsonLd(string)` - uses a string, which should already be a valid json
    1. `HtmlPage.AddToJsonLd(object)` - will JSON-serialize whatever you pass into it. For now, we recommend using `Dictionary<string, object>` to prepare the data you want to add. 

1. `HtmlPage.AddOpenGraph(property, content)` add an [open-graph tag](http://ogp.me/) to the header for facebook, twitter and co. _v1.1_

1. `HtmlPage.AddToHead(string)` - Add anything to the `<head>` section of the page. The string should usually contain a meta, link or script tag. _v1.1_

1. `HtmlPage.AddIcon(path)` add an icon (favicon) to the page _v2.1_
    1. `...AddIcon(path, rel: string, size: int, type: string)` - all optional parameters to specify things like
        * `rel`: the rel-text, default is 'icon'. common terms are also 'shortcut icon' or 'apple-touch-icon
        * `size`: will be used in size='#x#' tag; only relevant if you want to provide multiple separate sizes
        * `type`: optional type, if not provided, will be auto-detected from known types or remain empty
1. `HtmlPage.AddIconSet(path)` add a few icon headers to the page according to best practices _v2.1_
    1. `...AddIconSet(path, favicon: bool|string, rels: IEnumerable<string>, sizes: IEnumerable<int>)` - all optional parameters to specify things like
        * `favicon`: boolean - auto-add a default favicon tag (or not)
        * `favicon`: string - use this url for the favicon tag
        * `rels`: list/array of rel-texts (a separate icon tag will be generated for each rel)
        * `sizes`: list/array of sizes (a separate icon tag will be generate for each size)  
        _note: if you supply `rels` and `sizes`, then all combinations of icon tags will be added_  
        _note: you can't specify the type, as each one could be different - the auto-detection will take care of this for you_


## Performance Optimizations

The commands above are available for comfortable use. Internally, each command finds the page object and manipulates it. If you would like to optimize the code a bit, the `GetPage()` command gives you an object with the same features, but will run a few percent faster. So you can also do this:

```cs
var p = HtmlPage.GetPage();
p.Title = "...";
p.Keywords = "...;
```
