using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClubId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "CleanSheets", "Drawns", "Goals", "GoalsConceded", "LeaguePoints", "Losses", "MatchesPlayed", "Name", "Wins", "YearFounded" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, 0, 0, 0, 0, "Arsenal", 0, 1886 },
                    { 2, 0, 0, 0, 0, 0, 0, 0, "Aston Villa", 0, 1874 },
                    { 3, 0, 0, 0, 0, 0, 0, 0, "AFC Bournemouth", 0, 1899 },
                    { 4, 0, 0, 0, 0, 0, 0, 0, "Brentford", 0, 1889 },
                    { 5, 0, 0, 0, 0, 0, 0, 0, "Brighton and Hove Albion", 0, 1901 },
                    { 6, 0, 0, 0, 0, 0, 0, 0, "Burnley", 0, 1882 },
                    { 7, 0, 0, 0, 0, 0, 0, 0, "Chelsea", 0, 1905 },
                    { 8, 0, 0, 0, 0, 0, 0, 0, "Crystal Palace", 0, 1905 },
                    { 9, 0, 0, 0, 0, 0, 0, 0, "Everton", 0, 1878 },
                    { 10, 0, 0, 0, 0, 0, 0, 0, "Fulham", 0, 1879 },
                    { 11, 0, 0, 0, 0, 0, 0, 0, "Liverpool", 0, 1892 },
                    { 12, 0, 0, 0, 0, 0, 0, 0, "Luton Town", 0, 1885 },
                    { 13, 0, 0, 0, 0, 0, 0, 0, "Manchester City", 0, 1887 },
                    { 14, 0, 0, 0, 0, 0, 0, 0, "Manchester United", 0, 1878 },
                    { 15, 0, 0, 0, 0, 0, 0, 0, "Newcastle United", 0, 1892 },
                    { 16, 0, 0, 0, 0, 0, 0, 0, "Nottingham Forest", 0, 1865 },
                    { 17, 0, 0, 0, 0, 0, 0, 0, "Sheffield United", 0, 1889 },
                    { 18, 0, 0, 0, 0, 0, 0, 0, "Tottenham Hotspur", 0, 1882 },
                    { 19, 0, 0, 0, 0, 0, 0, 0, "West Ham United", 0, 1895 },
                    { 20, 0, 0, 0, 0, 0, 0, 0, "Wolverhampton Wanderers", 0, 1877 }
                });

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
        }
    }
}
