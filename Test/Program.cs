using Test;

var personMapper = new PersonMapper();

var dataReader = DataBuilder.BuildDataReader();

var persons = personMapper.Map(dataReader);

var paginatedList1 = new PaginatedList<Person>
{
    Elements = new List<Person>
    {
        new("Damian", 26),
        new("Bartek", 24)
    }
};

var paginatedList2 = personMapper.Map(paginatedList1);

var paginatedList3 = personMapper.Map(persons);

var person1 = new Person("Maria", 40);

var person1UpdatedDto = new PersonDto("Mariola", 41);

personMapper.Update(person1UpdatedDto, person1);

var xd = "";