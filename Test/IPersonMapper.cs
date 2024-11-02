using System.Data;

namespace Test;

public interface IPersonMapper
{
   public IEnumerable<Person> Map(IDataReader dataReader);

   public PaginatedList<PersonDto> Map(PaginatedList<Person> paginatedList);

   public IEnumerable<PersonDto> Map(IEnumerable<Person> persons);

   public void Update(PersonDto personDto, Person person);
}