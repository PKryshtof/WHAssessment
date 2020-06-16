using Newtonsoft.Json.Linq;
using WebApplicationAssessment.Models;

namespace WebApplicationAssessment.Factories
{
    public class RedBetFactory: PersonFactory
    {
        private string footballTeamName;
        public RedBetFactory(string firstName, string lastName, string adress, string footballTeamName)
        {
            base.firstName = firstName;
            base.lastName = lastName;
            base.adress = adress;
            this.footballTeamName = footballTeamName;
        }

        public RedBetFactory(JObject json)
        {
            base.firstName = (string)json[JsonConsts.FirstName];
            base.lastName = (string)json[JsonConsts.LastName];
            base.adress = (string)json[JsonConsts.Adress];
            this.footballTeamName = (string)json[JsonConsts.FavouriteFootbalTeam];
        }

        public override Person GetPerson()
        {
            return new RedBet(firstName, lastName, adress, footballTeamName);
        }
    }
}
