using Application.Interfaces;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApp;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("FootballDb");

            services.AddDbContext<FootballDbContext>(opt =>
                opt.UseSqlServer(connectionString)
            );

            services.AddScoped<IStadiumRepository, StadiumRepository>();
            services.AddScoped<IClubRepository, ClubRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();

            return services;
        }
    }
}
