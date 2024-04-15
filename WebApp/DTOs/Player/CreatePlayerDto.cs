namespace WebApp.DTOs.Player
{
    public record CreatePlayerDto(
        string FirstName,
        string LastnName,
        int? ClubId,
        string Position,
        string Nationality,
        DateOnly DateOfBirth,
        int KitNumber,
        int Height);
}
