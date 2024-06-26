﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stadiums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    YearBuilt = table.Column<int>(type: "int", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadiums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StadiumId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaguePoints = table.Column<int>(type: "int", nullable: false),
                    MatchesPlayed = table.Column<int>(type: "int", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Losses = table.Column<int>(type: "int", nullable: false),
                    Drawns = table.Column<int>(type: "int", nullable: false),
                    Goals = table.Column<int>(type: "int", nullable: false),
                    GoalsConceded = table.Column<int>(type: "int", nullable: false),
                    CleanSheets = table.Column<int>(type: "int", nullable: false),
                    YearFounded = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubs_Stadiums_StadiumId",
                        column: x => x.StadiumId,
                        principalTable: "Stadiums",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClubId = table.Column<int>(type: "int", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    KitNumber = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Adress", "Capacity", "Location", "Name", "YearBuilt" },
                values: new object[,]
                {
                    { 1, "Highbury House, 75 Drayton Park, London, N5 1BU", 60704, "London", "Emirates Stadium", 2006 },
                    { 2, "Villa Park, Trinity Road, Birmingham, B6 6HE", 42530, "Birmingham", "Villa Park", 1897 },
                    { 3, "Vitality Stadium, Dean Court, Bournemouth, BH7 7AF", 11307, "Bournemouth", "Vitality Stadium", 1910 },
                    { 4, "Gtech Community Stadium, Lionel Road South, Brentford, TW8 0RU", 17250, "Brentford", "Gtech Community Stadium", 2000 },
                    { 5, "American Express Community Stadium, Village Way, Brighton, BN1 9BL", 31876, "Falmer", "American Express Stadium", 2011 },
                    { 6, "Turf Moor, Harry Potts Way, Burnley, Lancashire, BB10 4BX", 21944, "Burnley", "Turf Moor", 1883 },
                    { 7, "Stamford Bridge, Fulham Road, London, SW6 1HS", 40343, "London", "Stamford Bridge", 1877 },
                    { 8, "Selhurst Park Stadium, Holmesdale Road, London, SE25 6PU", 25486, "London", "Selhurst Park", 1924 },
                    { 9, "Goodison Park, Goodison Road, Liverpool, L4 4EL", 39414, "Liverpool", "Goodison Park", 1892 },
                    { 10, "Stevenage Road, London, SW6 6HH", 24500, "London", "Craven Cottage", 1896 },
                    { 11, "Anfield, Anfield Road, Liverpool, L4 0TH", 61276, "Liverpool", "Anfield", 1884 },
                    { 12, "Kenilworth Road Stadium, 1 Maple Road, Luton, LU4 8AW", 10265, "Luton", "Kenilworth Road", 1905 },
                    { 13, "Etihad Stadium, Etihad Campus, Manchester, M11 3FF", 53400, "Manchester", "Etihad Stadium", 2002 },
                    { 14, "Sir Matt Busby Way, Old Trafford, Manchester, M16 0RA", 74310, "Manchester", "Old Trafford", 1909 },
                    { 15, "St. James' Park, Newcastle Upon Tyne, NE1 4ST", 52305, "Newcastle", "St. James' Park", 1892 },
                    { 16, "Nottingham Forest Football Club, The City Ground, Pavilion Road, West Bridgford, Nottingham, NG2 5FJ", 30404, "Nottingham", "The City Ground", 1898 },
                    { 17, "Bramall Lane, Sheffield, South Yorkshire, S2 4SU", 32050, "Sheffield", "Bramall Lane", 1855 },
                    { 18, "Lilywhite House, 782 High Road, Tottenham, London, N17 0BX", 62850, "London", "Tottenham Hotspur Stadium", 2019 },
                    { 19, "London Stadium, Queen Elizabeth Olympic Park, London, E20 2ST", 62500, "London", "London Stadium", 2011 },
                    { 20, "Molineux Stadium, Waterloo Rd, Wolverhampton, WV1 4QR", 31750, "Wolverhampton", "Molineux Stadium", 1889 }
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "CleanSheets", "Drawns", "Goals", "GoalsConceded", "LeaguePoints", "Losses", "MatchesPlayed", "Name", "StadiumId", "Wins", "YearFounded" },
                values: new object[,]
                {
                    { 1, 0, 5, 91, 29, 89, 5, 38, "Arsenal", 1, 28, 1886 },
                    { 2, 0, 8, 76, 61, 68, 10, 38, "Aston Villa", 2, 20, 1874 },
                    { 3, 0, 9, 54, 67, 48, 17, 38, "AFC Bournemouth", 3, 12, 1899 },
                    { 4, 0, 9, 56, 65, 40, 18, 38, "Brentford", 4, 11, 1889 },
                    { 5, 0, 10, 55, 62, 48, 16, 38, "Brighton and Hove Albion", 5, 12, 1901 },
                    { 6, 0, 6, 41, 78, 26, 25, 38, "Burnley", 6, 7, 1882 },
                    { 7, 0, 9, 77, 63, 63, 11, 38, "Chelsea", 7, 18, 1905 },
                    { 8, 0, 10, 57, 58, 49, 15, 38, "Crystal Palace", 8, 13, 1905 },
                    { 9, 0, 10, 48, 59, 40, 18, 38, "Everton", 9, 10, 1878 },
                    { 10, 0, 7, 55, 61, 47, 18, 38, "Fulham", 10, 13, 1879 },
                    { 11, 0, 10, 86, 41, 82, 4, 38, "Liverpool", 11, 24, 1892 },
                    { 12, 0, 5, 42, 75, 33, 24, 38, "Luton Town", 12, 9, 1885 },
                    { 13, 0, 7, 96, 34, 91, 3, 38, "Manchester City", 13, 28, 1887 },
                    { 14, 0, 6, 57, 58, 60, 14, 38, "Manchester United", 14, 18, 1878 },
                    { 15, 0, 7, 85, 62, 60, 14, 38, "Newcastle United", 15, 17, 1892 },
                    { 16, 0, 8, 42, 60, 32, 22, 38, "Nottingham Forest", 16, 8, 1865 },
                    { 17, 0, 7, 35, 104, 16, 28, 38, "Sheffield United", 17, 3, 1889 },
                    { 18, 0, 6, 74, 61, 66, 12, 38, "Tottenham Hotspur", 18, 20, 1882 },
                    { 19, 0, 10, 74, 74, 52, 14, 38, "West Ham United", 19, 14, 1895 },
                    { 20, 0, 8, 50, 65, 46, 17, 38, "Wolverhampton Wanderers", 20, 13, 1877 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_StadiumId",
                table: "Clubs",
                column: "StadiumId",
                unique: true,
                filter: "[StadiumId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Players_ClubId",
                table: "Players",
                column: "ClubId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Stadiums");
        }
    }
}
