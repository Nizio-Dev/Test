namespace Test.Person;

public class Person
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string Name { get; set; }
    
    public Address.Address Address { get; set; }
    
    public int Age { get; set; }
}