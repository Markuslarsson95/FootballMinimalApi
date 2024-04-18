using MediatR;
using WebApp.DTOs.Stadium;

namespace Application.Commands.Stadiums
{
    public record AddStdiumCommand : IRequest<int>
    {
        public AddStdiumCommand(CreateStadiumDto newStadium)
        {
            NewStadium = newStadium;
        }
        public CreateStadiumDto NewStadium { get; }
    }
}
