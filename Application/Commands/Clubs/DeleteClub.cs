﻿using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Interfaces;
using MediatR;

namespace Application.Commands.Clubs
{
    public static class DeleteClub
    {
        public record Command(int id) : ICommand<Result<bool>>;

        public class Handler : IRequestHandler<Command, Result<bool>>
        {
            private readonly IClubRepository _clubRepository;

            public Handler(IClubRepository clubRepository)
            {
                _clubRepository = clubRepository;
            }

            public async Task<Result<bool>> Handle(Command request, CancellationToken cancellationToken)
            {
                var club = await _clubRepository.GetById(request.id);
                if (club is null)
                    return Result<bool>.Failure(ClubErrors.NotFound(request.id));

                _clubRepository.Remove(club);

                return Result<bool>.Success(true);
            }
        }
    }
}
