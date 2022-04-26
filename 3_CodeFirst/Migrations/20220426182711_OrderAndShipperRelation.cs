using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3_CodeFirst.Migrations
{
    public partial class OrderAndShipperRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShipTo",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShipTo",
                table: "Order",
                column: "ShipTo");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Shipp_ShipTo",
                table: "Order",
                column: "ShipTo",
                principalTable: "Shipp",
                principalColumn: "ShipperId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Shipp_ShipTo",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ShipTo",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ShipTo",
                table: "Order");
        }
    }
}
