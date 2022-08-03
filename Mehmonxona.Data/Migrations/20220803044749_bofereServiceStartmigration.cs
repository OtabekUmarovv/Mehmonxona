using Microsoft.EntityFrameworkCore.Migrations;

namespace Mehmonxona.Data.Migrations
{
    public partial class bofereServiceStartmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemState",
                table: "Rooms",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ItemState",
                table: "Payments",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ItemState",
                table: "Orders",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ItemState",
                table: "Employees",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ItemState",
                table: "EmployeeConferences",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ItemState",
                table: "Conferences",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ItemState",
                table: "Clients",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ItemState",
                table: "ClientConferences",
                newName: "State");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "Rooms",
                newName: "ItemState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Payments",
                newName: "ItemState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Orders",
                newName: "ItemState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Employees",
                newName: "ItemState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "EmployeeConferences",
                newName: "ItemState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Conferences",
                newName: "ItemState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Clients",
                newName: "ItemState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "ClientConferences",
                newName: "ItemState");
        }
    }
}
