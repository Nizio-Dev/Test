namespace Test.Person.Command.Update.Mappers;

using Address = Address.Address;

public static class AddressDtoMapper
{
    public static Address ToAddress(this AddressDto source) =>
        new()
        {
            Country = source.Country.ToCountry(),
            City = source.City
        };
}