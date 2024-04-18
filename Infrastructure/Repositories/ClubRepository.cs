using Application.Interfaces;
using WebApp.Models;

namespace Infrastructure.Repositories
{
    public class ClubRepository : IClubRepository
    {
        public Task<Club> AddClub(Club club)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Club> GetAllClubs()
        {
            throw new NotImplementedException();
        }

        public Task<Club> GetClubById(int clubId)
        {
            throw new NotImplementedException();
        }

        public Task<Club> RemoveClub(int clubId)
        {
            throw new NotImplementedException();
        }

        public Task<Club> UpdateClub(int clubId, Club club)
        {
            throw new NotImplementedException();
        }
    }
}
