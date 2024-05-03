using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.DataSeeder
{
    public static class DbSeedData
    {
        public static void SeedStadiums(ModelBuilder modelBuilder)
        {
            #region Stadiums
            modelBuilder.Entity<Stadium>().HasData(
                new Stadium
                {
                    Id = 1,
                    Name = "Emirates Stadium",
                    Location = "London",
                    Capacity = 60704,
                    YearBuilt = 2006,
                    Adress = "Highbury House, 75 Drayton Park, London, N5 1BU"
                },
                new Stadium
                {
                    Id = 2,
                    Name = "Villa Park",
                    Location = "Birmingham",
                    Capacity = 42530,
                    YearBuilt = 1897,
                    Adress = "Villa Park, Trinity Road, Birmingham, B6 6HE"
                },
                new Stadium
                {
                    Id = 3,
                    Name = "Vitality Stadium",
                    Location = "Bournemouth",
                    Capacity = 11307,
                    YearBuilt = 1910,
                    Adress = "Vitality Stadium, Dean Court, Bournemouth, BH7 7AF"
                },
                new Stadium
                {
                    Id = 4,
                    Name = "Gtech Community Stadium",
                    Location = "Brentford",
                    Capacity = 17250,
                    YearBuilt = 2000,
                    Adress = "Gtech Community Stadium, Lionel Road South, Brentford, TW8 0RU"
                },
                new Stadium
                {
                    Id = 5,
                    Name = "American Express Stadium",
                    Location = "Falmer",
                    Capacity = 31876,
                    YearBuilt = 2011,
                    Adress = "American Express Community Stadium, Village Way, Brighton, BN1 9BL"
                },
                new Stadium
                {
                    Id = 6,
                    Name = "Turf Moor",
                    Location = "Burnley",
                    Capacity = 21944,
                    YearBuilt = 1883,
                    Adress = "Turf Moor, Harry Potts Way, Burnley, Lancashire, BB10 4BX"
                },
                new Stadium
                {
                    Id = 7,
                    Name = "Stamford Bridge",
                    Location = "London",
                    Capacity = 40343,
                    YearBuilt = 1877,
                    Adress = "Stamford Bridge, Fulham Road, London, SW6 1HS"
                },
                new Stadium
                {
                    Id = 8,
                    Name = "Selhurst Park",
                    Location = "London",
                    Capacity = 25486,
                    YearBuilt = 1924,
                    Adress = "Selhurst Park Stadium, Holmesdale Road, London, SE25 6PU"
                },
                new Stadium
                {
                    Id = 9,
                    Name = "Goodison Park",
                    Location = "Liverpool",
                    Capacity = 39414,
                    YearBuilt = 1892,
                    Adress = "Goodison Park, Goodison Road, Liverpool, L4 4EL"
                },
                new Stadium
                {
                    Id = 10,
                    Name = "Craven Cottage",
                    Location = "London",
                    Capacity = 24500,
                    YearBuilt = 1896,
                    Adress = "Stevenage Road, London, SW6 6HH"
                },
                new Stadium
                {
                    Id = 11,
                    Name = "Anfield",
                    Location = "Liverpool",
                    Capacity = 61276,
                    YearBuilt = 1884,
                    Adress = "Anfield, Anfield Road, Liverpool, L4 0TH"
                },
                new Stadium
                {
                    Id = 12,
                    Name = "Kenilworth Road",
                    Location = "Luton",
                    Capacity = 10265,
                    YearBuilt = 1905,
                    Adress = "Kenilworth Road Stadium, 1 Maple Road, Luton, LU4 8AW"
                },
                new Stadium
                {
                    Id = 13,
                    Name = "Etihad Stadium",
                    Location = "Manchester",
                    Capacity = 53400,
                    YearBuilt = 2002,
                    Adress = "Etihad Stadium, Etihad Campus, Manchester, M11 3FF"
                },
                new Stadium
                {
                    Id = 14,
                    Name = "Old Trafford",
                    Location = "Manchester",
                    Capacity = 74310,
                    YearBuilt = 1909,
                    Adress = "Sir Matt Busby Way, Old Trafford, Manchester, M16 0RA"
                },
                new Stadium
                {
                    Id = 15,
                    Name = "St. James' Park",
                    Location = "Newcastle",
                    Capacity = 52305,
                    YearBuilt = 1892,
                    Adress = "St. James' Park, Newcastle Upon Tyne, NE1 4ST"
                },
                new Stadium
                {
                    Id = 16,
                    Name = "The City Ground",
                    Location = "Nottingham",
                    Capacity = 30404,
                    YearBuilt = 1898,
                    Adress = "Nottingham Forest Football Club, The City Ground, Pavilion Road, West Bridgford, Nottingham, NG2 5FJ"
                },
                new Stadium
                {
                    Id = 17,
                    Name = "Bramall Lane",
                    Location = "Sheffield",
                    Capacity = 32050,
                    YearBuilt = 1855,
                    Adress = "Bramall Lane, Sheffield, South Yorkshire, S2 4SU"
                },
                new Stadium
                {
                    Id = 18,
                    Name = "Tottenham Hotspur Stadium",
                    Location = "London",
                    Capacity = 62850,
                    YearBuilt = 2019,
                    Adress = "Lilywhite House, 782 High Road, Tottenham, London, N17 0BX"
                },
                new Stadium
                {
                    Id = 19,
                    Name = "London Stadium",
                    Location = "London",
                    Capacity = 62500,
                    YearBuilt = 2011,
                    Adress = "London Stadium, Queen Elizabeth Olympic Park, London, E20 2ST"
                },
                new Stadium
                {
                    Id = 20,
                    Name = "Molineux Stadium",
                    Location = "Wolverhampton",
                    Capacity = 31750,
                    YearBuilt = 1889,
                    Adress = "Molineux Stadium, Waterloo Rd, Wolverhampton, WV1 4QR"
                });
            #endregion

        }
        public static void SeedClubs(ModelBuilder modelBuilder)
        {
            #region Clubs
            modelBuilder.Entity<Club>().HasData(
                new Club
                {
                    Id = 1,
                    StadiumId = 1,
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
                    StadiumId = 2,
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
                    StadiumId = 3,
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
                    StadiumId = 4,
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
                    StadiumId = 5,
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
                    StadiumId = 6,
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
                    StadiumId = 7,
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
                    StadiumId = 8,
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
                    StadiumId = 9,
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
                    StadiumId = 10,
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
                    StadiumId = 11,
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
                    StadiumId = 12,
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
                    StadiumId = 13,
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
                    StadiumId = 14,
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
                    StadiumId = 15,
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
                    StadiumId = 16,
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
                    StadiumId = 17,
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
                    StadiumId = 18,
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
                    StadiumId = 19,
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
                    StadiumId = 20,
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
            #endregion
        }
    }
}
