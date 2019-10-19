---
uid: ToSic.Razor.Html5
summary: *content
---
This namespace is responsible for all HTML5 tags inside razor. You could use it, but usually you'll use the shortcut from the 

```c#
@using ToSic.Razor.Blade;
```

After that you can simply use the commands - so here's a super simple cshtml file:

```c#
@using ToSic.Razor.Blade;
<div>
    @Tag.A("this text is much too long &amp; will need to be truncated...", 25)
</div>
```