namespace WebApp.DTOs.Stadium
{
    public record CreateStadiumDto(string Name,
        string Location,
        int Capacity,
        int YearBuilt,
        string Adress);
}
