using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFIntroPD422.Migrations
{
    /// <inheritdoc />
    public partial class updateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientFlight_Passengers_ClientsId",
                table: "ClientFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.RenameTable(
                name: "Passengers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "FirstName",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FirstName",
                table: "FirstName",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFlight_FirstName_ClientsId",
                table: "ClientFlight",
                column: "ClientsId",
                principalTable: "FirstName",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientFlight_FirstName_ClientsId",
                table: "ClientFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FirstName",
                table: "FirstName");

            migrationBuilder.RenameTable(
                name: "FirstName",
                newName: "Passengers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Passengers",
                newName: "FirstName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFlight_Passengers_ClientsId",
                table: "ClientFlight",
                column: "ClientsId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
