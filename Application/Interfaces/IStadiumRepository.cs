using WebApp.Models;

namespace Application.Interfaces
{
    public interface IStadiumRepository
    {
        Task<IEnumerable<Stadium>> GetAll();
        Task<Stadium?> GetById(int id);
        Task<Stadium> Add(Stadium stadium);
        Task<Stadium> Update(Stadium stadium);
        void Remove(Stadium stadium);
    }
}
