using WebApp.Models;

namespace Application.Interfaces
{
    public interface IStadiumRepository
    {
        Task<IEnumerable<Stadium>> GetAll();
        Task<Stadium> GetById(int id);
        Stadium Add(Stadium stadium);
        Task Update(Stadium stadium);
        Task Remove(Stadium stadium);
        Task Save();
    }
}
