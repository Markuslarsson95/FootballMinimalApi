using Application.Abstractions;

namespace Application.Commands.Clubs
{
    public static class ClubErrors
    {
        public static Error NotFound(int id) => Error.NotFound("Club.NotFound", $"No club with id {id} found");
    }
}
