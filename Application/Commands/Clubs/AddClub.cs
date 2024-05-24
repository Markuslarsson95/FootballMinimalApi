using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Interfaces;
using MediatR;
using WebApp.DTOs.Club;
using WebApp.Models;

namespace Application.Commands.Clubs
{
    public static class AddClub
    {
        public record Command(CreateClubDto Dto) : ICommand<Result<int>>;

        public class Handler : IRequestHandler<Command, Result<int>>
        {
            private readonly IClubRepository _clubRepository;

            public Handler(IClubRepository clubRepository)
            {
                _clubRepository = clubRepository;
            }
            public async Task<Result<int>> Handle(Command request, CancellationToken cancellationToken)
            {
                var club = new Club
                {
                    StadiumId = request.Dto.StadiumId,
                    Name = request.Dto.Name,
                    LeaguePoints = request.Dto.LeaguePoints,
                    MatchesPlayed = request.Dto.MatchesPlayed,
                    Wins = request.Dto.Wins,
                    Losses = request.Dto.Losses,
                    Drawns = request.Dto.Drawns,
                    Goals = request.Dto.Goals,
                    GoalsConceded = request.Dto.GoalsConceded,
                    CleanSheets = request.Dto.CleanSheets,
                    YearFounded = request.Dto.YearFounded
                };
                await _clubRepository.Add(club);

                return Result<int>.Success(club.Id);
            }
        }
    }
}
