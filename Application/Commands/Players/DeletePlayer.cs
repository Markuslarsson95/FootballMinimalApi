using Application.Abstractions.Messaging;
using Application.Interfaces;
using MediatR;
using System.Net;
using WebApp.Exceptions;

namespace Application.Commands.Players
{
    public static class DeletePlayer
    {
        public record Command(int id) : ICommand;

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

                _playerRepository.Remove(player);
            }
        }
    }
}
