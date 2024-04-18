using Application.Interfaces;
using Application.Queries.Stadium;
using Mapster;
using MediatR;
using WebApp.DTOs.Stadium;

namespace Application.Handlers.Stadium
{
    public record GetStadiumsHandler : IRequestHandler<GetStadiumsQuery, IEnumerable<StadiumResponseDto>>
    {
        private readonly IStadiumRepository _stadiumRepository;

        public GetStadiumsHandler(IStadiumRepository stadiumRepository)
        {
            _stadiumRepository = stadiumRepository;
        }

        public async Task<IEnumerable<StadiumResponseDto>> Handle(GetStadiumsQuery request, CancellationToken cancellationToken)
        {
            var response = await _stadiumRepository.GetAllStadiums();

            return response.Adapt<IEnumerable<StadiumResponseDto>>();
        }
    }
}
