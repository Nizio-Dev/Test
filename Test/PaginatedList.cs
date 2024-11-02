namespace Test;

public class PaginatedList<T> where T : class
{
    public List<T> Elements { get; set; }
}