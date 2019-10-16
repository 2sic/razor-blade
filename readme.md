<img src="docs/assets/razor-blade-logo.png" width="100%">

# Razor Blade v2.99 - preparing for 3.0 release

A library of common functions for Razor, to lighten Razor templates and make work easier. Some examples:

_You need to change the page title and some headers from a razor template:_

```razor
@using Connect.Razor.Blade;
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

You can use **Razor Blade** with any asp.net project, just by including the DLLs, or if you're using DNN, you can install the extension from the [releases on Github](https://github.com/DNN-Connect/razor-blade/releases). Note that if you are have [2sxc](https://github.com/2sic/2sxc) 9.40+ installed, it will automatically also install Razor Blade.

In your c# code, add the following line to then have access to all the commands:

```razor
@using Connect.Razor.Blade;
```

We have also created a [Razor Blade tutorial app](https://github.com/DNN-Connect/razor-blade-tutorial-app).

## Quick Command Reference Sheet

This is a short summary of the most used variations of the helpers. Further details and syntaxes are listed further down.

1. **Tags** - see [detailed docs](docs/tags.md)
    1. `Tags.Br2Nl(text)`
    2. `Tags.Br2Space(text)`
    3. `Tags.Nl2Br(text)`
    4. `Tags.Strip(text)`
    5. `Tags.Encode(...)` _v1.2_
    6. `Tags.Decode(...)` _v1.2_
    7. `Tags.Attribute(...)` _v2.0_
    8. `Tags.Tag(...)` with fluent API - [docs](docs/tag.md) _v2.0_

2. **Text** - see [detailed docs](docs/text.md)
    1. `Text.Crop(string, length)`
    2. `Text.Ellipsis(value, length)`
    3. `Text.Has(value)`
    4. `Text.First(value, value[, moreValues, ...])`
    5. `Text.Zip(value)`

3. **HtmlPage** - for v1.1 see [detailed docs](docs/htmlpage.md)
    1. `HtmlPage.Title` get-set property
    1. `HtmlPage.Description` get-set property
    1. `HtmlPage.Keywords` get-set property
    1. `HtmlPage.AddMeta(name, content)` add a meta-tag to the header
    1. `HtmlPage.AddJsonLd(string|object)` create a [Json-LD header](https://en.wikipedia.org/wiki/JSON-LD) see also [google guideline](https://developers.google.com/search/docs/guides/intro-structured-data)
    1. `HtmlPage.AddOpenGraph(property, content)` add an [open-graph tag](http://ogp.me/) to the header for facebook, twitter and co.
    1. `HtmlPage.AddToHead(tagString)` add any tag string into the page `<head>` section
    1. `HtmlPage.AddToHead(tagObject)` add any tag object into the page `<head>` section _v2.1_
    1. `HtmlPage.AddIcon(path)` add an icon (favicon) to the page _v2.1_
    1. `HtmlPage.AddIconSet(path)` add a few icon headers to the page according to best practices _v2.1_
    1. `GetPage()` get an object with the same commands as HtmlPage, but a bit faster _v2.2_


## Work in Progress v2.2

* Typed tag objects for everything in HTML5 like `Img`, `Meta`, etc.

## Work in Progress v2.5+ (WIP / in discussion)

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

Here you can also find [scrapped ideas](docs/scrapped.md).

## Your Contributions

1. Any tests and bugfixes are always welcome and will be processed quickly by iJungleboy.
1. New commands / overloads / features should be discussed in issues before adding to this library, to ensure that it's inline with the overal purpose of this library.

Please also read the [conventions](docs/conventions.md) so we can work on this together.