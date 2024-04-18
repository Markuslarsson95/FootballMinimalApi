using MediatR;
using WebApp.DTOs.Stadium;

namespace Application.Queries.Stadium
{
    public record GetStadiumByIdQuery(int Id) : IRequest<StadiumResponseDto>
    {
    }
}
