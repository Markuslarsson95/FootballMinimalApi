using Application.Interfaces;
using Mapster;
using MediatR;
using System.Net;
using WebApp.DTOs.Club;
using WebApp.Exceptions;

namespace Application.Queries.Clubs
{
    public static class GetClubById
    {
        public record Query(int Id) : IRequest<ClubResponseDto>;

        public class Handler : IRequestHandler<Query, ClubResponseDto>
        {
            private readonly IClubRepository _clubRepository;

            public Handler(IClubRepository clubRepository)
            {
                _clubRepository = clubRepository;
            }

            public async Task<ClubResponseDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var club = await _clubRepository.GetById(request.Id);
                if (club is null)
                    throw new CommandQueryMessageException($"Can't find Club with id {request.Id}.", (int)HttpStatusCode.NotFound);

                return club.Adapt<ClubResponseDto>();
            }
        }
    }
}
