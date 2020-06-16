namespace WebApplicationAssessment.Models
{
    public class MrGreen : Person
    {
        public string Adress { get; set; }
        public int PersonalNumber { get; set; }
        public MrGreen(string firstName, string lastName, string adress, int personalNumber)
            : base(firstName, lastName, PersonTypes.MrGreen)
        {
            Adress = adress;
            PersonalNumber = personalNumber;
        }
    }
}
