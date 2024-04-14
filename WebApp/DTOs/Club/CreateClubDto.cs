namespace WebApp.DTOs.Club
{
    public record CreateClubDto(
        string Name,
        int LeaguePoints,
        int MatchesPlayed,
        int Wins,
        int Losses,
        int Drawns,
        int Goals,
        int GoalsConceded,
        int CleanSheets,
        int YearFounded,
        int StadiumId);
}
