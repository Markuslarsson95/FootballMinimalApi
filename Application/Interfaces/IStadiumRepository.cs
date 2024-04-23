using WebApp.Models;

namespace Application.Interfaces
{
    public interface IStadiumRepository
    {
        Task<IEnumerable<Stadium>> GetAll();
        Task<Stadium?> GetById(int id);
        Stadium Add(Stadium stadium);
        Stadium Update(Stadium stadium);
        void Remove(Stadium stadium);
    }
}
