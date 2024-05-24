using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Club;

namespace Application.Queries.Clubs
{
    public static class GetClubs
    {
        public record Query() : ICommand<Result<IEnumerable<ClubResponseDto>>>;

        public class Handler : IRequestHandler<Query, Result<IEnumerable<ClubResponseDto>>>
        {
            private readonly IClubRepository _clubRepository;

            public Handler(IClubRepository clubRepository)
            {
                _clubRepository = clubRepository;
            }

            public async Task<Result<IEnumerable<ClubResponseDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var clubs = await _clubRepository.GetAll();

                return Result<IEnumerable<ClubResponseDto>>.Success(clubs.Adapt<IEnumerable<ClubResponseDto>>());
            }
        }
    }
}
