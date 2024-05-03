using Application.Abstractions.Messaging;
using Application.Interfaces;
using MediatR;
using WebApp.DTOs.Stadium;
using WebApp.Models;

namespace Application.Commands.Stadiums
{
    public static class AddStdium
    {
        public record Command(CreateStadiumDto dto) : ICommand<int>;

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }
            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var stadium = new Stadium
                {
                    Name = request.dto.Name,
                    Location = request.dto.Location,
                    Adress = request.dto.Address,
                    Capacity = request.dto.Capacity,
                    YearBuilt = request.dto.YearBuilt
                };
                await _stadiumRepository.Add(stadium);

                return stadium.Id;
            }
        }
    }
}
