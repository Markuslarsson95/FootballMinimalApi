using Application.Interfaces;
using MediatR;
using System.Net;
using WebApp.Exceptions;

namespace Application.Commands.Stadiums
{
    public static class DeleteStadium
    {
        public record Command(int id) : IRequest<string>;

        public class Handler : IRequestHandler<Command, string>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }

            public async Task<string> Handle(Command request, CancellationToken cancellationToken)
            {
                var stadium = await _stadiumRepository.GetById(request.id);
                if (stadium is null)
                    throw new CommandQueryMessageException($"Can't find stadium with id {request.id}", (int)HttpStatusCode.NotFound);

                _stadiumRepository.Remove(stadium);

                return $"Stadium with id {request.id} removed";
            }
        }
    }
}
