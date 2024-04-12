using WebApp.DTOs.Player;

namespace WebApp.DTOs.Club
{
    public record ClubResponse(int Id, string Name, int LeaguePoints, List<PlayerResponse> Players);
}
