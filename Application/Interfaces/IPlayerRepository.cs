using WebApp.Models;

namespace Application.Interfaces
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetAllPlayers();
        Task<Player> GetPlayerById(int playerId);
        Task<Player> AddPlayer(Player player);
        Task<Player> UpdatePlayer(int playerId, Player player);
        Task<Player> RemovePlayer(int playerId);
    }
}
