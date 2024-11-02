namespace Test;

public interface IPaginatedListMapper
{
   PaginatedList<TDestination> Map<TSource, TDestination>(PaginatedList<TSource> source) where TDestination : class where TSource : class;
}