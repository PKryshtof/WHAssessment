using Newtonsoft.Json.Linq;
using WebApplicationAssessment.Models;

namespace WebApplicationAssessment.Factories
{
    public class MrGreenFactory : PersonFactory
    {
        private int personalNumber;
        public MrGreenFactory(string firstName, string lastName, string adress, int personalNumber)
        {
            base.firstName = firstName;
            base.lastName = lastName;
            base.adress = adress;
            this.personalNumber = personalNumber;

        }

        public MrGreenFactory(JObject json)
        {
            base.firstName = (string)json[JsonConsts.FirstName];
            base.lastName = (string)json[JsonConsts.LastName];
            base.adress = (string)json[JsonConsts.Adress];
            this.personalNumber = (int)json[JsonConsts.PersonalNumber];
        }

        public override Person GetPerson()
        {
            return new MrGreen(firstName, lastName, adress, personalNumber);
        }
    }
}
