using FluentValidation;

namespace Application.Commands.Stadiums.Validators
{
    public class UpdateStadiumValidator : AbstractValidator<UpdateStadium.Command>
    {
        public UpdateStadiumValidator()
        {
            RuleFor(stadium => stadium.dto.Name)
                .NotEmpty()
                .Length(2, 100)
                .WithMessage("Ensure the stadium name is provided and meets the required length criteria: at least 2 characters long, but no more than 100.");

            RuleFor(stadium => stadium.dto.Location)
                .NotEmpty()
                .Length(2, 200)
                .WithMessage("The stadium location must be provided and be at least 2 characters long, with a maximum length of 200 characters.");

            RuleFor(stadium => stadium.dto.Address)
                .NotEmpty()
                .Length(2, 200)
                .WithMessage("The stadium address must be provided and be at least 2 characters long, with a maximum length of 200 characters.");

            RuleFor(stadium => stadium.dto.Capacity)
                .InclusiveBetween(1, 999999)
                .WithMessage("Ensure the stadium capacity falls within the acceptable range of 1 to 999,999.");

            RuleFor(stadium => stadium.dto.YearBuilt)
                .GreaterThan(0)
                .LessThan(DateTime.UtcNow.Year)
                .WithMessage("Ensure the year the stadium was built is a valid year (greater than 0) and does not exceed the current year.");
        }
    }
}
