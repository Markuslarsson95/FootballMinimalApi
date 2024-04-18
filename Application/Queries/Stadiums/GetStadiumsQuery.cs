using MediatR;
using WebApp.DTOs.Stadium;

namespace Application.Queries.Stadium
{
    public record GetStadiumsQuery() : IRequest<IEnumerable<StadiumResponseDto>>;
}
