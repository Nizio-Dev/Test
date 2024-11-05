namespace Test.Person.Query.Mappers;

using Address = Address.Address;

public static class AddressMapper
{
    public static AddressDto ToAddressDto(this Address source) =>
        new(source.Country.ToCountryDto());
}