using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3_CodeFirst.Migrations
{
    public partial class UpdateEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Calisanlar",
                newName: "Unvan");

            migrationBuilder.AlterColumn<string>(
                name: "Unvan",
                table: "Calisanlar",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Unvan",
                table: "Calisanlar",
                newName: "Title");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Calisanlar",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
