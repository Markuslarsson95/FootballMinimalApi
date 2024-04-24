using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApp;
using WebApp.Models;

namespace Infrastructure.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly FootballDbContext _context;

        public PlayerRepository(FootballDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Player>> GetAll()
        {
            return await _context.Players
                .Include(x => x.Club)
                .ToListAsync();
        }

        public async Task<Player?> GetById(int id)
        {
            return await _context.Players
                .Include(x => x.Club)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Player> Add(Player player)
        {
            var newPlayer = _context.Players.Add(player).Entity;
            await _context.SaveChangesAsync();
            return newPlayer;
        }

        public async Task<Player> Update(Player player)
        {
            var updatedPlayer = _context.Players.Update(player).Entity;
            await _context.SaveChangesAsync();
            return updatedPlayer;
        }

        public void Remove(Player player)
        {
            _context.Players.Remove(player);
            _context.SaveChanges();
        }
    }
}
