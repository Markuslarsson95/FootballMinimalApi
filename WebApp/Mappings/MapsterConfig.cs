using Mapster;
using WebApp.DTOs.Club;
using WebApp.DTOs.Player;
using WebApp.DTOs.Stadium;
using WebApp.Models;

namespace WebApp.Mappings
{
    public static class MapsterConfig
    {
        public static void Configure()
        {
            // Configure Club to ClubResponseDto
            TypeAdapterConfig<Club, ClubResponseDto>.NewConfig()
                .Map(dest => dest.Stadium, src => src.Stadium.Name)
                .Map(dest => dest.Players, src => src.Players.Adapt<List<PlayerResponseDto>>());

            // Configure Player to PlayerResponseDto
            TypeAdapterConfig<Player, PlayerResponseDto>.NewConfig()
                .Map(dest => dest.Club, src => src.Club.Name);

            // Configure Stadium to StadiumResponseDto
            TypeAdapterConfig<Stadium, StadiumResponseDto>.NewConfig()
                .Map(dest => dest.Club, src => src.Club.Name);
        }
    }
}
