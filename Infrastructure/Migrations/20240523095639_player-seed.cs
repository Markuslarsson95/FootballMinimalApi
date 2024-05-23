using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class playerseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "FirstName", "Height", "KitNumber", "LastName", "Nationality", "Position" },
                values: new object[,]
                {
                    { 1, 14, new DateOnly(1996, 4, 2), "André", 190, 24, "Onana", "Cameroonian", "Goalkeeper" },
                    { 2, 14, new DateOnly(1998, 4, 14), "Altay", 198, 1, "Bayındır", "Turkish", "Goalkeeper" },
                    { 3, 14, new DateOnly(1986, 4, 15), "Tom", 188, 22, "Heaton", "English", "Goalkeeper" },
                    { 4, 14, new DateOnly(1998, 1, 18), "Lisandro", 175, 6, "Martínez", "Argentinian", "Centre-Back" },
                    { 5, 14, new DateOnly(1993, 4, 25), "Raphaël", 191, 19, "Varane", "French", "Centre-Back" },
                    { 6, 14, new DateOnly(1993, 3, 5), "Harry", 194, 5, "Maguire", "English", "Centre-Back" },
                    { 7, 14, new DateOnly(1994, 7, 17), "Victor", 187, 2, "Lindelöf", "Swedish", "Centre-Back" },
                    { 8, 14, new DateOnly(2005, 8, 25), "Willy", 190, 54, "Kambwala", "French", "Centre-Back" },
                    { 9, 14, new DateOnly(1988, 1, 3), "Jonny", 188, 35, "Evans", "Northern Irish", "Centre-Back" },
                    { 10, 14, new DateOnly(1995, 7, 12), "Luke", 181, 23, "Shaw", "English", "Left-Back" },
                    { 11, 14, new DateOnly(1999, 8, 17), "Tyrell", 169, 20, "Malacia", "Dutch", "Left-Back" },
                    { 12, 14, new DateOnly(1999, 3, 18), "Diogo", 183, 20, "Dalot", "Portuguese", "Right-Back" },
                    { 13, 14, new DateOnly(1997, 11, 26), "Aaron", 183, 29, "Wan-Bissaka", "English", "Right-Back" },
                    { 14, 14, new DateOnly(1996, 12, 8), "Scott", 193, 39, "McTominay", "Scottish", "Defensive Midfield" },
                    { 15, 14, new DateOnly(1992, 2, 23), "Casemiro", 185, 18, "", "Brazilian", "Defensive Midfield" },
                    { 16, 14, new DateOnly(1996, 8, 21), "Sofyan", 185, 4, "Amrabat", "Moroccan", "Defensive Midfield" },
                    { 17, 14, new DateOnly(2005, 4, 19), "Kobbie", 175, 37, "Mainoo", "English", "Central Midfield" },
                    { 18, 14, new DateOnly(1992, 2, 14), "Christian", 182, 14, "Eriksen", "Danish", "Central Midfield" },
                    { 19, 14, new DateOnly(1994, 9, 8), "Bruno", 179, 8, "Fernandes", "Portuguese", "Attacking Midfield" },
                    { 20, 14, new DateOnly(1999, 1, 10), "Mason", 181, 7, "Mount", "English", "Attacking Midfield" },
                    { 21, 14, new DateOnly(1997, 10, 31), "Marcus", 185, 10, "Rashford", "English", "Left Winger" },
                    { 22, 14, new DateOnly(2004, 7, 1), "Alejandro", 180, 17, "Garnacho", "Argentinian", "Left Winger" },
                    { 23, 14, new DateOnly(2000, 2, 24), "Antony", 174, 21, "", "Brazilian", "Right Winger" },
                    { 24, 14, new DateOnly(2002, 7, 11), "Amad", 173, 16, "Diallo", "Ivorian", "Right Winger" },
                    { 25, 14, new DateOnly(2003, 2, 4), "Rasmus", 191, 11, "Højlund", "Danish", "Centre-Forward" },
                    { 26, 14, new DateOnly(1995, 12, 5), "Anthony", 181, 9, "Martial", "French", "Centre-Forward" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26);
        }
    }
}
