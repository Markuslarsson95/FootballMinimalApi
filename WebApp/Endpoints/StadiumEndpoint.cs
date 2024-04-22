using Application.Commands.Stadiums;
using Application.Queries.Stadium;
using Carter;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.DTOs.Stadium;
using WebApp.Models;

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
            var stadiums = await sender.Send(new GetStadiumsQuery());
            return TypedResults.Ok(stadiums.Adapt<List<StadiumResponseDto>>());
        }

        public static async Task<Results<Ok<StadiumResponseDto>, NotFound, StatusCodeHttpResult>> GetStadiumById(int id, ISender sender)
        {
            var stadium = await sender.Send(new GetStadiumByIdQuery.Query(id));
            return TypedResults.Ok(stadium);
        }

        public static async Task<IResult> CreateStadium([FromBody] CreateStadiumDto dto, ISender sender)
        {
            var stadium = await sender.Send(new AddStdiumCommand.Command(dto));
            return TypedResults.Created($"/stadiums/{stadium}", stadium);
        }

        public static async Task<IResult> UpdateStadium(int id, [FromBody] UpdateStadiumDto dto, ISender sender)
        {
            await sender.Send(new UpdateStadiumCommand.Command(id, dto));
            return Results.NoContent();
        }

        public static async Task<IResult> RemoveStadium(int id, FootballDbContext db)
        {

            var stadium = await db.Stadiums
                .Include(x => x.Club)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (stadium is Stadium)
            {
                //if (!stadium.Club.null
                //    return Results.BadRequest("Remove player(s) first");
                db.Stadiums.Remove(stadium);
                await db.SaveChangesAsync();
                return Results.NoContent();
            }
            return Results.NotFound($"No Stadium found with id {id}");
        }
    }
}

