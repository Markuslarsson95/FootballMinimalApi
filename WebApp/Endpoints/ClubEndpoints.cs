using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebApp.DTOs.Club;

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

            static async Task<IResult> GetAllClubs(AppDb db, int page = 1, int pageSize = 10)
            {
                try
                {
                    var totalClubsCount = await db.Clubs.CountAsync();
                    var totalPages = (int)Math.Ceiling((double)totalClubsCount / pageSize);

                    if (page < 1 || page > totalPages)
                    {
                        return TypedResults.BadRequest($"Invalid page number. Page number should be between 1 and {totalPages}.");
                    }

                    var clubs = await db.Clubs
                        .OrderBy(x => x.Name)
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .Select(x => new GetClubsDto(
                            x.Id,
                            x.Name,
                            x.LeaguePoints,
                            x.Players)
                        ).ToListAsync();

                    var response = new
                    {
                        TotalPages = totalPages,
                        Clubs = clubs
                    };

                    return TypedResults.Ok(response);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving clubs: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

            static async Task<IResult> GetClubById(int id, AppDb db)
            {
                return await db.Clubs
                    .Where(x => x.Id == id)
                    .Select(c => new GetClubsDto(
                        c.Id,
                        c.Name,
                        c.LeaguePoints,
                        c.Players)
                    ).FirstOrDefaultAsync()
                is GetClubsDto clubDto
                ? TypedResults.Ok(clubDto)
                : TypedResults.BadRequest();
            }

            static async Task<IResult> CreateClub(CreateClubDto clubDto, AppDb db)
            {
                var club = new Club
                {
                    Name = clubDto.Name,
                    LeaguePoints = clubDto.LeaguePoints,
                };
                db.Clubs.Add(club);
                await db.SaveChangesAsync();

                clubDto = new CreateClubDto(club.Name, club.LeaguePoints);

                return TypedResults.Created($"/clubs/{club.Id}", clubDto);
            }

            static async Task<IResult> UpdateClub(int id, UpdateClubDto clubDto, AppDb db)
            {
                var club = await db.Clubs
                   .Where(c => c.Id == id)
                   .FirstOrDefaultAsync();

                if (club is null)
                    return Results.NotFound();

                club.Name = clubDto.Name;
                club.LeaguePoints = clubDto.LeaguePoints;

                await db.SaveChangesAsync();

                return Results.NoContent();
            }

            static async Task<IResult> RemoveClub(int id, AppDb db)
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
                return Results.NotFound();
            }
        }
    }
}
