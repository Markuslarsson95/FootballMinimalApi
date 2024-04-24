using Application.Commands.Players;
using Application.Queries.Players;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApp.DTOs.Player;

namespace WebApp.Endpoints
{
    public class PlayerEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var players = app.MapGroup("/players");

            players.MapGet("/", GetAllPlayers);
            players.MapGet("/{id}", GetPlayerById);
            players.MapPost("/", CreatePayer);
            players.MapPut("/{id}", UpdatePlayer);
            players.MapDelete("/{id}", RemovePlayer);
        }

        public static async Task<IResult> GetAllPlayers(ISender sender)
        {
            var players = await sender.Send(new GetPlayers.Query());
            return TypedResults.Ok(players);
        }

        public static async Task<IResult> GetPlayerById(int id, ISender sender)
        {
            var player = await sender.Send(new GetPlayerById.Query(id));
            return TypedResults.Ok(player);
        }

        public static async Task<IResult> CreatePayer([FromBody] CreatePlayerDto dto, ISender sender)
        {
            var newPlayer = await sender.Send(new AddPlayer.Command(dto));
            return TypedResults.Created($"/players/{newPlayer}", newPlayer);
        }

        public static async Task<IResult> UpdatePlayer(int id, [FromBody] UpdatePlayerDto dto, ISender sender)
        {
            await sender.Send(new UpdatePlayer.Command(id, dto));
            return TypedResults.NoContent();
        }

        public static async Task<IResult> RemovePlayer(int id, ISender sender)
        {
            await sender.Send(new DeletePlayer.Command(id));
            return TypedResults.NoContent();
        }
    }
}
