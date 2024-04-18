using Application.Commands.Stadiums;
using Application.Interfaces;
using MediatR;
using System.Net;
using WebApp.DTOs.Stadium;
using WebApp.Exceptions;

namespace Application.Handlers.Stadiums
{
    public record UpdateStadiumHandler : IRequestHandler<UpdateStadiumCommand, StadiumResponseDto>
    {
        private readonly IStadiumRepository _stadiumRepository;

        public UpdateStadiumHandler(IStadiumRepository stadiumRepository)
        {
            _stadiumRepository = stadiumRepository;
        }

        public Task<StadiumResponseDto> Handle(UpdateStadiumCommand request, CancellationToken cancellationToken)
        {
            var stadium = _stadiumRepository.GetStadiumById(request.Id);
            if (stadium == null)
                throw new CommandQueryMessageException($"Can't find stadium with id {request.Id}", (int)HttpStatusCode.NotFound);
            throw new NotImplementedException();
        }
    }
}
