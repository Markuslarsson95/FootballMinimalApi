namespace WebApp.DTOs.Player
{
    public record UpdatePlayerDto(
        string FirstName,
        string LastName,
        int ClubId,
        string Position,
        string Nationality,
        DateOnly DateOfBirth,
        int KitNumber,
        int Height);
}
