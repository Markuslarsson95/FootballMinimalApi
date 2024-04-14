using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebApp.DTOs.Club;
using WebApp.DTOs.Stadium;
using WebApp.Models;

namespace WebApp.Endpoints
{
    public static class StadiumEndpoint
    {
        public static void RegisterStadiumEndpoints(this WebApplication app)
        {
            var clubs = app.MapGroup("/stadiums");

            clubs.MapGet("/", GetAllStadiums);
            clubs.MapGet("/{id}", GetStadiumById);
            clubs.MapPost("/", CreateStadium);
            clubs.MapPut("/{id}", UpdateStadium);
            clubs.MapDelete("/{id}", RemoveStadium);

            static async Task<IResult> GetAllStadiums(FootballDbContext db)
            {
                try
                {
                    var stadiums = await db.Stadiums
                        .Include(x => x.Club)
                        .ToListAsync();

                    return TypedResults.Ok(stadiums.Adapt<List<StadiumResponseDto>>());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving stadiums: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

            static async Task<IResult> GetStadiumById(int id, FootballDbContext db)
            {
                try
                {
                    var stadium = await db.Stadiums
                    .Where(x => x.Id == id)
                    .Include(x => x.Club)
                    .FirstOrDefaultAsync();

                    if (stadium == null)
                        return TypedResults.NotFound($"No stadium found with id {id}");
                    var stadiumDtoResponse = stadium.Adapt<StadiumResponseDto>();

                    return stadiumDtoResponse
                    is StadiumResponseDto stadiumDto
                    ? TypedResults.Ok(stadiumDtoResponse)
                    : TypedResults.BadRequest();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving stadiums: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }

            }

            static async Task<IResult> CreateStadium(CreateStadiumDto createStadiumDto, FootballDbContext db)
            {
                try
                {
                    var stadium = createStadiumDto.Adapt<Stadium>();

                    db.Stadiums.Add(stadium);
                    await db.SaveChangesAsync();

                    return TypedResults.Created($"/stadiums/{stadium.Id}", stadium.Adapt<StadiumResponseDto>());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving stadiums: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }

            }

            static async Task<IResult> UpdateStadium(int id, UpdateStadiumDto updateStadiumDto, FootballDbContext db)
            {
                try
                {
                    var stadium = await db.Stadiums.FindAsync(id);

                    if (stadium is Stadium)
                    {
                        updateStadiumDto.Adapt(stadium);
                        await db.SaveChangesAsync();

                        return Results.NoContent();
                    }
                    return Results.NotFound($"No Stadium found with id {id}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving stadiums: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

            static async Task<IResult> RemoveStadium(int id, FootballDbContext db)
            {
                try
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
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while removing stadium: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

        }
    }
}
