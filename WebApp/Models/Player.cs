namespace WebApp.Models
{
    public class Player
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int? ClubId { get; set; }
        public Club? Club { get; set; } = null!;
        public required string Position { get; set; }
        public required string Nationality { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int KitNumber { get; set; }
        public int Height { get; set; }
    }
}
