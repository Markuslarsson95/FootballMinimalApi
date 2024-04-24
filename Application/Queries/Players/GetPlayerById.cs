using Application.Interfaces;
using Mapster;
using MediatR;
using System.Net;
using WebApp.DTOs.Player;
using WebApp.Exceptions;

namespace Application.Queries.Players
{
    public static class GetPlayerById
    {
        public record Query(int Id) : IRequest<PlayerResponseDto>;

        public class Handler : IRequestHandler<Query, PlayerResponseDto>
        {
            private readonly IPlayerRepository _playerRepository;

            public Handler(IPlayerRepository playerRepository)
            {
                _playerRepository = playerRepository;
            }

            public async Task<PlayerResponseDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var player = await _playerRepository.GetById(request.Id);
                if (player is null)
                    throw new CommandQueryMessageException($"Can't find Player with id {request.Id}.", (int)HttpStatusCode.NotFound);

                return player.Adapt<PlayerResponseDto>();
            }
        }
    }
}
