using Application.Interfaces;
using Application.Queries.Stadium;
using Mapster;
using MediatR;
using System.Net;
using WebApp.DTOs.Stadium;
using WebApp.Exceptions;

namespace Application.Handlers.Stadium
{
    public record GetStadiumByIdHandler : IRequestHandler<GetStadiumByIdQuery, StadiumResponseDto>
    {
        private readonly IStadiumRepository _stadiumRepository;

        public GetStadiumByIdHandler(IStadiumRepository stadiumRepository)
        {
            _stadiumRepository = stadiumRepository;
        }

        public async Task<StadiumResponseDto> Handle(GetStadiumByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _stadiumRepository.GetStadiumById(request.Id);
            if (response is null)
                throw new CommandQueryMessageException($"Can't find Stadium with id {request.Id}.", (int)HttpStatusCode.NotFound);

            return response.Adapt<StadiumResponseDto>();
        }
    }
}
