using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3_CodeFirst.Migrations
{
    public partial class OrderAndCustomerAndEmployeeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalisanId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MusteriId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_CalisanId",
                table: "Order",
                column: "CalisanId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_MusteriId",
                table: "Order",
                column: "MusteriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Calisanlar_CalisanId",
                table: "Order",
                column: "CalisanId",
                principalTable: "Calisanlar",
                principalColumn: "EmpID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_MusteriId",
                table: "Order",
                column: "MusteriId",
                principalTable: "Customer",
                principalColumn: "CustId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Calisanlar_CalisanId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_MusteriId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CalisanId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_MusteriId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CalisanId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "MusteriId",
                table: "Order");
        }
    }
}
