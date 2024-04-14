using WebApp.DTOs.Player;

namespace WebApp.DTOs.Club
{
    public record ClubResponseDto(int Id, string Name, string Stadium, int LeaguePoints, List<PlayerResponseDto> Players);
}
