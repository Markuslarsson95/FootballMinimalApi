using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Endpoints
{
    public static class PlayerEndpoints
    {
        public static void RegisterPlayerEndpoints(this WebApplication app)
        {
            static async Task<IResult> GetAllPlayers(AppDb db)
            {
                return TypedResults.Ok(await db.Players.ToListAsync());
            }

            static async Task<Results<Ok<Player>, NotFound>> GetPlayerById(int id, AppDb db) =>
                await db.Players.FindAsync(id)
                is Player player
                ? TypedResults.Ok(player)
                : TypedResults.NotFound();

            app.MapGet("/players", GetAllPlayers);

            app.MapGet("/players/{id}", GetPlayerById);

            app.MapPost("/players", async (Player player, AppDb db) =>
            {
                var club = await db.Clubs.FindAsync(player.ClubId);
                player.Club = club;
                db.Players.Add(player);
                await db.SaveChangesAsync();
                return TypedResults.Created($"/players/{player.Id}", player);
            });

            app.MapDelete("/players/{id}", async (int id, AppDb db) =>
            {
                if (await db.Players.FindAsync(id) is Player player)
                {
                    db.Players.Remove(player);
                    await db.SaveChangesAsync();
                    return Results.NoContent();
                }
                return Results.NotFound();
            });
        }
    }
}
