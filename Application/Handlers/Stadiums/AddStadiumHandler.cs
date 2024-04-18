using Application.Commands.Stadiums;
using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.Models;

namespace Application.Handlers.Stadiums
{
    public record AddStadiumHandler : IRequestHandler<AddStdiumCommand, int>
    {
        private readonly IStadiumRepository _stadiumRepository;

        public AddStadiumHandler(IStadiumRepository stadiumRepository)
        {
            _stadiumRepository = stadiumRepository;
        }
        public async Task<int> Handle(AddStdiumCommand request, CancellationToken cancellationToken)
        {
            var stadium = new WebApp.Models.Stadium
            {
                Name = request.NewStadium.Name,
                Location = request.NewStadium.Location,
                Adress = request.NewStadium.Adress,
                Capacity = request.NewStadium.Capacity,
                YearBuilt = request.NewStadium.YearBuilt
            };
            _stadiumRepository.AddStadium(stadium);
            _stadiumRepository.Save();

            return stadium.Id;
        }
    }
}
