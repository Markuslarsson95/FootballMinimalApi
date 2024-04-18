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
        public Stadium AddStadium(Stadium stadium)
        {
            return _context.Stadiums.Add(stadium).Entity;
        }

        public async Task<IEnumerable<Stadium>> GetAllStadiums()
        {
            var stadiums = await _context.Stadiums.Include(x => x.Club).ToListAsync();

            return stadiums;
        }

        public async Task<Stadium> GetStadiumById(int stadiumId)
        {
            var stadium = await _context.Stadiums.Include(x => x.Club).FirstOrDefaultAsync(x => x.Id == stadiumId);
            return stadium;
        }

        public Task<Stadium> RemoveStadium(int stadiumId)
        {
            throw new NotImplementedException();
        }

        public async void Save()
        {
            await _context.SaveChangesAsync();
        }

        public Task<Stadium> UpdateStadium(int stadiumId)
        {
            throw new NotImplementedException();
        }
    }
}
