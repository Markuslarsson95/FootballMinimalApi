using Application.Abstractions;

namespace Application.Exceptions.Errors
{
    public static class StadiumErrors
    {
        public static Error NotFound(int id) => Error.NotFound("Stadium.NotFound", $"No stadium with id {id} found");
    }
}
