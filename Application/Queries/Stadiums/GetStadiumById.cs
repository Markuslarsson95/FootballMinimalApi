using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Exceptions.Errors;
using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Stadium;

namespace Application.Queries.Stadium
{
    public static class GetStadiumById
    {
        public record Query(int Id) : ICommand<Result<StadiumResponseDto>>;

        public class Handler : IRequestHandler<Query, Result<StadiumResponseDto>>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }

            public async Task<Result<StadiumResponseDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var stadium = await _stadiumRepository.GetById(request.Id);
                if (stadium is null)
                    return Result<StadiumResponseDto>.Failure(StadiumErrors.NotFound(request.Id));

                return Result<StadiumResponseDto>.Success(stadium.Adapt<StadiumResponseDto>());
            }
        }
    }
}
