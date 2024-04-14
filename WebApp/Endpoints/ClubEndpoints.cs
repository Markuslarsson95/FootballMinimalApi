using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebApp.DTOs.Club;
using WebApp.Models;

namespace WebApp.Endpoints
{
    public static class ClubEndpoints
    {
        public static void RegisterClubEndpoints(this WebApplication app)
        {
            var clubs = app.MapGroup("/clubs");

            clubs.MapGet("/", GetAllClubs);
            clubs.MapGet("/{id}", GetClubById);
            clubs.MapPost("/", CreateClub);
            clubs.MapPut("/{id}", UpdateClub);
            clubs.MapDelete("/{id}", RemoveClub);

            static async Task<IResult> GetAllClubs(FootballDbContext db)
            {
                try
                {
                    var clubs = await db.Clubs
                        .Include(x => x.Stadium)
                        .Include(x => x.Players)
                        .ToListAsync();

                    var clubDto = clubs.Adapt<List<ClubResponseDto>>();

                    return TypedResults.Ok(clubDto);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving clubs: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

            static async Task<IResult> GetClubById(int id, FootballDbContext db)
            {
                try
                {
                    var club = await db.Clubs
                    .Where(x => x.Id == id)
                    .Include(x => x.Stadium)
                    .Include(x => x.Players)
                    .FirstOrDefaultAsync();

                    if (club == null)
                        return TypedResults.NotFound($"No Club found with id {id}");
                    var clubDtoResponse = club.Adapt<ClubResponseDto>();

                    return clubDtoResponse
                    is ClubResponseDto clubDto
                    ? TypedResults.Ok(clubDtoResponse)
                    : TypedResults.BadRequest();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving clubs: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }

            }

            static async Task<IResult> CreateClub(CreateClubDto createClubDto, FootballDbContext db)
            {
                try
                {
                    var club = new Club
                    {
                        Name = createClubDto.Name,
                        LeaguePoints = createClubDto.LeaguePoints,
                        MatchesPlayed = createClubDto.MatchesPlayed,
                        Wins = createClubDto.Wins,
                        Losses = createClubDto.Losses,
                        Drawns = createClubDto.Drawns,
                        Goals = createClubDto.Goals,
                        GoalsConceded = createClubDto.GoalsConceded,
                        CleanSheets = createClubDto.CleanSheets,
                        YearFounded = createClubDto.YearFounded
                    };

                    db.Clubs.Add(club);
                    await db.SaveChangesAsync();

                    return TypedResults.Created($"/clubs/{club.Id}", club.Adapt<ClubResponseDto>());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving clubs: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }

            }

            static async Task<IResult> UpdateClub(int id, UpdateClubDto updateClubDto, FootballDbContext db)
            {
                try
                {
                    var club = await db.Clubs
                   .Where(c => c.Id == id)
                   .FirstOrDefaultAsync();

                    if (club is null)
                        return Results.NotFound($"No Club found with id {id}");

                    var clubUpdate = updateClubDto.Adapt(club);

                    await db.SaveChangesAsync();

                    return Results.NoContent();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving clubs: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

            static async Task<IResult> RemoveClub(int id, FootballDbContext db)
            {
                try
                {
                    var club = await db.Clubs.FindAsync(id);
                    if (club is Club)
                    {
                        if (!club.Players.IsNullOrEmpty())
                            return Results.BadRequest("Remove player(s) first");
                        db.Clubs.Remove(club);
                        await db.SaveChangesAsync();
                        return Results.NoContent();
                    }
                    return Results.NotFound($"No Club found with id {id}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving clubs: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
        }
    }
}
