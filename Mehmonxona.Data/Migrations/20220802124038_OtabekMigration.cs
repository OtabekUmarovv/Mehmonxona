using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mehmonxona.Data.Migrations
{
    public partial class OtabekMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sign",
                table: "Rooms",
                type: "character varying(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rooms",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 347, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 346, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 345, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Employees",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 344, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmployeeConferences",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 342, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Conferences",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 341, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clients",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 337, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ClientConferences",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 340, DateTimeKind.Utc).AddTicks(3911));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sign",
                table: "Rooms",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rooms",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 347, DateTimeKind.Utc).AddTicks(8050),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 346, DateTimeKind.Utc).AddTicks(9030),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 345, DateTimeKind.Utc).AddTicks(9137),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Employees",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 344, DateTimeKind.Utc).AddTicks(2531),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmployeeConferences",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 342, DateTimeKind.Utc).AddTicks(6543),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Conferences",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 341, DateTimeKind.Utc).AddTicks(3381),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clients",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 337, DateTimeKind.Utc).AddTicks(2166),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ClientConferences",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 2, 12, 40, 38, 340, DateTimeKind.Utc).AddTicks(3911),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);
        }
    }
}
