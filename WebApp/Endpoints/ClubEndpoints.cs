using Application.Commands.Clubs;
using Application.Queries.Clubs;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApp.DTOs.Club;

namespace WebApp.Endpoints
{
    public class ClubEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var clubs = app.MapGroup("/clubs");

            clubs.MapGet("/", GetAllClubs);
            clubs.MapGet("/{id}", GetClubById);
            clubs.MapPost("/", CreateClub);
            clubs.MapPut("/{id}", UpdateClub);
            clubs.MapDelete("/{id}", RemoveClub);
        }

        public static async Task<IResult> GetAllClubs(ISender sender)
        {
            var clubs = await sender.Send(new GetClubs.Query());
            return TypedResults.Ok(clubs);
        }

        public static async Task<IResult> GetClubById(int id, ISender sender)
        {
            var club = await sender.Send(new GetClubById.Query(id));
            return TypedResults.Ok(club);
        }

        public static async Task<IResult> CreateClub([FromBody] CreateClubDto dto, ISender sender)
        {
            var newClub = await sender.Send(new AddClub.Command(dto));
            return TypedResults.Created($"/stadiums/{newClub}", newClub);
        }

        public static async Task<IResult> UpdateClub(int id, [FromBody] UpdateClubDto updateClubDto, ISender sender)
        {
            await sender.Send(new UpdateClub.Command(id, updateClubDto));
            return TypedResults.NoContent();
        }

        public static async Task<IResult> RemoveClub(int id, ISender sender)
        {
            await sender.Send(new DeleteClub.Command(id));
            return TypedResults.NoContent();
        }
    }
}

