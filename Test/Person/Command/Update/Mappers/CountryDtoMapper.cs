namespace Test.Person.Command.Update.Mappers;

using Country = Country.Country;

public static class CountryDtoMapper
{
    public static Country ToCountry(this CountryDto source) =>
        new()
        {
            Name = source.Name,
            Population = source.Population
        };
}