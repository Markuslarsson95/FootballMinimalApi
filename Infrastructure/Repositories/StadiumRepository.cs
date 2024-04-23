using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApp;
using WebApp.Models;

namespace Infrastructure.Repositories
{
    public class StadiumRepository : IStadiumRepository
    {
        private readonly FootballDbContext _context;

        public StadiumRepository(FootballDbContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Stadium>> GetAll()
        {
            return await _context.Stadiums
                .Include(x => x.Club)
                .ToListAsync();
        }

        public async Task<Stadium?> GetById(int id)
        {
            return await _context.Stadiums
                .Include(x => x.Club)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public Stadium Add(Stadium stadium)
        {
            var newStadium = _context.Stadiums.Add(stadium).Entity;
            _context.SaveChanges();
            return newStadium;
        }

        public Stadium Update(Stadium stadium)
        {
            var updatedStadium = _context.Stadiums.Update(stadium).Entity;
            _context.SaveChanges();
            return updatedStadium;
        }

        public void Remove(Stadium stadium)
        {
            _context.Stadiums.Remove(stadium);
            _context.SaveChanges();
        }
    }
}
