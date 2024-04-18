using Application.Interfaces;
using WebApp.Models;

namespace Infrastructure.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public Task<Player> AddPlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            throw new NotImplementedException();
        }

        public Task<Player> GetPlayerById(int playerId)
        {
            throw new NotImplementedException();
        }

        public Task<Player> RemovePlayer(int playerId)
        {
            throw new NotImplementedException();
        }

        public Task<Player> UpdatePlayer(int playerId, Player player)
        {
            throw new NotImplementedException();
        }
    }
}
