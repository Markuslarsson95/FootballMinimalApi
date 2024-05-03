using Application.Abstractions.Messaging;
using Application.Interfaces;
using MediatR;
using WebApp.DTOs.Player;
using WebApp.Models;

namespace Application.Commands.Players
{
    public static class AddPlayer
    {
        public record Command(CreatePlayerDto dto) : ICommand<int>;

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IPlayerRepository _playerRepository;

            public Handler(IPlayerRepository playerRepository)
            {
                _playerRepository = playerRepository;
            }

            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var player = new Player
                {
                    FirstName = request.dto.FirstName,
                    LastName = request.dto.LastName,
                    ClubId = request.dto.ClubId,
                    Position = request.dto.Position,
                    Nationality = request.dto.Nationality,
                    DateOfBirth = request.dto.DateOfBirth,
                    KitNumber = request.dto.KitNumber,
                    Height = request.dto.Height,
                };

                await _playerRepository.Add(player);
                return player.Id;
            }
        }
    }
}
