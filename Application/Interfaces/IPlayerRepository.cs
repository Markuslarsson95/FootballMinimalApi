using WebApp.Models;

namespace Application.Interfaces
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAll();
        Task<Player?> GetById(int id);
        Task<Player> Add(Player player);
        Task<Player> Update(Player player);
        void Remove(Player player);
    }
}
