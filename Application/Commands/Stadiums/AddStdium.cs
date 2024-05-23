using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Interfaces;
using MediatR;
using WebApp.DTOs.Stadium;
using WebApp.Models;

namespace Application.Commands.Stadiums
{
    public static class AddStdium
    {
        public record Command(CreateStadiumDto Dto) : ICommand<Result<int>>;

        public class Handler : IRequestHandler<Command, Result<int>>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }
            public async Task<Result<int>> Handle(Command request, CancellationToken cancellationToken)
            {
                var stadium = new Stadium
                {
                    Name = request.Dto.Name,
                    Location = request.Dto.Location,
                    Adress = request.Dto.Address,
                    Capacity = request.Dto.Capacity,
                    YearBuilt = request.Dto.YearBuilt
                };
                await _stadiumRepository.Add(stadium);

                return Result<int>.Success(stadium.Id);
            }
        }
    }
}
