namespace WebApp.DTOs.Stadium
{
    public record UpdateStadiumDto(string Name,
        string Location,
        int Capacity,
        int YearBuilt,
        string Address);
}
