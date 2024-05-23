using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApp;
using WebApp.Models;

namespace Infrastructure.Repositories
{
    public class ClubRepository : IClubRepository
    {
        private readonly FootballDbContext _context;

        public ClubRepository(FootballDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Club>> GetAll()
        {
            return await _context.Clubs
                .Include(x => x.Stadium)
                .Include(x => x.Players)
                .OrderByDescending(x => x.LeaguePoints)
                .ToListAsync();
        }

        public async Task<Club?> GetById(int id)
        {
            return await _context.Clubs
                .Include(x => x.Stadium)
                .Include(x => x.Players)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Club> Add(Club club)
        {
            var newClub = _context.Clubs.Add(club).Entity;
            await _context.SaveChangesAsync();
            return newClub;
        }

        public async Task<Club> Update(Club club)
        {
            var updatedClub = _context.Clubs.Update(club).Entity;
            await _context.SaveChangesAsync();
            return updatedClub;
        }

        public void Remove(Club club)
        {
            _context.Clubs.Remove(club);
            _context.SaveChanges();
        }
    }
}
