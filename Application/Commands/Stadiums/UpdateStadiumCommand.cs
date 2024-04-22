using Application.Interfaces;
using Mapster;
using MediatR;
using System.Net;
using WebApp.DTOs.Stadium;
using WebApp.Exceptions;

namespace Application.Commands.Stadiums
{
    public static class UpdateStadiumCommand
    {
        public record Command(int id, UpdateStadiumDto dto) : IRequest<StadiumResponseDto>;

        public class Handler : IRequestHandler<Command, StadiumResponseDto>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }

            public async Task<StadiumResponseDto> Handle(Command request, CancellationToken cancellationToken)
            {
                var stadium = await _stadiumRepository.GetById(request.id);
                if (stadium == null)
                    throw new CommandQueryMessageException($"Can't find stadium with id {request.id}", (int)HttpStatusCode.NotFound);
                
                stadium.Name = request.dto.Name;
                stadium.Location = request.dto.Location;
                stadium.Capacity = request.dto.Capacity;
                stadium.YearBuilt = request.dto.YearBuilt;
                stadium.Adress = request.dto.Adress;

                await _stadiumRepository.Update(stadium);

                return stadium.Adapt<StadiumResponseDto>();
            }
        }
    }
}
