using Application.Commands.Stadiums;
using Application.Queries.Stadium;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApp.DTOs.Stadium;
using WebApp.Extensions;

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
            var result = await sender.Send(new GetStadiums.Query());
            return result.IsSuccess ? TypedResults.Ok(result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> GetStadiumById(int id, ISender sender)
        {
            var result = await sender.Send(new GetStadiumById.Query(id));
            return result.IsSuccess ? TypedResults.Ok(result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> CreateStadium([FromBody] CreateStadiumDto dto, ISender sender)
        {
            var result = await sender.Send(new AddStdium.Command(dto));
            return result.IsSuccess ? TypedResults.Created($"/stadiums/{result.Value}", result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> UpdateStadium(int id, [FromBody] UpdateStadiumDto dto, ISender sender)
        {
            var result = await sender.Send(new UpdateStadium.Command(id, dto));
            return result.IsSuccess ? TypedResults.Ok(result.Value) : result.ToProblemDetails();
        }

        public static async Task<IResult> RemoveStadium(int id, ISender sender)
        {
            var result = await sender.Send(new DeleteStadium.Command(id));
            return result.IsSuccess ? Results.NoContent() : result.ToProblemDetails();
        }
    }
}

