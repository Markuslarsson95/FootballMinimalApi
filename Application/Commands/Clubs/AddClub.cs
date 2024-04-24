using Application.Interfaces;
using MediatR;
using WebApp.DTOs.Club;
using WebApp.Models;

namespace Application.Commands.Clubs
{
    public static class AddClub
    {
        public record Command(CreateClubDto dto) : IRequest<int>;

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IClubRepository _clubRepository;

            public Handler(IClubRepository clubRepository)
            {
                _clubRepository = clubRepository;
            }
            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var club = new Club
                {
                    StadiumId = request.dto.StadiumId,
                    Name = request.dto.Name,
                    LeaguePoints = request.dto.LeaguePoints,
                    MatchesPlayed = request.dto.MatchesPlayed,
                    Wins = request.dto.Wins,
                    Losses = request.dto.Losses,
                    Drawns = request.dto.Drawns,
                    Goals = request.dto.Goals,
                    GoalsConceded = request.dto.GoalsConceded,
                    CleanSheets = request.dto.CleanSheets,
                    YearFounded = request.dto.YearFounded
                };
                await _clubRepository.Add(club);

                return club.Id;
            }
        }
    }
}
