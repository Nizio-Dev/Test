namespace Test.PaginatedList;

public class PaginatedList<T> where T : class
{
    public bool HasNextPage { get; set; }
    
    public int PageSize { get; set; }
    
    public List<T> Elements { get; set; }
}