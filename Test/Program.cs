using Test.Address;
using Test.Country;
using Test.PaginatedList;
using Test.Person;
using Test.Person.Command.Update;
using Test.Person.Command.Update.Mappers;
using Test.Person.Query.Mappers;

var person1 = new Person
{
    Name = "Marian",
    Age = 40,
    Address = new Address
    {
        City = "Szczecin",
        Country = new Country
        {
            Name = "Poland",
            Population = 38_000_000
        }
    }
};

var person2 = new Person
{
    Name = "Mariola",
    Age = 39,
    Address = new Address
    {
        City = "Warszawa",
        Country = new Country
        {
            Name = "Poland",
            Population = 38_000_000
        }
    }
};

var person1Dto = person1.ToPersonDto();

var person2Dto = person2.ToPersonDto();

var paginatedList1 = new PaginatedList<Person>
{
    Elements = new List<Person>
    {
        new()
        {
            Name = "Maciek",
            Age = 21,
            Address = new Address
            {
                City = "Warszawa",
                Country = new Country
                {
                    Name = "Poland",
                    Population = 38_000_000
                }
            }
        },
        new()
        {
            Name = "Zdzisław",
            Age = 51,
            Address = new Address
            {
                City = "Gdańsk",
                Country = new Country
                {
                Name = "Poland",
                Population = 38_000_000
            }
            }
        },
        new()
        {
            Name = "Edward",
            Age = 32,
            Address = new Address
            {
                City = "Berlin",
                Country = new Country
                {
                Name = "Germany",
                Population = 80_000_000
            }
            }
        }
    }
};

var paginatedList2 = paginatedList1.ToPaginatedList(x => x.ToPersonDto());

var paginatedList3 = new PaginatedList<Country>
{
    Elements = new List<Country>
    {
        new()
        {
            Name = "Czech",
            Population = 10_000_000
        },
        new()
        {
            Name = "Philipines",
            Population = 110_000_000
        }
    }
};

var paginatedList4 = paginatedList3.ToPaginatedList(x => x.ToCountryDto());

var personUpdateCommand1 = new UpdatePersonCommand(new AddressDto(new CountryDto("Nowhere", 0), "Nowhere"));

person1.Update(personUpdateCommand1);

var xd = "";