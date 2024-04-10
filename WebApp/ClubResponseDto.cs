namespace WebApp
{
    public record ClubResponseDto
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public List<Player>? Players { get; init; }

        public ClubResponseDto() { }
        public ClubResponseDto(Club club) => 
            (Id, Name, Players) = (club.Id, club.Name, club.Players);
    }
}
