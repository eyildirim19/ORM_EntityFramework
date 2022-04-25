using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3_CodeFirst.Migrations
{
    public partial class UpdateCategoryAndShipTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Shipp",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Shipp",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Shipp");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Shipp");

            migrationBuilder.DropColumn(
                name: "CreDate",
                table: "Categories");
        }
    }
}
