using Application.Interfaces;
using FluentValidation;

namespace Application.Commands.Players.Validators
{
    public class CreatePlayerValidator : AbstractValidator<AddPlayer.Command>
    {
        private readonly IClubRepository _clubRepository;
        public CreatePlayerValidator(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;

            RuleFor(player => player.dto.FirstName)
                .NotEmpty()
                .Length(2, 100)
                .WithMessage("Ensure the player first name is provided and meets the required length criteria: at least 2 characters long, but no more than 100.");

            RuleFor(player => player.dto.LastName)
                .NotEmpty()
                .Length(2, 100)
                .WithMessage("Ensure the player last name is provided and meets the required length criteria: at least 2 characters long, but no more than 100.");

            RuleFor(player => player.dto.ClubId)
                .MustAsync(async (clubId, cancellation) =>
                {
                    var club = await _clubRepository.GetById(clubId);
                    return club != null;
                })
                .WithMessage("The specified club does not exist.");

            RuleFor(player => player.dto.Position)
                .NotEmpty()
                .WithMessage("Ensure the player position is provided.");

            RuleFor(player => player.dto.Nationality)
                .NotEmpty()
                .WithMessage("Ensure the player nationality is provided.");

            RuleFor(player => player.dto.DateOfBirth)
                .Must(dateOfBirth => dateOfBirth < DateOnly.FromDateTime(DateTime.Now))
                .WithMessage("Ensure the player date of birth is in the past.");

            RuleFor(player => player.dto.KitNumber)
                .GreaterThan(0)
                .WithMessage("Ensure the player kit number is greater than 0.");

            RuleFor(player => player.dto.Height)
                .GreaterThan(0)
                .WithMessage("Ensure the player height is greater than 0.");
        }
    }
}
