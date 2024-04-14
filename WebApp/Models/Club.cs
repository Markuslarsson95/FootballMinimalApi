namespace WebApp.Models
{
    public class Club
    {
        public int Id { get; set; }
        public int? StadiumId { get; set; }
        public Stadium? Stadium { get; set; } = null!;
        public required string Name { get; set; }
        public int LeaguePoints { get; set; }
        public int MatchesPlayed { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Drawns { get; set; }
        public int Goals { get; set; }
        public int GoalsConceded { get; set; }
        public int CleanSheets { get; set; }
        public int YearFounded { get; set; }
        public List<Player>? Players { get; set; }
    }
}
