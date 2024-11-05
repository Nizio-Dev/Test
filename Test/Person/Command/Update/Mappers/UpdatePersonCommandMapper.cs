namespace Test.Person.Command.Update.Mappers;

using Person = Person;

public static class UpdatePersonCommandMapper
{
    public static void Update(this Person destination, UpdatePersonCommand source)
    {
        destination.Address = source.Address.ToAddress();
    }
}