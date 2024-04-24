using Application.Interfaces;
using MediatR;
using System.Net;
using WebApp.DTOs.Player;
using WebApp.Exceptions;

namespace Application.Commands.Players
{
    public static class UpdatePlayer
    {
        public record Command(int id, UpdatePlayerDto dto) : IRequest;

        public class Handler : IRequestHandler<Command>
        {
            private readonly IPlayerRepository _playerRepository;

            public Handler(IPlayerRepository playerRepository)
            {
                _playerRepository = playerRepository;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var player = await _playerRepository.GetById(request.id);
                if (player is null)
                    throw new CommandQueryMessageException($"Can't find Player with id {request.id}", (int)HttpStatusCode.NotFound);

                player.FirstName = request.dto.FirstName;
                player.LastName = request.dto.LastnName;
                player.ClubId = request.dto.ClubId;
                player.Position = request.dto.Position;
                player.Nationality = request.dto.Nationality;
                player.DateOfBirth = request.dto.DateOfBirth;
                player.KitNumber = request.dto.KitNumber;
                player.Height = request.dto.Height;

                await _playerRepository.Update(player);
            }
        }
    }
}
