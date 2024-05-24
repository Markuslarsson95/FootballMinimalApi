using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Exceptions.Errors;
using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Player;

namespace Application.Commands.Players
{
    public static class UpdatePlayer
    {
        public record Command(int Id, UpdatePlayerDto Dto) : ICommand<Result<PlayerResponseDto>>;

        public class Handler : IRequestHandler<Command, Result<PlayerResponseDto>>
        {
            private readonly IPlayerRepository _playerRepository;

            public Handler(IPlayerRepository playerRepository)
            {
                _playerRepository = playerRepository;
            }

            public async Task<Result<PlayerResponseDto>> Handle(Command request, CancellationToken cancellationToken)
            {
                var player = await _playerRepository.GetById(request.Id);
                if (player is null)
                    return Result<PlayerResponseDto>.Failure(PlayerErrors.NotFound(request.Id));

                player.FirstName = request.Dto.FirstName;
                player.LastName = request.Dto.LastName;
                player.ClubId = request.Dto.ClubId;
                player.Position = request.Dto.Position;
                player.Nationality = request.Dto.Nationality;
                player.DateOfBirth = request.Dto.DateOfBirth;
                player.KitNumber = request.Dto.KitNumber;
                player.Height = request.Dto.Height;

                await _playerRepository.Update(player);

                return Result<PlayerResponseDto>.Success(player.Adapt<PlayerResponseDto>());
            }
        }
    }
}
