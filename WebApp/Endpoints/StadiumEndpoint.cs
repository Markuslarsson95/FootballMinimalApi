using Application.Commands.Stadiums;
using Application.Queries.Stadium;
using Carter;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApp.DTOs.Stadium;

namespace WebApp.Endpoints
{
    public class StadiumEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var clubs = app.MapGroup("/stadiums");

            clubs.MapGet("/", GetAllStadiums);
            clubs.MapGet("/{id}", GetStadiumById);
            clubs.MapPost("/", CreateStadium);
            clubs.MapPut("/{id}", UpdateStadium);
            clubs.MapDelete("/{id}", RemoveStadium);
        }
        public static async Task<IResult> GetAllStadiums(ISender sender)
        {
            var stadiums = await sender.Send(new GetStadiums.Query());
            return TypedResults.Ok(stadiums.Adapt<List<StadiumResponseDto>>());
        }

        public static async Task<IResult> GetStadiumById(int id, ISender sender)
        {
            var stadium = await sender.Send(new GetStadiumById.Query(id));
            return TypedResults.Ok(stadium);
        }

        public static async Task<IResult> CreateStadium([FromBody] CreateStadiumDto dto, ISender sender)
        {
            var stadium = await sender.Send(new AddStdium.Command(dto));
            return TypedResults.Created($"/stadiums/{stadium}", stadium);
        }

        public static async Task<IResult> UpdateStadium(int id, [FromBody] UpdateStadiumDto dto, ISender sender)
        {
            await sender.Send(new UpdateStadium.Command(id, dto));
            return Results.NoContent();
        }

        public static async Task<IResult> RemoveStadium(int id, ISender sender)
        {
            await sender.Send(new DeleteStadium.Command(id));
            return Results.NoContent();
        }
    }
}

