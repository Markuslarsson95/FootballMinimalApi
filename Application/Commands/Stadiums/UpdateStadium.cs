using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Exceptions.Errors;
using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Stadium;

namespace Application.Commands.Stadiums
{
    public static class UpdateStadium
    {
        public record Command(int Id, UpdateStadiumDto Dto) : ICommand<Result<StadiumResponseDto>>;

        public class Handler : IRequestHandler<Command, Result<StadiumResponseDto>>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }

            public async Task<Result<StadiumResponseDto>> Handle(Command request, CancellationToken cancellationToken)
            {
                var stadium = await _stadiumRepository.GetById(request.Id);
                if (stadium is null)
                    return Result<StadiumResponseDto>.Failure(StadiumErrors.NotFound(request.Id));

                stadium.Name = request.Dto.Name;
                stadium.Location = request.Dto.Location;
                stadium.Capacity = request.Dto.Capacity;
                stadium.YearBuilt = request.Dto.YearBuilt;
                stadium.Adress = request.Dto.Address;

                await _stadiumRepository.Update(stadium);

                return Result<StadiumResponseDto>.Success(stadium.Adapt<StadiumResponseDto>());
            }
        }
    }
}
