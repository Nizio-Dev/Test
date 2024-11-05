namespace Test.Person.Command.Add.Mappers;

public static class AddPersonCommandMapper
{
    public static Test.Person.Person ToPerson(this AddPersonCommand source) =>
        new()
        {
            Name = source.Name,
            Address = source.Address.ToAddress(),
            Age = source.Age
        };
}