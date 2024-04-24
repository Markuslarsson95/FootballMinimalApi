using WebApp.Models;

namespace Application.Interfaces
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();
        Task<Club?> GetById(int id);
        Task<Club> Add(Club club);
        Task<Club> Update(Club club);
        void Remove(Club club);
    }
}
