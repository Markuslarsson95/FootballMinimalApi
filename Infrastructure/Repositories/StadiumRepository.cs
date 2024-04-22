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
        public Stadium Add(Stadium stadium)
        {
            return _context.Stadiums.Add(stadium).Entity;
        }

        public async Task<IEnumerable<Stadium>> GetAll()
        {
            return await _context.Stadiums.Include(x => x.Club).ToListAsync();
        }

        public async Task<Stadium> GetById(int id)
        {
            return await _context.Stadiums.Include(x => x.Club).FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task Remove(Stadium stadium)
        {
            throw new NotImplementedException();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(Stadium stadium)
        {
            _context.Stadiums.Update(stadium);
            await _context.SaveChangesAsync();
        }
    }
}
