namespace Test.Person.Query.Mappers;

using Country = Country.Country;

public static class CountryMapper
{
    public static CountryDto ToCountryDto(this Country source) =>
        new(source.Name, source.Population);
}