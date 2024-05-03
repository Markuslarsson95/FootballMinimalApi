using Application.Abstractions;
using Application.Commands.Clubs;
using Application.Interfaces;
using MediatR;

namespace Application.Queries.Clubs
{
    public static class GetClubById
    {
        public record Query(int Id) : IRequest<Result>;

        public class Handler : IRequestHandler<Query, Result>
        {
            private readonly IClubRepository _clubRepository;

            public Handler(IClubRepository clubRepository)
            {
                _clubRepository = clubRepository;
            }

            public async Task<Result> Handle(Query request, CancellationToken cancellationToken)
            {
                var club = await _clubRepository.GetById(request.Id);
                if (club is null)
                    return Result.Failure(ClubErrors.NotFound(request.Id));

                return Result.Success();
            }
        }
    }
}
