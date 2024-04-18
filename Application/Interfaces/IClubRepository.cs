using WebApp.Models;

namespace Application.Interfaces
{
    public interface IClubRepository
    {
        IEnumerable<Club> GetAllClubs();
        Task<Club> GetClubById(int clubId);
        Task<Club> AddClub(Club club);
        Task<Club> UpdateClub(int clubId, Club club);
        Task<Club> RemoveClub(int clubId);
    }
}
