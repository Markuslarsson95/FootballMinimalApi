using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Exceptions.Errors;
using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Player;

namespace Application.Queries.Players
{
    public static class GetPlayerById
    {
        public record Query(int Id) : ICommand<Result<PlayerResponseDto>>;

        public class Handler : IRequestHandler<Query, Result<PlayerResponseDto>>
        {
            private readonly IPlayerRepository _playerRepository;

            public Handler(IPlayerRepository playerRepository)
            {
                _playerRepository = playerRepository;
            }

            public async Task<Result<PlayerResponseDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var player = await _playerRepository.GetById(request.Id);
                if (player is null)
                    return Result<PlayerResponseDto>.Failure(PlayerErrors.NotFound(request.Id));

                return Result<PlayerResponseDto>.Success(player.Adapt<PlayerResponseDto>());
            }
        }
    }
}
