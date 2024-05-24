using Application.Commands.Players;
using Application.Queries.Players;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApp.DTOs.Player;
using WebApp.Extensions;

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
            var result = await sender.Send(new GetPlayers.Query());
            return result.IsSuccess ? TypedResults.Ok(result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> GetPlayerById(int id, ISender sender)
        {
            var result = await sender.Send(new GetPlayerById.Query(id));
            return result.IsSuccess ? TypedResults.Ok(result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> CreatePayer([FromBody] CreatePlayerDto dto, ISender sender)
        {
            var result = await sender.Send(new AddPlayer.Command(dto));
            return result.IsSuccess ? TypedResults.Created($"/players/{result.Value}", result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> UpdatePlayer(int id, [FromBody] UpdatePlayerDto dto, ISender sender)
        {
            var result = await sender.Send(new UpdatePlayer.Command(id, dto));
            return result.IsSuccess ? TypedResults.Ok(result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> RemovePlayer(int id, ISender sender)
        {
            var result = await sender.Send(new DeletePlayer.Command(id));
            return result.IsSuccess ?  TypedResults.NoContent() : result.ToProblemDetails();
        }
    }
}
