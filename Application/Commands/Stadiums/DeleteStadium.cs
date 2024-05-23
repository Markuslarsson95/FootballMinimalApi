using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Exceptions.Errors;
using Application.Interfaces;
using MediatR;

namespace Application.Commands.Stadiums
{
    public static class DeleteStadium
    {
        public record Command(int Id) : ICommand<Result<bool>>;

        public class Handler : IRequestHandler<Command, Result<bool>>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }

            public async Task<Result<bool>> Handle(Command request, CancellationToken cancellationToken)
            {
                var stadium = await _stadiumRepository.GetById(request.Id);
                if (stadium is null)
                    return Result<bool>.Failure(StadiumErrors.NotFound(request.Id));

                _stadiumRepository.Remove(stadium);

                return Result<bool>.Success(true);
            }
        }
    }
}
