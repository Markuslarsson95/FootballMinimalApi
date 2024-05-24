using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Player;

namespace Application.Queries.Players
{
    public static class GetPlayers
    {
        public record Query() : ICommand<Result<IEnumerable<PlayerResponseDto>>>;

        public class Handler : IRequestHandler<Query, Result<IEnumerable<PlayerResponseDto>>>
        {
            private readonly IPlayerRepository _playerRepository;

            public Handler(IPlayerRepository playerRepository)
            {
                _playerRepository = playerRepository;
            }

            public async Task<Result<IEnumerable<PlayerResponseDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var players = await _playerRepository.GetAll();

                return Result<IEnumerable<PlayerResponseDto>>.Success(players.Adapt<IEnumerable<PlayerResponseDto>>());
            }
        }
    }
}
