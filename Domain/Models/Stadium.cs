namespace WebApp.Models
{
    public class Stadium
    {
        public int Id { get; set; }
        public Club? Club { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public int YearBuilt { get; set; }
        public string Adress { get; set; } = string.Empty;
    }
}
