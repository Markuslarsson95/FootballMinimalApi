using WebApp.DTOs.Player;

namespace WebApp.DTOs.Club
{
    public record ClubResponseDto(int Id,
        string Name,
        string Stadium,
        int LeaguePoints,
        int MatchesPlayed,
        int Wins,
        int Losses,
        int Draws,
        int Goals,
        int GoalsConceded,
        int CleanSheets,
        int YearFounded,
        List<PlayerResponseDto> Players);
}
