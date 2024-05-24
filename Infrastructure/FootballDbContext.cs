using Microsoft.EntityFrameworkCore;
using WebApp.DataSeeder;
using WebApp.Models;

namespace WebApp
{
    public class FootballDbContext : DbContext
    {
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }

        public FootballDbContext(DbContextOptions<FootballDbContext> options)
        : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed data
            DbSeedData.SeedStadiums(modelBuilder);
            DbSeedData.SeedClubs(modelBuilder);
            DbSeedData.SeedPlayers(modelBuilder);
        }
    }
}
