namespace WebApp
{
    public class Club
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int LeaguePoints { get; set; }
        public List<Player>? Players { get; set; }
    }
}
