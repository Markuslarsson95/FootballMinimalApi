﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(FootballDbContext))]
    [Migration("20240523095639_player-seed")]
    partial class playerseed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApp.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CleanSheets")
                        .HasColumnType("int");

                    b.Property<int>("Drawns")
                        .HasColumnType("int");

                    b.Property<int>("Goals")
                        .HasColumnType("int");

                    b.Property<int>("GoalsConceded")
                        .HasColumnType("int");

                    b.Property<int>("LeaguePoints")
                        .HasColumnType("int");

                    b.Property<int>("Losses")
                        .HasColumnType("int");

                    b.Property<int>("MatchesPlayed")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StadiumId")
                        .HasColumnType("int");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.Property<int>("YearFounded")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StadiumId")
                        .IsUnique()
                        .HasFilter("[StadiumId] IS NOT NULL");

                    b.ToTable("Clubs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CleanSheets = 0,
                            Drawns = 5,
                            Goals = 91,
                            GoalsConceded = 29,
                            LeaguePoints = 89,
                            Losses = 5,
                            MatchesPlayed = 38,
                            Name = "Arsenal",
                            StadiumId = 1,
                            Wins = 28,
                            YearFounded = 1886
                        },
                        new
                        {
                            Id = 2,
                            CleanSheets = 0,
                            Drawns = 8,
                            Goals = 76,
                            GoalsConceded = 61,
                            LeaguePoints = 68,
                            Losses = 10,
                            MatchesPlayed = 38,
                            Name = "Aston Villa",
                            StadiumId = 2,
                            Wins = 20,
                            YearFounded = 1874
                        },
                        new
                        {
                            Id = 3,
                            CleanSheets = 0,
                            Drawns = 9,
                            Goals = 54,
                            GoalsConceded = 67,
                            LeaguePoints = 48,
                            Losses = 17,
                            MatchesPlayed = 38,
                            Name = "AFC Bournemouth",
                            StadiumId = 3,
                            Wins = 12,
                            YearFounded = 1899
                        },
                        new
                        {
                            Id = 4,
                            CleanSheets = 0,
                            Drawns = 9,
                            Goals = 56,
                            GoalsConceded = 65,
                            LeaguePoints = 40,
                            Losses = 18,
                            MatchesPlayed = 38,
                            Name = "Brentford",
                            StadiumId = 4,
                            Wins = 11,
                            YearFounded = 1889
                        },
                        new
                        {
                            Id = 5,
                            CleanSheets = 0,
                            Drawns = 10,
                            Goals = 55,
                            GoalsConceded = 62,
                            LeaguePoints = 48,
                            Losses = 16,
                            MatchesPlayed = 38,
                            Name = "Brighton and Hove Albion",
                            StadiumId = 5,
                            Wins = 12,
                            YearFounded = 1901
                        },
                        new
                        {
                            Id = 6,
                            CleanSheets = 0,
                            Drawns = 6,
                            Goals = 41,
                            GoalsConceded = 78,
                            LeaguePoints = 26,
                            Losses = 25,
                            MatchesPlayed = 38,
                            Name = "Burnley",
                            StadiumId = 6,
                            Wins = 7,
                            YearFounded = 1882
                        },
                        new
                        {
                            Id = 7,
                            CleanSheets = 0,
                            Drawns = 9,
                            Goals = 77,
                            GoalsConceded = 63,
                            LeaguePoints = 63,
                            Losses = 11,
                            MatchesPlayed = 38,
                            Name = "Chelsea",
                            StadiumId = 7,
                            Wins = 18,
                            YearFounded = 1905
                        },
                        new
                        {
                            Id = 8,
                            CleanSheets = 0,
                            Drawns = 10,
                            Goals = 57,
                            GoalsConceded = 58,
                            LeaguePoints = 49,
                            Losses = 15,
                            MatchesPlayed = 38,
                            Name = "Crystal Palace",
                            StadiumId = 8,
                            Wins = 13,
                            YearFounded = 1905
                        },
                        new
                        {
                            Id = 9,
                            CleanSheets = 0,
                            Drawns = 10,
                            Goals = 48,
                            GoalsConceded = 59,
                            LeaguePoints = 40,
                            Losses = 18,
                            MatchesPlayed = 38,
                            Name = "Everton",
                            StadiumId = 9,
                            Wins = 10,
                            YearFounded = 1878
                        },
                        new
                        {
                            Id = 10,
                            CleanSheets = 0,
                            Drawns = 7,
                            Goals = 55,
                            GoalsConceded = 61,
                            LeaguePoints = 47,
                            Losses = 18,
                            MatchesPlayed = 38,
                            Name = "Fulham",
                            StadiumId = 10,
                            Wins = 13,
                            YearFounded = 1879
                        },
                        new
                        {
                            Id = 11,
                            CleanSheets = 0,
                            Drawns = 10,
                            Goals = 86,
                            GoalsConceded = 41,
                            LeaguePoints = 82,
                            Losses = 4,
                            MatchesPlayed = 38,
                            Name = "Liverpool",
                            StadiumId = 11,
                            Wins = 24,
                            YearFounded = 1892
                        },
                        new
                        {
                            Id = 12,
                            CleanSheets = 0,
                            Drawns = 5,
                            Goals = 42,
                            GoalsConceded = 75,
                            LeaguePoints = 33,
                            Losses = 24,
                            MatchesPlayed = 38,
                            Name = "Luton Town",
                            StadiumId = 12,
                            Wins = 9,
                            YearFounded = 1885
                        },
                        new
                        {
                            Id = 13,
                            CleanSheets = 0,
                            Drawns = 7,
                            Goals = 96,
                            GoalsConceded = 34,
                            LeaguePoints = 91,
                            Losses = 3,
                            MatchesPlayed = 38,
                            Name = "Manchester City",
                            StadiumId = 13,
                            Wins = 28,
                            YearFounded = 1887
                        },
                        new
                        {
                            Id = 14,
                            CleanSheets = 0,
                            Drawns = 6,
                            Goals = 57,
                            GoalsConceded = 58,
                            LeaguePoints = 60,
                            Losses = 14,
                            MatchesPlayed = 38,
                            Name = "Manchester United",
                            StadiumId = 14,
                            Wins = 18,
                            YearFounded = 1878
                        },
                        new
                        {
                            Id = 15,
                            CleanSheets = 0,
                            Drawns = 7,
                            Goals = 85,
                            GoalsConceded = 62,
                            LeaguePoints = 60,
                            Losses = 14,
                            MatchesPlayed = 38,
                            Name = "Newcastle United",
                            StadiumId = 15,
                            Wins = 17,
                            YearFounded = 1892
                        },
                        new
                        {
                            Id = 16,
                            CleanSheets = 0,
                            Drawns = 8,
                            Goals = 42,
                            GoalsConceded = 60,
                            LeaguePoints = 32,
                            Losses = 22,
                            MatchesPlayed = 38,
                            Name = "Nottingham Forest",
                            StadiumId = 16,
                            Wins = 8,
                            YearFounded = 1865
                        },
                        new
                        {
                            Id = 17,
                            CleanSheets = 0,
                            Drawns = 7,
                            Goals = 35,
                            GoalsConceded = 104,
                            LeaguePoints = 16,
                            Losses = 28,
                            MatchesPlayed = 38,
                            Name = "Sheffield United",
                            StadiumId = 17,
                            Wins = 3,
                            YearFounded = 1889
                        },
                        new
                        {
                            Id = 18,
                            CleanSheets = 0,
                            Drawns = 6,
                            Goals = 74,
                            GoalsConceded = 61,
                            LeaguePoints = 66,
                            Losses = 12,
                            MatchesPlayed = 38,
                            Name = "Tottenham Hotspur",
                            StadiumId = 18,
                            Wins = 20,
                            YearFounded = 1882
                        },
                        new
                        {
                            Id = 19,
                            CleanSheets = 0,
                            Drawns = 10,
                            Goals = 74,
                            GoalsConceded = 74,
                            LeaguePoints = 52,
                            Losses = 14,
                            MatchesPlayed = 38,
                            Name = "West Ham United",
                            StadiumId = 19,
                            Wins = 14,
                            YearFounded = 1895
                        },
                        new
                        {
                            Id = 20,
                            CleanSheets = 0,
                            Drawns = 8,
                            Goals = 50,
                            GoalsConceded = 65,
                            LeaguePoints = 46,
                            Losses = 17,
                            MatchesPlayed = 38,
                            Name = "Wolverhampton Wanderers",
                            StadiumId = 20,
                            Wins = 13,
                            YearFounded = 1877
                        });
                });

            modelBuilder.Entity("WebApp.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("KitNumber")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1996, 4, 2),
                            FirstName = "André",
                            Height = 190,
                            KitNumber = 24,
                            LastName = "Onana",
                            Nationality = "Cameroonian",
                            Position = "Goalkeeper"
                        },
                        new
                        {
                            Id = 2,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1998, 4, 14),
                            FirstName = "Altay",
                            Height = 198,
                            KitNumber = 1,
                            LastName = "Bayındır",
                            Nationality = "Turkish",
                            Position = "Goalkeeper"
                        },
                        new
                        {
                            Id = 3,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1986, 4, 15),
                            FirstName = "Tom",
                            Height = 188,
                            KitNumber = 22,
                            LastName = "Heaton",
                            Nationality = "English",
                            Position = "Goalkeeper"
                        },
                        new
                        {
                            Id = 4,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1998, 1, 18),
                            FirstName = "Lisandro",
                            Height = 175,
                            KitNumber = 6,
                            LastName = "Martínez",
                            Nationality = "Argentinian",
                            Position = "Centre-Back"
                        },
                        new
                        {
                            Id = 5,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1993, 4, 25),
                            FirstName = "Raphaël",
                            Height = 191,
                            KitNumber = 19,
                            LastName = "Varane",
                            Nationality = "French",
                            Position = "Centre-Back"
                        },
                        new
                        {
                            Id = 6,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1993, 3, 5),
                            FirstName = "Harry",
                            Height = 194,
                            KitNumber = 5,
                            LastName = "Maguire",
                            Nationality = "English",
                            Position = "Centre-Back"
                        },
                        new
                        {
                            Id = 7,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1994, 7, 17),
                            FirstName = "Victor",
                            Height = 187,
                            KitNumber = 2,
                            LastName = "Lindelöf",
                            Nationality = "Swedish",
                            Position = "Centre-Back"
                        },
                        new
                        {
                            Id = 8,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(2005, 8, 25),
                            FirstName = "Willy",
                            Height = 190,
                            KitNumber = 54,
                            LastName = "Kambwala",
                            Nationality = "French",
                            Position = "Centre-Back"
                        },
                        new
                        {
                            Id = 9,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1988, 1, 3),
                            FirstName = "Jonny",
                            Height = 188,
                            KitNumber = 35,
                            LastName = "Evans",
                            Nationality = "Northern Irish",
                            Position = "Centre-Back"
                        },
                        new
                        {
                            Id = 10,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1995, 7, 12),
                            FirstName = "Luke",
                            Height = 181,
                            KitNumber = 23,
                            LastName = "Shaw",
                            Nationality = "English",
                            Position = "Left-Back"
                        },
                        new
                        {
                            Id = 11,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1999, 8, 17),
                            FirstName = "Tyrell",
                            Height = 169,
                            KitNumber = 20,
                            LastName = "Malacia",
                            Nationality = "Dutch",
                            Position = "Left-Back"
                        },
                        new
                        {
                            Id = 12,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1999, 3, 18),
                            FirstName = "Diogo",
                            Height = 183,
                            KitNumber = 20,
                            LastName = "Dalot",
                            Nationality = "Portuguese",
                            Position = "Right-Back"
                        },
                        new
                        {
                            Id = 13,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1997, 11, 26),
                            FirstName = "Aaron",
                            Height = 183,
                            KitNumber = 29,
                            LastName = "Wan-Bissaka",
                            Nationality = "English",
                            Position = "Right-Back"
                        },
                        new
                        {
                            Id = 14,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1996, 12, 8),
                            FirstName = "Scott",
                            Height = 193,
                            KitNumber = 39,
                            LastName = "McTominay",
                            Nationality = "Scottish",
                            Position = "Defensive Midfield"
                        },
                        new
                        {
                            Id = 15,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1992, 2, 23),
                            FirstName = "Casemiro",
                            Height = 185,
                            KitNumber = 18,
                            LastName = "",
                            Nationality = "Brazilian",
                            Position = "Defensive Midfield"
                        },
                        new
                        {
                            Id = 16,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1996, 8, 21),
                            FirstName = "Sofyan",
                            Height = 185,
                            KitNumber = 4,
                            LastName = "Amrabat",
                            Nationality = "Moroccan",
                            Position = "Defensive Midfield"
                        },
                        new
                        {
                            Id = 17,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(2005, 4, 19),
                            FirstName = "Kobbie",
                            Height = 175,
                            KitNumber = 37,
                            LastName = "Mainoo",
                            Nationality = "English",
                            Position = "Central Midfield"
                        },
                        new
                        {
                            Id = 18,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1992, 2, 14),
                            FirstName = "Christian",
                            Height = 182,
                            KitNumber = 14,
                            LastName = "Eriksen",
                            Nationality = "Danish",
                            Position = "Central Midfield"
                        },
                        new
                        {
                            Id = 19,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1994, 9, 8),
                            FirstName = "Bruno",
                            Height = 179,
                            KitNumber = 8,
                            LastName = "Fernandes",
                            Nationality = "Portuguese",
                            Position = "Attacking Midfield"
                        },
                        new
                        {
                            Id = 20,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1999, 1, 10),
                            FirstName = "Mason",
                            Height = 181,
                            KitNumber = 7,
                            LastName = "Mount",
                            Nationality = "English",
                            Position = "Attacking Midfield"
                        },
                        new
                        {
                            Id = 21,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1997, 10, 31),
                            FirstName = "Marcus",
                            Height = 185,
                            KitNumber = 10,
                            LastName = "Rashford",
                            Nationality = "English",
                            Position = "Left Winger"
                        },
                        new
                        {
                            Id = 22,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(2004, 7, 1),
                            FirstName = "Alejandro",
                            Height = 180,
                            KitNumber = 17,
                            LastName = "Garnacho",
                            Nationality = "Argentinian",
                            Position = "Left Winger"
                        },
                        new
                        {
                            Id = 23,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(2000, 2, 24),
                            FirstName = "Antony",
                            Height = 174,
                            KitNumber = 21,
                            LastName = "",
                            Nationality = "Brazilian",
                            Position = "Right Winger"
                        },
                        new
                        {
                            Id = 24,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(2002, 7, 11),
                            FirstName = "Amad",
                            Height = 173,
                            KitNumber = 16,
                            LastName = "Diallo",
                            Nationality = "Ivorian",
                            Position = "Right Winger"
                        },
                        new
                        {
                            Id = 25,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(2003, 2, 4),
                            FirstName = "Rasmus",
                            Height = 191,
                            KitNumber = 11,
                            LastName = "Højlund",
                            Nationality = "Danish",
                            Position = "Centre-Forward"
                        },
                        new
                        {
                            Id = 26,
                            ClubId = 14,
                            DateOfBirth = new DateOnly(1995, 12, 5),
                            FirstName = "Anthony",
                            Height = 181,
                            KitNumber = 9,
                            LastName = "Martial",
                            Nationality = "French",
                            Position = "Centre-Forward"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearBuilt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stadiums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "Highbury House, 75 Drayton Park, London, N5 1BU",
                            Capacity = 60704,
                            Location = "London",
                            Name = "Emirates Stadium",
                            YearBuilt = 2006
                        },
                        new
                        {
                            Id = 2,
                            Adress = "Villa Park, Trinity Road, Birmingham, B6 6HE",
                            Capacity = 42530,
                            Location = "Birmingham",
                            Name = "Villa Park",
                            YearBuilt = 1897
                        },
                        new
                        {
                            Id = 3,
                            Adress = "Vitality Stadium, Dean Court, Bournemouth, BH7 7AF",
                            Capacity = 11307,
                            Location = "Bournemouth",
                            Name = "Vitality Stadium",
                            YearBuilt = 1910
                        },
                        new
                        {
                            Id = 4,
                            Adress = "Gtech Community Stadium, Lionel Road South, Brentford, TW8 0RU",
                            Capacity = 17250,
                            Location = "Brentford",
                            Name = "Gtech Community Stadium",
                            YearBuilt = 2000
                        },
                        new
                        {
                            Id = 5,
                            Adress = "American Express Community Stadium, Village Way, Brighton, BN1 9BL",
                            Capacity = 31876,
                            Location = "Falmer",
                            Name = "American Express Stadium",
                            YearBuilt = 2011
                        },
                        new
                        {
                            Id = 6,
                            Adress = "Turf Moor, Harry Potts Way, Burnley, Lancashire, BB10 4BX",
                            Capacity = 21944,
                            Location = "Burnley",
                            Name = "Turf Moor",
                            YearBuilt = 1883
                        },
                        new
                        {
                            Id = 7,
                            Adress = "Stamford Bridge, Fulham Road, London, SW6 1HS",
                            Capacity = 40343,
                            Location = "London",
                            Name = "Stamford Bridge",
                            YearBuilt = 1877
                        },
                        new
                        {
                            Id = 8,
                            Adress = "Selhurst Park Stadium, Holmesdale Road, London, SE25 6PU",
                            Capacity = 25486,
                            Location = "London",
                            Name = "Selhurst Park",
                            YearBuilt = 1924
                        },
                        new
                        {
                            Id = 9,
                            Adress = "Goodison Park, Goodison Road, Liverpool, L4 4EL",
                            Capacity = 39414,
                            Location = "Liverpool",
                            Name = "Goodison Park",
                            YearBuilt = 1892
                        },
                        new
                        {
                            Id = 10,
                            Adress = "Stevenage Road, London, SW6 6HH",
                            Capacity = 24500,
                            Location = "London",
                            Name = "Craven Cottage",
                            YearBuilt = 1896
                        },
                        new
                        {
                            Id = 11,
                            Adress = "Anfield, Anfield Road, Liverpool, L4 0TH",
                            Capacity = 61276,
                            Location = "Liverpool",
                            Name = "Anfield",
                            YearBuilt = 1884
                        },
                        new
                        {
                            Id = 12,
                            Adress = "Kenilworth Road Stadium, 1 Maple Road, Luton, LU4 8AW",
                            Capacity = 10265,
                            Location = "Luton",
                            Name = "Kenilworth Road",
                            YearBuilt = 1905
                        },
                        new
                        {
                            Id = 13,
                            Adress = "Etihad Stadium, Etihad Campus, Manchester, M11 3FF",
                            Capacity = 53400,
                            Location = "Manchester",
                            Name = "Etihad Stadium",
                            YearBuilt = 2002
                        },
                        new
                        {
                            Id = 14,
                            Adress = "Sir Matt Busby Way, Old Trafford, Manchester, M16 0RA",
                            Capacity = 74310,
                            Location = "Manchester",
                            Name = "Old Trafford",
                            YearBuilt = 1909
                        },
                        new
                        {
                            Id = 15,
                            Adress = "St. James' Park, Newcastle Upon Tyne, NE1 4ST",
                            Capacity = 52305,
                            Location = "Newcastle",
                            Name = "St. James' Park",
                            YearBuilt = 1892
                        },
                        new
                        {
                            Id = 16,
                            Adress = "Nottingham Forest Football Club, The City Ground, Pavilion Road, West Bridgford, Nottingham, NG2 5FJ",
                            Capacity = 30404,
                            Location = "Nottingham",
                            Name = "The City Ground",
                            YearBuilt = 1898
                        },
                        new
                        {
                            Id = 17,
                            Adress = "Bramall Lane, Sheffield, South Yorkshire, S2 4SU",
                            Capacity = 32050,
                            Location = "Sheffield",
                            Name = "Bramall Lane",
                            YearBuilt = 1855
                        },
                        new
                        {
                            Id = 18,
                            Adress = "Lilywhite House, 782 High Road, Tottenham, London, N17 0BX",
                            Capacity = 62850,
                            Location = "London",
                            Name = "Tottenham Hotspur Stadium",
                            YearBuilt = 2019
                        },
                        new
                        {
                            Id = 19,
                            Adress = "London Stadium, Queen Elizabeth Olympic Park, London, E20 2ST",
                            Capacity = 62500,
                            Location = "London",
                            Name = "London Stadium",
                            YearBuilt = 2011
                        },
                        new
                        {
                            Id = 20,
                            Adress = "Molineux Stadium, Waterloo Rd, Wolverhampton, WV1 4QR",
                            Capacity = 31750,
                            Location = "Wolverhampton",
                            Name = "Molineux Stadium",
                            YearBuilt = 1889
                        });
                });

            modelBuilder.Entity("WebApp.Models.Club", b =>
                {
                    b.HasOne("WebApp.Models.Stadium", "Stadium")
                        .WithOne("Club")
                        .HasForeignKey("WebApp.Models.Club", "StadiumId");

                    b.Navigation("Stadium");
                });

            modelBuilder.Entity("WebApp.Models.Player", b =>
                {
                    b.HasOne("WebApp.Models.Club", "Club")
                        .WithMany("Players")
                        .HasForeignKey("ClubId");

                    b.Navigation("Club");
                });

            modelBuilder.Entity("WebApp.Models.Club", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("WebApp.Models.Stadium", b =>
                {
                    b.Navigation("Club");
                });
#pragma warning restore 612, 618
        }
    }
}
