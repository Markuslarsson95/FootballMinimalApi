using Application.Commands.Clubs;
using Application.Queries.Clubs;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApp.DTOs.Club;
using WebApp.Extensions;

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
            var result = await sender.Send(new GetClubs.Query());
            return result.IsSuccess ? TypedResults.Ok(result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> GetClubById(int id, ISender sender)
        {
            var result = await sender.Send(new GetClubById.Query(id));
            return result.IsSuccess ? TypedResults.Ok(result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> CreateClub([FromBody] CreateClubDto dto, ISender sender)
        {
            var result = await sender.Send(new AddClub.Command(dto));
            return result.IsSuccess ? TypedResults.Created($"/clubs/{result.Value}", result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> UpdateClub(int id, [FromBody] UpdateClubDto updateClubDto, ISender sender)
        {
            var result = await sender.Send(new UpdateClub.Command(id, updateClubDto));
            return result.IsSuccess ? TypedResults.Ok(result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> RemoveClub(int id, ISender sender)
        {
            var result = await sender.Send(new DeleteClub.Command(id));
            return result.IsSuccess ? TypedResults.NoContent() : result.ToProblemDetails();
        }
    }
}

