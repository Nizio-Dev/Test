namespace Test.Person.Command.Add;

public record AddPersonCommand(string Name, AddressDto Address, int Age);