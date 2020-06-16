namespace WebApplicationAssessment.Models
{
    public class RedBet : Person
    {
        public string Adress { get; set; }
        public string FavoriteFootballTeam { get; set; }

        public RedBet(string firstName, string lastName, string adress, string favoriteFootballTeam)
            : base(firstName, lastName, PersonTypes.RedBed)
        {
            Adress = adress;
            FavoriteFootballTeam = favoriteFootballTeam;
        }
    }
}
