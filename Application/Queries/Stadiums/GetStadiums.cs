using Application.Abstractions;
using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Stadium;

namespace Application.Queries.Stadium
{
    public static class GetStadiums
    {
        public record Query() : IRequest<Result< IEnumerable<StadiumResponseDto>>>;

        public class Handler : IRequestHandler<Query, Result<IEnumerable<StadiumResponseDto>>>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }

            public async Task<Result<IEnumerable<StadiumResponseDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var stadiums = await _stadiumRepository.GetAll();

                return Result<IEnumerable<StadiumResponseDto>>.Success(stadiums.Adapt<IEnumerable<StadiumResponseDto>>());
            }
        }
    }
}
