namespace Test.Person.Command.Add.Mappers;

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