using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Exceptions.Errors;
using Application.Interfaces;
using MediatR;

namespace Application.Commands.Players
{
    public static class DeletePlayer
    {
        public record Command(int Id) : ICommand<Result<bool>>;

        public class Handler : IRequestHandler<Command, Result<bool>>
        {
            private readonly IPlayerRepository _playerRepository;

            public Handler(IPlayerRepository playerRepository)
            {
                _playerRepository = playerRepository;
            }

            public async Task<Result<bool>> Handle(Command request, CancellationToken cancellationToken)
            {
                var player = await _playerRepository.GetById(request.Id);
                if (player is null)
                    return Result<bool>.Failure(PlayerErrors.NotFound(request.Id));

                _playerRepository.Remove(player);

                return Result<bool>.Success(true);
            }
        }
    }
}
