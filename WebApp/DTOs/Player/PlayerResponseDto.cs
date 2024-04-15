namespace WebApp.DTOs.Player
{
    public record PlayerResponseDto(int Id, 
        string FirstName, 
        string LastName, 
        string Club,
        string Position,
        string Nationality,
        DateOnly DateOfBirth,
        int KitNumber,
        int Height);
}
