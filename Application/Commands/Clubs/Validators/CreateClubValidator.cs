using Application.Interfaces;
using FluentValidation;

namespace Application.Commands.Clubs.Validators
{
    public class CreateClubValidator : AbstractValidator<AddClub.Command>
    {
        private readonly IStadiumRepository _stadiumRepository;

        public CreateClubValidator(IStadiumRepository stadiumRepository)
        {
            _stadiumRepository = stadiumRepository;

            RuleFor(club => club.dto.Name)
                .NotEmpty()
                .WithMessage("Ensure the club name is provided.");

            RuleFor(club => club.dto.LeaguePoints)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the league points are greater than or equal to 0.");

            RuleFor(club => club.dto.MatchesPlayed)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the matches played are greater than or equal to 0.");

            RuleFor(club => club.dto.Wins)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of wins is greater than or equal to 0.");

            RuleFor(club => club.dto.Losses)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of losses is greater than or equal to 0.");

            RuleFor(club => club.dto.Drawns)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of drawns is greater than or equal to 0.");

            RuleFor(club => club.dto.Goals)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of goals is greater than or equal to 0.");

            RuleFor(club => club.dto.GoalsConceded)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of goals conceded is greater than or equal to 0.");

            RuleFor(club => club.dto.CleanSheets)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ensure the number of clean sheets is greater than or equal to 0.");

            RuleFor(club => club.dto.YearFounded)
                .Must(yearFounded => yearFounded <= DateTime.Now.Year)
                .WithMessage("Ensure the year founded is not in the future.");

            RuleFor(club => club.dto.StadiumId)
                .MustAsync(async (stadiumId, cancellation) =>
                {
                    var stadium = await _stadiumRepository.GetById(stadiumId);
                    return stadium != null;
                })
                .WithMessage("The specified stadium does not exist.");
        }
    }
}
