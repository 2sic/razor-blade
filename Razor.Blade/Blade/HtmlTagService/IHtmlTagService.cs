namespace ToSic.Razor.Blade
{
    /// <summary>
    /// The service to generate HTML Tags.
    ///
    /// > [!TIP]
    /// > This is the new, recommended way of generating tags, as it's better and **functional**
    /// 
    /// > [!WARNING]
    /// > This looks almost the same as the static `ToSic.Razor.Blade.Tag` but there is a crucial difference
    /// > The APIs return **functional** `IHtmlTag` objects.
    /// > This is safer and more future proof, but you may run into surprises.
    /// 
    /// Example:
    /// ```c#
    /// // Old Tag API - these two objects will be the same
    /// var tagOld = ToSic.Razor.Blade.Tag.Div();
    /// var tagOldWithId = tagOld.Id(...).Style(...).Class(...);
    /// // now tagOld and tagOldWithId are both the same objects with all changes applied
    ///
    /// // New API - assumes tagSvc is IHtmlTagService
    /// // these two objects will NOT be the same
    /// var tag = tagSvc.Div();
    /// var tagWithId = tag.Id(...).Style(...).Class(...);
    /// // now tag is still an empty div-tag
    /// // while tagWithId is the tag wth everything set on 
    /// ```
    /// </summary>
    /// <remarks>
    /// * Introduced in v4.0
    /// * It intentionally uses the term "Service" in the end (different from <see cref="IScrub"/> to prevent confusion with <see cref="IHtmlTag"/>.
    /// </remarks>
    public partial interface IHtmlTagService
    {

    }
}
