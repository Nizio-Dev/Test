namespace Test.Person.Query.Mappers;

public static class PersonMapper
{
    public static PersonDto ToPersonDto(this Test.Person.Person person) =>
        new(person.Name, person.Address.ToAddressDto());
}