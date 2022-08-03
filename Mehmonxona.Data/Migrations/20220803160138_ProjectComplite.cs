using Microsoft.EntityFrameworkCore.Migrations;

namespace Mehmonxona.Data.Migrations
{
    public partial class ProjectComplite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Conferences",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Conferences");
        }
    }
}
