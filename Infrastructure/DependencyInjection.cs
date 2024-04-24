using Application.Interfaces;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApp;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<FootballDbContext>(opt => opt.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = Football; Integrated Security = true"));
            //services.AddDbContext<FootballDbContext>(opt => opt.UseSqlServer("Server=(local)\\SQLEXPRESS;Database=Football;Trusted_Connection=True;TrustServerCertificate=true"));

            services.AddScoped<IStadiumRepository, StadiumRepository>();
            services.AddScoped<IClubRepository, ClubRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();

            return services;
        }
    }
}
