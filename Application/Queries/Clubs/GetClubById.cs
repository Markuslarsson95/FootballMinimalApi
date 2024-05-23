using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Exceptions.Errors;
using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Club;

namespace Application.Queries.Clubs
{
    public static class GetClubById
    {
        public record Query(int Id) : ICommand<Result<ClubResponseDto>>;

        public class Handler : IRequestHandler<Query, Result<ClubResponseDto>>
        {
            private readonly IClubRepository _clubRepository;

            public Handler(IClubRepository clubRepository)
            {
                _clubRepository = clubRepository;
            }

            public async Task<Result<ClubResponseDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var club = await _clubRepository.GetById(request.Id);
                if (club is null)
                    return Result<ClubResponseDto>.Failure(ClubErrors.NotFound(request.Id));

                return Result<ClubResponseDto>.Success(club.Adapt<ClubResponseDto>());
            }
        }
    }
}
