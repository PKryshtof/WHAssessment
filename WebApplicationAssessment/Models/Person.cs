namespace WebApplicationAssessment.Models
{
    public class Person
    {
        private readonly PersonTypes personType;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName, PersonTypes type)
        {
            personType = type;
            FirstName = firstName;
            LastName = lastName;
        }
        public PersonTypes PersonType
        {
            get
            {
                return personType;
            }
        }
    }
}
