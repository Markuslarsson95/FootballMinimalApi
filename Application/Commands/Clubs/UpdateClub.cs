using Application.Abstractions.Messaging;
using Application.Interfaces;
using MediatR;
using System.Net;
using WebApp.DTOs.Club;
using WebApp.Exceptions;

namespace Application.Commands.Clubs
{
    public static class UpdateClub
    {
        public record Command(int id, UpdateClubDto dto) : ICommand;

        public class Handler : IRequestHandler<Command>
        {
            private readonly IClubRepository _clubRepository;

            public Handler(IClubRepository clubRepository)
            {
                _clubRepository = clubRepository;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var club = await _clubRepository.GetById(request.id);
                if (club is null)
                    throw new CommandQueryMessageException($"Can't find Club with id {request.id}", (int)HttpStatusCode.NotFound);

                club.StadiumId = request.dto.StadiumId;
                club.Name = request.dto.Name;
                club.LeaguePoints = request.dto.LeaguePoints;
                club.MatchesPlayed = request.dto.MatchesPlayed;
                club.Wins = request.dto.Wins;
                club.Losses = request.dto.Losses;
                club.Drawns = request.dto.Draws;
                club.Goals = request.dto.Goals;
                club.GoalsConceded = request.dto.GoalsConceded;
                club.CleanSheets = request.dto.CleanSheets;
                club.YearFounded = request.dto.YearFounded;

                await _clubRepository.Update(club);
            }
        }
    }
}
