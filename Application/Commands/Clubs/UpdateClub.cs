using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Exceptions.Errors;
using Application.Interfaces;
using Mapster;
using MediatR;
using WebApp.DTOs.Club;

namespace Application.Commands.Clubs
{
    public static class UpdateClub
    {
        public record Command(int Id, UpdateClubDto Dto) : ICommand<Result<ClubResponseDto>>;

        public class Handler : IRequestHandler<Command, Result<ClubResponseDto>>
        {
            private readonly IClubRepository _clubRepository;

            public Handler(IClubRepository clubRepository)
            {
                _clubRepository = clubRepository;
            }

            public async Task<Result<ClubResponseDto>> Handle(Command request, CancellationToken cancellationToken)
            {
                var club = await _clubRepository.GetById(request.Id);
                if (club is null)
                    return Result<ClubResponseDto>.Failure(ClubErrors.NotFound(request.Id));

                club.StadiumId = request.Dto.StadiumId;
                club.Name = request.Dto.Name;
                club.LeaguePoints = request.Dto.LeaguePoints;
                club.MatchesPlayed = request.Dto.MatchesPlayed;
                club.Wins = request.Dto.Wins;
                club.Losses = request.Dto.Losses;
                club.Drawns = request.Dto.Draws;
                club.Goals = request.Dto.Goals;
                club.GoalsConceded = request.Dto.GoalsConceded;
                club.CleanSheets = request.Dto.CleanSheets;
                club.YearFounded = request.Dto.YearFounded;

                await _clubRepository.Update(club);

                return Result<ClubResponseDto>.Success(club.Adapt<ClubResponseDto>());
            }
        }
    }
}
