---
uid: ToSic.Razor.Blade
summary: *content
---
This is the main namespace you will be working with. Add it to your page like this:

```c#
@using ToSic.Razor.Blade;
```

After that you can simply use the commands - so here's a super simple cshtml file:

```c#
@using ToSic.Razor.Blade;
<div>
    @Text.Ellipsis("this text is much too long &amp; will need to be truncated...", 25)
</div>
```