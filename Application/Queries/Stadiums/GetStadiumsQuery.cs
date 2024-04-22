using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Stadium;

namespace Application.Queries.Stadium
{
    public static class GetStadiumsQuery
    {
        public record Query() : IRequest<IEnumerable<StadiumResponseDto>>;

        public class Handler : IRequestHandler<Query, IEnumerable<StadiumResponseDto>>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }

            public async Task<IEnumerable<StadiumResponseDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var response = await _stadiumRepository.GetAll();

                return response.Adapt<IEnumerable<StadiumResponseDto>>();
            }
        }
    }
}
