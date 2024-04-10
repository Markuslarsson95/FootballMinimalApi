using Microsoft.EntityFrameworkCore;

namespace WebApp
{
    public class AppDb : DbContext
    {
        //public DbSet<Todo> Todos => Set<Todo>();
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players {  get; set; }

        public AppDb(DbContextOptions<AppDb> options)
        : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
