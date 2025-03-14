using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFIntroPD422.Migrations
{
    /// <inheritdoc />
    public partial class total : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "Id", "MaxPassengers", "Model" },
                values: new object[,]
                {
                    { 1, 140, "Boeng 747" },
                    { 2, 130, "Airbus A320" },
                    { 3, 120, "Boeng 737" },
                    { 4, 150, "Airbus A380" }
                });

            migrationBuilder.InsertData(
                table: "FirstName",
                columns: new[] { "Id", "Birthdate", "Email", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(1998, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "oleg@gmail.com", "Oleg" },
                    { 5, new DateTime(2000, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "olena@gmail.com", "Olena" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AirplaneId", "ArrivalCity", "ArrivalTime", "DepartureCity", "DepartureTime", "Rating" },
                values: new object[,]
                {
                    { 1, 1, "Lviv", new DateTime(2021, 10, 10, 12, 10, 10, 0, DateTimeKind.Unspecified), "Kyiv", new DateTime(2021, 10, 10, 10, 10, 10, 0, DateTimeKind.Unspecified), 4.5 },
                    { 2, 2, "Kyiv", new DateTime(2021, 10, 11, 13, 11, 11, 0, DateTimeKind.Unspecified), "Lviv", new DateTime(2021, 10, 11, 11, 11, 11, 0, DateTimeKind.Unspecified), 4.0 },
                    { 3, 3, "Odesa", new DateTime(2021, 10, 12, 14, 12, 12, 0, DateTimeKind.Unspecified), "Kyiv", new DateTime(2021, 10, 12, 12, 12, 12, 0, DateTimeKind.Unspecified), 4.2999999999999998 },
                    { 4, 4, "Kyiv", new DateTime(2021, 10, 13, 15, 13, 13, 0, DateTimeKind.Unspecified), "Odesa", new DateTime(2021, 10, 13, 13, 13, 13, 0, DateTimeKind.Unspecified), 4.7000000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FirstName",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FirstName",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
