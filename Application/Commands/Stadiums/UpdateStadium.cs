using Application.Abstractions.Messaging;
using Application.Interfaces;
using Mapster;
using MediatR;
using System.Net;
using WebApp.DTOs.Stadium;
using WebApp.Exceptions;

namespace Application.Commands.Stadiums
{
    public static class UpdateStadium
    {
        public record Command(int id, UpdateStadiumDto dto) : ICommand<StadiumResponseDto>;

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
                if (stadium is null)
                    throw new CommandQueryMessageException($"Can't find stadium with id {request.id}", (int)HttpStatusCode.NotFound);

                stadium.Name = request.dto.Name;
                stadium.Location = request.dto.Location;
                stadium.Capacity = request.dto.Capacity;
                stadium.YearBuilt = request.dto.YearBuilt;
                stadium.Adress = request.dto.Address;

                await _stadiumRepository.Update(stadium);

                return stadium.Adapt<StadiumResponseDto>();
            }
        }
    }
}
