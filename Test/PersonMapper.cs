using System.Data;
using Riok.Mapperly.Abstractions;

namespace Test;

[Mapper]
public partial class PersonMapper : IPersonMapper
{
    public IEnumerable<Person> Map(IDataReader dataReader)
    {
        var persons= new List<Person>();

        while (dataReader.Read())
        {
            persons.Add(new Person(
                (string)dataReader["name"],
                (int)dataReader["age"]));
        }

        return persons;
    }

    public partial PaginatedList<PersonDto> Map(PaginatedList<Person> paginatedList);
    
    public partial IEnumerable<PersonDto> Map(IEnumerable<Person> persons);

    public partial void Update(PersonDto personDto, Person person);
}