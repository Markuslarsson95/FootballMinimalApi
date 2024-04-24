using Application.Interfaces;
using MediatR;
using System.Net;
using WebApp.Exceptions;

namespace Application.Commands.Clubs
{
    public static class DeleteClub
    {
        public record Command(int id) : IRequest;

        public class Handler : IRequestHandler<Command>
        {
            private readonly IClubRepository _clubRepository;

            public Handler(IClubRepository clubRepository)
            {
                _clubRepository = clubRepository;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var club = await _clubRepository.GetById(request.id);
                if (club is null)
                    throw new CommandQueryMessageException($"Can't find Club with id {request.id}", (int)HttpStatusCode.NotFound);

                _clubRepository.Remove(club);
            }
        }
    }
}
