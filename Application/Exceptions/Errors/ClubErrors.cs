using Application.Abstractions;

namespace Application.Exceptions.Errors
{
    public static class ClubErrors
    {
        public static Error NotFound(int id) => Error.NotFound("Club.NotFound", $"No club with id {id} found");
    }
}
