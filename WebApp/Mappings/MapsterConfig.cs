﻿using Mapster;
using WebApp.DTOs.Club;
using WebApp.DTOs.Player;
using WebApp.Models;

namespace WebApp.Mappings
{
    public static class MapsterConfig
    {
        public static void Configure()
        {
            // Configure Club to ClubResponseDto
            TypeAdapterConfig<Club, ClubResponse>.NewConfig()
                .Map(dest => dest.Players, src => src.Players.Adapt<List<PlayerResponse>>());

            // Configure Player to PlayerResponseDto
            TypeAdapterConfig<Player, PlayerResponse>.NewConfig()
                .Map(dest => dest.Club, src => src.Club.Name);
        }
    }
}