using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Club;

namespace Application.Queries.Clubs
{
    public static class GetClubs
    {
        public record Query() : IRequest<IEnumerable<ClubResponseDto>>;

        public class Handler : IRequestHandler<Query, IEnumerable<ClubResponseDto>>
        {
            private readonly IClubRepository _clubRepository;

            public Handler(IClubRepository clubRepository)
            {
                _clubRepository = clubRepository;
            }

            public async Task<IEnumerable<ClubResponseDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var clubs = await _clubRepository.GetAll();

                return clubs.Adapt<IEnumerable<ClubResponseDto>>();
            }
        }
    }
}
