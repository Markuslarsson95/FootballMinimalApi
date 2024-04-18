namespace WebApp.DTOs.Club
{
    public record UpdateClubDto(
        int? StadiumId,
        string Name,
        int LeaguePoints,
        int MatchesPlayed,
        int Wins,
        int Losses,
        int Draws,
        int Goals,
        int GoalsConceded,
        int CleanSheets,
        int YearFounded);
}
