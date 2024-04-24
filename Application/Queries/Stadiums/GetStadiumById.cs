using Application.Interfaces;
using Mapster;
using MediatR;
using System.Net;
using WebApp.DTOs.Stadium;
using WebApp.Exceptions;

namespace Application.Queries.Stadium
{
    public static class GetStadiumById
    {
        public record Query(int Id) : IRequest<StadiumResponseDto>;

        public class Handler : IRequestHandler<Query, StadiumResponseDto>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }

            public async Task<StadiumResponseDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var stadium = await _stadiumRepository.GetById(request.Id);
                if (stadium is null)
                    throw new CommandQueryMessageException($"Can't find Stadium with id {request.Id}.", (int)HttpStatusCode.NotFound);

                return stadium.Adapt<StadiumResponseDto>();
            }
        }
    }
}
