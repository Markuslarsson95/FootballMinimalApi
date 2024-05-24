using Application.Interfaces;
using FluentValidation;

namespace Application.Commands.Players.Validators
{
    public class UpdatePlayerValidator : AbstractValidator<UpdatePlayer.Command>
    {
        private readonly IClubRepository _clubRepository;
        public UpdatePlayerValidator(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;

            RuleFor(player => player.Dto.FirstName)
                .NotEmpty()
                .Length(2, 100)
                .WithMessage("Ensure the player first name is provided and meets the required length criteria: at least 2 characters long, but no more than 100.");

            RuleFor(player => player.Dto.LastName)
                .NotEmpty()
                .Length(2, 100)
                .WithMessage("Ensure the player last name is provided and meets the required length criteria: at least 2 characters long, but no more than 100.");

            RuleFor(player => player.Dto.ClubId)
                .MustAsync(async (clubId, cancellation) =>
                {
                    var club = await _clubRepository.GetById(clubId);
                    return club != null;
                })
                .WithMessage("The specified club does not exist.");

            RuleFor(player => player.Dto.Position)
                .NotEmpty()
                .WithMessage("Ensure the player position is provided.");

            RuleFor(player => player.Dto.Nationality)
                .NotEmpty()
                .WithMessage("Ensure the player nationality is provided.");

            RuleFor(player => player.Dto.DateOfBirth)
                .Must(dateOfBirth => dateOfBirth < DateOnly.FromDateTime(DateTime.Now))
                .WithMessage("Ensure the player date of birth is in the past.");

            RuleFor(player => player.Dto.KitNumber)
                .GreaterThan(0)
                .WithMessage("Ensure the player kit number is greater than 0.");

            RuleFor(player => player.Dto.Height)
                .GreaterThan(0)
                .WithMessage("Ensure the player height is greater than 0.");
        }
    }
}
