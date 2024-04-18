namespace WebApp.DTOs.Player
{
    public record UpdatePlayerDto(
        string FirstName,
        string LastnName,
        int? ClubId,
        string Position,
        string Nationality,
        DateOnly DateOfBirth,
        int KitNumber,
        int Height);
}
