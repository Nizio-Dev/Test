namespace Test.Person.Command.Add.Mappers;

using Address = Address.Address;

public static class AddressDtoMapper
{
    public static Address ToAddress(this AddressDto source) =>
        new()
        {
            Country = source.Country.ToCountry(),
            City = source.City
        };

    public static void Update(this AddressDto source, Address destination)
    {
        destination.Country = source.Country.ToCountry();
        destination.City = source.City;
    }

}