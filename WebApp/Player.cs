namespace WebApp
{
    public class Player
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public Club? Club { get; set; }
        public int ClubId { get; set; }
    }
}
