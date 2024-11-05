namespace Test.PaginatedList;

public static class PaginatedListMapper
{
    public static PaginatedList<TDestination> ToPaginatedList<TSource, TDestination>(
        this PaginatedList<TSource> source, Func<TSource, TDestination> map)
        where TDestination : class where TSource : class =>
        new()
        {
            PageSize = source.PageSize,
            HasNextPage = source.HasNextPage,
            Elements = source.Elements.Select(map).ToList()
        };
}