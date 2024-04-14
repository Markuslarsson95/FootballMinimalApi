using Mapster;
using Microsoft.EntityFrameworkCore;
using WebApp.DTOs.Player;
using WebApp.Models;

namespace WebApp.Endpoints
{
    public static class PlayerEndpoints
    {
        public static void RegisterPlayerEndpoints(this WebApplication app)
        {
            var players = app.MapGroup("/players");

            players.MapGet("/", GetAllPlayers);
            players.MapGet("/{id}", GetPlayerById);
            players.MapPost("/", CreatePayer);
            players.MapPut("/{id}", UpdatePlayer);
            players.MapDelete("/{id}", RemovePlayer);

            static async Task<IResult> GetAllPlayers(FootballDbContext db)
            {
                try
                {
                    var players = await db.Players
                        .Include(x => x.Club)
                        .ToListAsync();

                    var playerDto = players.Adapt<List<PlayerResponseDto>>();

                    return TypedResults.Ok(playerDto);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving players: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

            static async Task<IResult> GetPlayerById(int id, FootballDbContext db)
            {
                try
                {
                    var player = await db.Players
                    .Where(x => x.Id == id)
                    .Include(x => x.Club)
                    .FirstOrDefaultAsync();

                    if (player == null)
                        return TypedResults.NotFound($"No Player found with id {id}");
                    var playerDtoResponse = player.Adapt<PlayerResponseDto>();

                    return playerDtoResponse
                    is PlayerResponseDto playerDto
                    ? TypedResults.Ok(playerDtoResponse)
                    : TypedResults.BadRequest();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving players: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

            static async Task<IResult> CreatePayer(CreatePlayerDto createPlayerDto, FootballDbContext db)
            {
                try
                {
                    var player = new Player
                    {
                        FirstName = createPlayerDto.FirstName,
                        LastName = createPlayerDto.LastnName,
                        ClubId = createPlayerDto.ClubId,
                        Position = createPlayerDto.Position,
                        Nationality = createPlayerDto.Nationality,
                        DateOfBirth = createPlayerDto.DateOfBirth,
                        KitNumber = createPlayerDto.KitNumber,
                        Height = createPlayerDto.Height
                    };

                    db.Players.Add(player);
                    await db.SaveChangesAsync();

                    return TypedResults.Created($"/players/{player.Id}", player.Adapt<PlayerResponseDto>());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving players: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }

            }

            static async Task<IResult> UpdatePlayer(int id, UpdatePlayerDto updatePlayerDto, FootballDbContext db)
            {
                try
                {
                    var player = await db.Players
                   .Where(c => c.Id == id)
                   .FirstOrDefaultAsync();

                    if (player is null)
                        return Results.NotFound($"No Player found with id {id}");

                    var clubUpdate = updatePlayerDto.Adapt(player);

                    await db.SaveChangesAsync();

                    return Results.NoContent();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving players: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

            static async Task<IResult> RemovePlayer(int id, FootballDbContext db)
            {
                try
                {
                    var player = await db.Players.FindAsync(id);

                    if (player is null)
                        return Results.NotFound($"No Player found with id {id}");

                    db.Players.Remove(player);
                    await db.SaveChangesAsync();

                    return Results.NoContent();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving players: {ex.Message}");
                    return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);
                }
            }


        }
    }
}
