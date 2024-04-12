using Mapster;
using WebApp.DTOs.Club;
using WebApp.DTOs.Player;
using WebApp.Models;

namespace WebApp.Mappings
{
    public static class MapsterConfig
    {
        public static void Configure()
        {
            // Configure Club to ClubDto
            TypeAdapterConfig<Club, ClubResponse>.NewConfig()
                .Map(dest => dest.Players, src => src.Players.Adapt<List<PlayerResponse>>());

            // Configure Player to PlayerDto
            //TypeAdapterConfig<Player, CreatePlayerDto>.NewConfig()
            //    .Map(dest => dest.Club, src => src.Club.Adapt<CreateClubDto>());
        }
    }
}
