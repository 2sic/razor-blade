<img src="/images/logos/razor-blade-logo.png" width="100%">

# Razor Guide FavIcons _v3.0_

## Background & Goal

This is based on information from sources like

* https://github.com/audreyr/favicon-cheat-sheet

Goal: Create a simple command for the default use case, and provide more complex options for advanced stuff.


## Basic Default Use Case

The default use case should

1. Take just 1 PNG image - to keep it simple. Ideally it could also contain placeholders like {h} & {w} or similar, which if provided would add the size properties to the url, for scenarios where you have an image resizer. This would allow you to do both:
   1. "/portals/0/favicon.png"
   1. "/portals/0/favicon.png?h={h}&w={w}" for ImageResizer.net
   1. "/portals/0/favicon.png?height={h}&width={w}" for Thorstons image resizer
   1. "/portals/0/favicons/icon-{h}x{w}.png" for pre-resized images

2. Generate the important headers, but not bloat the header with all possible sizes and variations. These would be:
   1. favicon for IE 11 - rel="shortcut icon", as png (supported in IE 11)  
      This will cover any IE11 favicon when an html-page is shown. Note that when the browser shows a pdf/image only, it doesn't have html to tell it about favicons, so that will still pick up favicon.ico in the root.

   2. general icon - rel="icon", as png, ideally at least 250x250
      this is for the general case, but actually I'm not even sure what case that is...

   3. touch-icons for mobile devices rel="apple-touch-icon" for 196x196  
      this supposedly works for iOS and Android.

3. Specifically, we would NOT support the following for now
   1. IE 6-10, as these are fully deprecated
   2. Mac Desktop icons
   3. Windows 10 desktop icons
   4. we won't implement rel="apple-touch-icon-precomposed" as that's only for ios 6 and below

So basically it is a command like:

```c#
HtmlPage.AddIcon("/portals/0/favicon.png")
```

## Advanced Use Cases

Advanced use cases should allow the following customizations, which limits or extends the icons added. 

* specific list of sizes
* specific list of known types (icon, shortcut icon, apple-touch...)

## Not Supported Use Cases

Basically anybody can always add more headers to the page using `HtmlPage.AddHeader(...)`, so it's not necessary to support every exotic variation. This command should make the 80% use cases super easy (just mention 1 file name) and the remaining 15% easy (with addition of parameters), but exotic stuff should not be covered until it's a common standard. These are things probably not supported in the basic API

* meta tag for msapplication-TileColor and msapplication-TileImage
* rel="apple-touch-icon-precomposed" as this is for older iOS and iOS devices usually update very often - see also https://mathiasbynens.be/notes/touch-icons

