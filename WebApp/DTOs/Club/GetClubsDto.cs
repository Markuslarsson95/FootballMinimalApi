namespace WebApp.DTOs.Club
{
    public record GetClubsDto(int Id, string Name, int LeaguePoints, List<Player>? Players);
}
