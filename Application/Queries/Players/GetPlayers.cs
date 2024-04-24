using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Player;

namespace Application.Queries.Players
{
    public static class GetPlayers
    {
        public record Query() : IRequest<IEnumerable<PlayerResponseDto>>;

        public class Handler : IRequestHandler<Query, IEnumerable<PlayerResponseDto>>
        {
            private readonly IPlayerRepository _playerRepository;

            public Handler(IPlayerRepository playerRepository)
            {
                _playerRepository = playerRepository;
            }

            public async Task<IEnumerable<PlayerResponseDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var players = await _playerRepository.GetAll();

                return players.Adapt<IEnumerable<PlayerResponseDto>>();
            }
        }
    }
}
