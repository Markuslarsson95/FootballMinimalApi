using Application.Abstractions.Messaging;
using Application.Interfaces;
using FluentValidation;
using MediatR;
using WebApp.DTOs.Stadium;
using WebApp.Models;

namespace Application.Commands.Stadiums
{
    public static class AddStdium
    {
        public record Command(CreateStadiumDto dto) : ICommand<int>;

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }
            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var stadium = new Stadium
                {
                    Name = request.dto.Name,
                    Location = request.dto.Location,
                    Adress = request.dto.Address,
                    Capacity = request.dto.Capacity,
                    YearBuilt = request.dto.YearBuilt
                };
                await _stadiumRepository.Add(stadium);

                return stadium.Id;
            }
        }
    }

    public class CreateStadiumValidator : AbstractValidator<AddStdium.Command>
    {
        public CreateStadiumValidator() 
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
