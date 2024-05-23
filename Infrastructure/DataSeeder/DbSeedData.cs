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
                    LeaguePoints = 89,
                    MatchesPlayed = 38,
                    Wins = 28,
                    Losses = 5,
                    Drawns = 5,
                    Goals = 91,
                    GoalsConceded = 29,
                    CleanSheets = 0,
                    YearFounded = 1886
                },
                new Club
                {
                    Id = 2,
                    StadiumId = 2,
                    Name = "Aston Villa",
                    LeaguePoints = 68,
                    MatchesPlayed = 38,
                    Wins = 20,
                    Losses = 10,
                    Drawns = 8,
                    Goals = 76,
                    GoalsConceded = 61,
                    CleanSheets = 0,
                    YearFounded = 1874
                },
                new Club
                {
                    Id = 3,
                    StadiumId = 3,
                    Name = "AFC Bournemouth",
                    LeaguePoints = 48,
                    MatchesPlayed = 38,
                    Wins = 12,
                    Losses = 17,
                    Drawns = 9,
                    Goals = 54,
                    GoalsConceded = 67,
                    CleanSheets = 0,
                    YearFounded = 1899
                },
                new Club
                {
                    Id = 4,
                    StadiumId = 4,
                    Name = "Brentford",
                    LeaguePoints = 40,
                    MatchesPlayed = 38,
                    Wins = 11,
                    Losses = 18,
                    Drawns = 9,
                    Goals = 56,
                    GoalsConceded = 65,
                    CleanSheets = 0,
                    YearFounded = 1889
                },
                new Club
                {
                    Id = 5,
                    StadiumId = 5,
                    Name = "Brighton and Hove Albion",
                    LeaguePoints = 48,
                    MatchesPlayed = 38,
                    Wins = 12,
                    Losses = 16,
                    Drawns = 10,
                    Goals = 55,
                    GoalsConceded = 62,
                    CleanSheets = 0,
                    YearFounded = 1901
                },
                new Club
                {
                    Id = 6,
                    StadiumId = 6,
                    Name = "Burnley",
                    LeaguePoints = 26,
                    MatchesPlayed = 38,
                    Wins = 7,
                    Losses = 25,
                    Drawns = 6,
                    Goals = 41,
                    GoalsConceded = 78,
                    CleanSheets = 0,
                    YearFounded = 1882
                },
                new Club
                {
                    Id = 7,
                    StadiumId = 7,
                    Name = "Chelsea",
                    LeaguePoints = 63,
                    MatchesPlayed = 38,
                    Wins = 18,
                    Losses = 11,
                    Drawns = 9,
                    Goals = 77,
                    GoalsConceded = 63,
                    CleanSheets = 0,
                    YearFounded = 1905
                },
                new Club
                {
                    Id = 8,
                    StadiumId = 8,
                    Name = "Crystal Palace",
                    LeaguePoints = 49,
                    MatchesPlayed = 38,
                    Wins = 13,
                    Losses = 15,
                    Drawns = 10,
                    Goals = 57,
                    GoalsConceded = 58,
                    CleanSheets = 0,
                    YearFounded = 1905
                },
                new Club
                {
                    Id = 9,
                    StadiumId = 9,
                    Name = "Everton",
                    LeaguePoints = 40,
                    MatchesPlayed = 38,
                    Wins = 10,
                    Losses = 18,
                    Drawns = 10,
                    Goals = 48,
                    GoalsConceded = 59,
                    CleanSheets = 0,
                    YearFounded = 1878
                },
                new Club
                {
                    Id = 10,
                    StadiumId = 10,
                    Name = "Fulham",
                    LeaguePoints = 47,
                    MatchesPlayed = 38,
                    Wins = 13,
                    Losses = 18,
                    Drawns = 7,
                    Goals = 55,
                    GoalsConceded = 61,
                    CleanSheets = 0,
                    YearFounded = 1879
                },
                new Club
                {
                    Id = 11,
                    StadiumId = 11,
                    Name = "Liverpool",
                    LeaguePoints = 82,
                    MatchesPlayed = 38,
                    Wins = 24,
                    Losses = 4,
                    Drawns = 10,
                    Goals = 86,
                    GoalsConceded = 41,
                    CleanSheets = 0,
                    YearFounded = 1892
                },
                new Club
                {
                    Id = 12,
                    StadiumId = 12,
                    Name = "Luton Town",
                    LeaguePoints = 33,
                    MatchesPlayed = 38,
                    Wins = 9,
                    Losses = 24,
                    Drawns = 5,
                    Goals = 42,
                    GoalsConceded = 75,
                    CleanSheets = 0,
                    YearFounded = 1885
                },
                new Club
                {
                    Id = 13,
                    StadiumId = 13,
                    Name = "Manchester City",
                    LeaguePoints = 91,
                    MatchesPlayed = 38,
                    Wins = 28,
                    Losses = 3,
                    Drawns = 7,
                    Goals = 96,
                    GoalsConceded = 34,
                    CleanSheets = 0,
                    YearFounded = 1887
                },
                new Club
                {
                    Id = 14,
                    StadiumId = 14,
                    Name = "Manchester United",
                    LeaguePoints = 60,
                    MatchesPlayed = 38,
                    Wins = 18,
                    Losses = 14,
                    Drawns = 6,
                    Goals = 57,
                    GoalsConceded = 58,
                    CleanSheets = 0,
                    YearFounded = 1878
                },
                new Club
                {
                    Id = 15,
                    StadiumId = 15,
                    Name = "Newcastle United",
                    LeaguePoints = 60,
                    MatchesPlayed = 38,
                    Wins = 17,
                    Losses = 14,
                    Drawns = 7,
                    Goals = 85,
                    GoalsConceded = 62,
                    CleanSheets = 0,
                    YearFounded = 1892
                },
                new Club
                {
                    Id = 16,
                    StadiumId = 16,
                    Name = "Nottingham Forest",
                    LeaguePoints = 32,
                    MatchesPlayed = 38,
                    Wins = 8,
                    Losses = 22,
                    Drawns = 8,
                    Goals = 42,
                    GoalsConceded = 60,
                    CleanSheets = 0,
                    YearFounded = 1865
                },
                new Club
                {
                    Id = 17,
                    StadiumId = 17,
                    Name = "Sheffield United",
                    LeaguePoints = 16,
                    MatchesPlayed = 38,
                    Wins = 3,
                    Losses = 28,
                    Drawns = 7,
                    Goals = 35,
                    GoalsConceded = 104,
                    CleanSheets = 0,
                    YearFounded = 1889
                },
                new Club
                {
                    Id = 18,
                    StadiumId = 18,
                    Name = "Tottenham Hotspur",
                    LeaguePoints = 66,
                    MatchesPlayed = 38,
                    Wins = 20,
                    Losses = 12,
                    Drawns = 6,
                    Goals = 74,
                    GoalsConceded = 61,
                    CleanSheets = 0,
                    YearFounded = 1882
                },
                new Club
                {
                    Id = 19,
                    StadiumId = 19,
                    Name = "West Ham United",
                    LeaguePoints = 52,
                    MatchesPlayed = 38,
                    Wins = 14,
                    Losses = 14,
                    Drawns = 10,
                    Goals = 74,
                    GoalsConceded = 74,
                    CleanSheets = 0,
                    YearFounded = 1895
                },
                new Club
                {
                    Id = 20,
                    StadiumId = 20,
                    Name = "Wolverhampton Wanderers",
                    LeaguePoints = 46,
                    MatchesPlayed = 38,
                    Wins = 13,
                    Losses = 17,
                    Drawns = 8,
                    Goals = 50,
                    GoalsConceded = 65,
                    CleanSheets = 0,
                    YearFounded = 1877
                });
            #endregion
        }
        public static void SeedPlayers(ModelBuilder modelBuilder)
        {
            #region Players
            #region Manchester United
            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = 1,
                    FirstName = "André",
                    LastName = "Onana",
                    ClubId = 14,
                    Position = "Goalkeeper",
                    Nationality = "Cameroonian",
                    DateOfBirth = new DateOnly(1996, 4, 2),
                    KitNumber = 24,
                    Height = 190
                },
                new Player
                {
                    Id = 2,
                    FirstName = "Altay",
                    LastName = "Bayındır",
                    ClubId = 14,
                    Position = "Goalkeeper",
                    Nationality = "Turkish",
                    DateOfBirth = new DateOnly(1998, 4, 14),
                    KitNumber = 1,
                    Height = 198
                },
                new Player
                {
                    Id = 3,
                    FirstName = "Tom",
                    LastName = "Heaton",
                    ClubId = 14,
                    Position = "Goalkeeper",
                    Nationality = "English",
                    DateOfBirth = new DateOnly(1986, 4, 15),
                    KitNumber = 22,
                    Height = 188
                },
                new Player
                {
                    Id = 4,
                    FirstName = "Lisandro",
                    LastName = "Martínez",
                    ClubId = 14,
                    Position = "Centre-Back",
                    Nationality = "Argentinian",
                    DateOfBirth = new DateOnly(1998, 1, 18),
                    KitNumber = 6,
                    Height = 175
                },
                new Player
                {
                    Id = 5,
                    FirstName = "Raphaël",
                    LastName = "Varane",
                    ClubId = 14,
                    Position = "Centre-Back",
                    Nationality = "French",
                    DateOfBirth = new DateOnly(1993, 4, 25),
                    KitNumber = 19,
                    Height = 191
                },
                new Player
                {
                    Id = 6,
                    FirstName = "Harry",
                    LastName = "Maguire",
                    ClubId = 14,
                    Position = "Centre-Back",
                    Nationality = "English",
                    DateOfBirth = new DateOnly(1993, 3, 5),
                    KitNumber = 5,
                    Height = 194
                },
                new Player
                {
                    Id = 7,
                    FirstName = "Victor",
                    LastName = "Lindelöf",
                    ClubId = 14,
                    Position = "Centre-Back",
                    Nationality = "Swedish",
                    DateOfBirth = new DateOnly(1994, 7, 17),
                    KitNumber = 2,
                    Height = 187
                },
                new Player
                {
                    Id = 8,
                    FirstName = "Willy",
                    LastName = "Kambwala",
                    ClubId = 14,
                    Position = "Centre-Back",
                    Nationality = "French",
                    DateOfBirth = new DateOnly(2005, 8, 25),
                    KitNumber = 54,
                    Height = 190
                },
                new Player
                {
                    Id = 9,
                    FirstName = "Jonny",
                    LastName = "Evans",
                    ClubId = 14,
                    Position = "Centre-Back",
                    Nationality = "Northern Irish",
                    DateOfBirth = new DateOnly(1988, 1, 3),
                    KitNumber = 35,
                    Height = 188
                },
                new Player
                {
                    Id = 10,
                    FirstName = "Luke",
                    LastName = "Shaw",
                    ClubId = 14,
                    Position = "Left-Back",
                    Nationality = "English",
                    DateOfBirth = new DateOnly(1995, 7, 12),
                    KitNumber = 23,
                    Height = 181
                },
                new Player
                {
                    Id = 11,
                    FirstName = "Tyrell",
                    LastName = "Malacia",
                    ClubId = 14,
                    Position = "Left-Back",
                    Nationality = "Dutch",
                    DateOfBirth = new DateOnly(1999, 8, 17),
                    KitNumber = 20,
                    Height = 169
                },
                new Player
                {
                    Id = 12,
                    FirstName = "Diogo",
                    LastName = "Dalot",
                    ClubId = 14,
                    Position = "Right-Back",
                    Nationality = "Portuguese",
                    DateOfBirth = new DateOnly(1999, 3, 18),
                    KitNumber = 20,
                    Height = 183
                },
                new Player
                {
                    Id = 13,
                    FirstName = "Aaron",
                    LastName = "Wan-Bissaka",
                    ClubId = 14,
                    Position = "Right-Back",
                    Nationality = "English",
                    DateOfBirth = new DateOnly(1997, 11, 26),
                    KitNumber = 29,
                    Height = 183
                },
                new Player
                {
                    Id = 14,
                    FirstName = "Scott",
                    LastName = "McTominay",
                    ClubId = 14,
                    Position = "Defensive Midfield",
                    Nationality = "Scottish",
                    DateOfBirth = new DateOnly(1996, 12, 8),
                    KitNumber = 39,
                    Height = 193
                },
                new Player
                {
                    Id = 15,
                    FirstName = "Casemiro",
                    LastName = "",
                    ClubId = 14,
                    Position = "Defensive Midfield",
                    Nationality = "Brazilian",
                    DateOfBirth = new DateOnly(1992, 2, 23),
                    KitNumber = 18,
                    Height = 185
                },
                new Player
                {
                    Id = 16,
                    FirstName = "Sofyan",
                    LastName = "Amrabat",
                    ClubId = 14,
                    Position = "Defensive Midfield",
                    Nationality = "Moroccan",
                    DateOfBirth = new DateOnly(1996, 8, 21),
                    KitNumber = 4,
                    Height = 185
                },
                new Player
                {
                    Id = 17,
                    FirstName = "Kobbie",
                    LastName = "Mainoo",
                    ClubId = 14,
                    Position = "Central Midfield",
                    Nationality = "English",
                    DateOfBirth = new DateOnly(2005, 4, 19),
                    KitNumber = 37,
                    Height = 175
                },
                new Player
                {
                    Id = 18,
                    FirstName = "Christian",
                    LastName = "Eriksen",
                    ClubId = 14,
                    Position = "Central Midfield",
                    Nationality = "Danish",
                    DateOfBirth = new DateOnly(1992, 2, 14),
                    KitNumber = 14,
                    Height = 182
                },
                new Player
                {
                    Id = 19,
                    FirstName = "Bruno",
                    LastName = "Fernandes",
                    ClubId = 14,
                    Position = "Attacking Midfield",
                    Nationality = "Portuguese",
                    DateOfBirth = new DateOnly(1994, 9, 8),
                    KitNumber = 8,
                    Height = 179
                },
                new Player
                {
                    Id = 20,
                    FirstName = "Mason",
                    LastName = "Mount",
                    ClubId = 14,
                    Position = "Attacking Midfield",
                    Nationality = "English",
                    DateOfBirth = new DateOnly(1999, 1, 10),
                    KitNumber = 7,
                    Height = 181
                },
                new Player
                {
                    Id = 21,
                    FirstName = "Marcus",
                    LastName = "Rashford",
                    ClubId = 14,
                    Position = "Left Winger",
                    Nationality = "English",
                    DateOfBirth = new DateOnly(1997, 10, 31),
                    KitNumber = 10,
                    Height = 185
                },
                new Player
                {
                    Id = 22,
                    FirstName = "Alejandro",
                    LastName = "Garnacho",
                    ClubId = 14,
                    Position = "Left Winger",
                    Nationality = "Argentinian",
                    DateOfBirth = new DateOnly(2004, 7, 1),
                    KitNumber = 17,
                    Height = 180
                },
                new Player
                {
                    Id = 23,
                    FirstName = "Antony",
                    LastName = "",
                    ClubId = 14,
                    Position = "Right Winger",
                    Nationality = "Brazilian",
                    DateOfBirth = new DateOnly(2000, 2, 24),
                    KitNumber = 21,
                    Height = 174
                },
                new Player
                {
                    Id = 24,
                    FirstName = "Amad",
                    LastName = "Diallo",
                    ClubId = 14,
                    Position = "Right Winger",
                    Nationality = "Ivorian",
                    DateOfBirth = new DateOnly(2002, 7, 11),
                    KitNumber = 16,
                    Height = 173
                },
                new Player
                {
                    Id = 25,
                    FirstName = "Rasmus",
                    LastName = "Højlund",
                    ClubId = 14,
                    Position = "Centre-Forward",
                    Nationality = "Danish",
                    DateOfBirth = new DateOnly(2003, 2, 4),
                    KitNumber = 11,
                    Height = 191
                },
                new Player
                {
                    Id = 26,
                    FirstName = "Anthony",
                    LastName = "Martial",
                    ClubId = 14,
                    Position = "Centre-Forward",
                    Nationality = "French",
                    DateOfBirth = new DateOnly(1995, 12, 5),
                    KitNumber = 9,
                    Height = 181
                }
            );
            #endregion
            #endregion
        }

    }
}
