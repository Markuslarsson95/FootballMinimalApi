using MediatR;
using WebApp.DTOs.Stadium;

namespace Application.Commands.Stadiums
{
    public record UpdateStadiumCommand : IRequest<StadiumResponseDto>
    {
        public UpdateStadiumCommand(int id, UpdateStadiumDto updateDto)
        {
            Id = id;
            UpdateDto = updateDto;
        }
        public int Id { get; }
        public UpdateStadiumDto UpdateDto { get; }        
    }
}
