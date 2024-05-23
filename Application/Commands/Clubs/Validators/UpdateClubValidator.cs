using Application.Interfaces;
using FluentValidation;

namespace Application.Commands.Clubs.Validators
{
    public class UpdateClubValidator : AbstractValidator<UpdateClub.Command>
    {
        private readonly IStadiumRepository _stadiumRepository;

        public UpdateClubValidator(IStadiumRepository stadiumRepository)
        {
            _stadiumRepository = stadiumRepository;

            RuleFor(club => club.Dto.Name)
                .NotEmpty()
                .WithMessage("Ensure the club name is provided.");

            RuleFor(club => club.Dto.LeaguePoints)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the league points are greater than or equal to 0.");

            RuleFor(club => club.Dto.MatchesPlayed)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the matches played are greater than or equal to 0.");

            RuleFor(club => club.Dto.Wins)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of wins is greater than or equal to 0.");

            RuleFor(club => club.Dto.Losses)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of losses is greater than or equal to 0.");

            RuleFor(club => club.Dto.Draws)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of draws is greater than or equal to 0.");

            RuleFor(club => club.Dto.Goals)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of goals is greater than or equal to 0.");

            RuleFor(club => club.Dto.GoalsConceded)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of goals conceded is greater than or equal to 0.");

            RuleFor(club => club.Dto.CleanSheets)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of clean sheets is greater than or equal to 0.");

            RuleFor(club => club.Dto.YearFounded)
                .Must(yearFounded => yearFounded <= DateTime.Now.Year)
                .WithMessage("Ensure the year founded is not in the future.");

            RuleFor(club => club.Dto.StadiumId)
                .MustAsync(async (stadiumId, cancellation) =>
                {
                    var stadium = await _stadiumRepository.GetById(stadiumId);
                    return stadium != null;
                })
                .WithMessage("The specified stadium does not exist.");
        }
    }
}
