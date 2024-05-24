using Application.Abstractions;

namespace Application.Exceptions.Errors
{
    public static class PlayerErrors
    {
        public static Error NotFound(int id) => Error.NotFound("Player.NotFound", $"No player with id {id} found");
    }
}
