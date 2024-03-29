<img src="docs/assets/razor-blade-logo.png" width="100%">

# Razor Blade 4.00

A library of common functions for Razor, to lighten Razor templates and make work easier.

## Documentation and Tutorials

* [Full API Documentation](https://razor-blade.net)
* [Tutorials](https://2sxc.org/dnn-tutorials/en/razor/blade/home)
* [Blog Posts](https://2sxc.org/en/blog/tag/razor-blade)

## Some Examples

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

## Using Razor Blade

You can use **Razor Blade** with any asp.net project, just by including the DLLs, or if you're using DNN, you can install the extension from the [releases on Github](https://github.com/2sic/razor-blade/releases). Note that if you are have [2sxc](https://github.com/2sic/2sxc) 10.9+ installed, it will automatically also install RazorBlade 3.

In your c# code, add the following line to then have access to all the commands:

```razor
@using ToSic.Razor.Blade;
```

## Quick Command Reference Sheet

This is a short summary of the most used variations of the helpers. Further details and syntaxes are listed further down.

1. **Tags** - see [see Tags API docs](https://razor-blade.net/api/ToSic.Razor.Blade.Tags.html)  
  `Tags.Br2Nl(text)`, `Tags.Br2Space(text)`, `Tags.Nl2Br(text)`,  
  `Tags.Strip(text)`,  
  `Tags.Encode(...)`, `Tags.Decode(...)` etc.

1. **Tag** - see [Fluent API](https://razor-blade.net/articles/fluent-tag-api.html) and [Tag API docs](https://razor-blade.net/api/ToSic.Razor.Blade.Tag.html)  
  contains `Tag.A(...)` up to `Tag.Wbr(...)` (all knows Html5 tags),
  `Tag.Tag(...)` for all custom tags and `Tag.Attribute(...)`

2. **Text** - see [API docs](https://razor-blade.net/api/ToSic.Razor.Blade.Text.html)  
  `Text.Crop(string, length)`, `Text.Ellipsis(value, length)`,  
  `Text.Has(value)`, `Text.First(value, value[, moreValues, ...])`, `Text.Zip(value)`, ...

3. **HtmlPage** - see [detailed docs](https://razor-blade.net/api/ToSic.Razor.Blade.HtmlPage.html)  
    1. get/set `HtmlPage.Title`, `HtmlPage.Description`, `HtmlPage.Keywords`
    1. `HtmlPage.AddBase()`, `HtmlPage.AddBase(url)` - set automatic base tag
    1. `HtmlPage.AddMeta(name, content)` add a meta-tag to the header
    1. `HtmlPage.AddJsonLd(string|object)` create a [Json-LD header](https://en.wikipedia.org/wiki/JSON-LD) see also [google guideline](https://developers.google.com/search/docs/guides/intro-structured-data)
    1. `HtmlPage.AddOpenGraph(property, content)` add an [open-graph tag](http://ogp.me/) to the header for facebook, twitter and co.
    1. `HtmlPage.AddToHead(tagString)` add any tag string into the page `<head>` section
    1. `HtmlPage.AddToHead(tagObject)` add any tag object into the page `<head>` section _v2.1_
    1. `HtmlPage.AddIcon(path)` add an icon (favicon) to the page _v2.1_
    1. `HtmlPage.AddIconSet(path)` add a few icon headers to the page according to best practices _v2.1_
    1. `GetPage()` get an object with the same commands as HtmlPage, but a bit faster _v2.2_

## Work in Progress v3.1+ (WIP / in discussion)

1. **Url**
    1. SeoFragment(string) - in discussion, would take a string and save-convert it so it can be added to a url for SEO.
    2. AddParameters(...) - would add more url-parameters, and ensure that it only has one ? etc.

## Ideas to discuss

1. `Tags.Strip(htmlText, tagName)`
1. `Tags.Strip(htmlText, csvListOfTagsToStrip)`
1. `Tags.Wrap(tagName, content, id, cls, attr)` - something which puts a tag (like a div, span, p) around some content
1. `Tags.Replace(htmlText, listOfTags, replacementTag)`
1. (place other wishes into issues for discussion)
1. `Dic.ToDynamic(dictionary)` - converts a Dictionary to an expando object, so you can write `obj.Property` instead of `obj["Property"]`; would return null if a property would not be found.
1. `Mail.Generate(pathToRazor, objValues)` - uses a razor template to generate a mail.

Here you can also find [scrapped ideas](scrapped.md).

## Your Contributions

1. Any tests and bugfixes are always welcome and will be processed quickly by iJungleboy.
1. New commands / overloads / features should be discussed in issues before adding to this library, to ensure that it's inline with the overal purpose of this library.

Please also read the [conventions](conventions.md) so we can work on this together.

## History / Change Log

👉🏽 See [Change Log](https://razor-blade.net/articles/changelog.html)
