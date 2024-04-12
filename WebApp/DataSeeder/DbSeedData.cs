using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.DataSeeder
{
    public static class DbSeedData
    {
        public static void SeedClubs(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().HasData(
                new Club
                {
                    Id = 1,
                    Name = "Arsenal",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1886
                },
                new Club
                {
                    Id = 2,
                    Name = "Aston Villa",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1874
                },
                new Club
                {
                    Id = 3,
                    Name = "AFC Bournemouth",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1899
                },
                new Club
                {
                    Id = 4,
                    Name = "Brentford",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1889
                },
                new Club
                {
                    Id = 5,
                    Name = "Brighton and Hove Albion",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1901
                },
                new Club
                {
                    Id = 6,
                    Name = "Burnley",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1882
                },
                new Club
                {
                    Id = 7,
                    Name = "Chelsea",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1905
                },
                new Club
                {
                    Id = 8,
                    Name = "Crystal Palace",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1905
                },
                new Club
                {
                    Id = 9,
                    Name = "Everton",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1878
                },
                new Club
                {
                    Id = 10,
                    Name = "Fulham",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1879
                },
                new Club
                {
                    Id = 11,
                    Name = "Liverpool",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1892
                },
                new Club
                {
                    Id = 12,
                    Name = "Luton Town",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1885
                },
                new Club
                {
                    Id = 13,
                    Name = "Manchester City",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1887
                },
                new Club
                {
                    Id = 14,
                    Name = "Manchester United",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1878
                },
                new Club
                {
                    Id = 15,
                    Name = "Newcastle United",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1892
                },
                new Club
                {
                    Id = 16,
                    Name = "Nottingham Forest",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1865
                },
                new Club
                {
                    Id = 17,
                    Name = "Sheffield United",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1889
                },
                new Club
                {
                    Id = 18,
                    Name = "Tottenham Hotspur",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1882
                },
                new Club
                {
                    Id = 19,
                    Name = "West Ham United",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1895
                },
                new Club
                {
                    Id = 20,
                    Name = "Wolverhampton Wanderers",
                    LeaguePoints = 0,
                    MatchesPlayed = 0,
                    Wins = 0,
                    Losses = 0,
                    Drawns = 0,
                    Goals = 0,
                    GoalsConceded = 0,
                    CleanSheets = 0,
                    YearFounded = 1877
                });
        }
    }
}
