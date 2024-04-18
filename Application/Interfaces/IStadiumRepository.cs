using WebApp.Models;

namespace Application.Interfaces
{
    public interface IStadiumRepository
    {
        Task<IEnumerable<Stadium>> GetAllStadiums();
        Task<Stadium> GetStadiumById(int stadiumId);
        Stadium AddStadium(Stadium stadium);
        Task<Stadium> UpdateStadium(int stadiumId);
        Task<Stadium> RemoveStadium(int stadiumId);
        void Save();
    }
}
