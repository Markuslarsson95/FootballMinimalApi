using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Interfaces;
using MediatR;
using WebApp.DTOs.Player;
using WebApp.Models;

namespace Application.Commands.Players
{
    public static class AddPlayer
    {
        public record Command(CreatePlayerDto Dto) : ICommand<Result<int>>;

        public class Handler : IRequestHandler<Command, Result<int>>
        {
            private readonly IPlayerRepository _playerRepository;

            public Handler(IPlayerRepository playerRepository)
            {
                _playerRepository = playerRepository;
            }

            public async Task<Result<int>> Handle(Command request, CancellationToken cancellationToken)
            {
                var player = new Player
                {
                    FirstName = request.Dto.FirstName,
                    LastName = request.Dto.LastName,
                    ClubId = request.Dto.ClubId,
                    Position = request.Dto.Position,
                    Nationality = request.Dto.Nationality,
                    DateOfBirth = request.Dto.DateOfBirth,
                    KitNumber = request.Dto.KitNumber,
                    Height = request.Dto.Height,
                };

                await _playerRepository.Add(player);

                return Result<int>.Success(player.Id);
            }
        }
    }
}
