using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ShoppingCartItemChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Categories_CategoryId",
                table: "ShoppingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Suppliers_SupplierId",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_CategoryId",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_SupplierId",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "ShoppingCartItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CategoryId",
                table: "ShoppingCartItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_SupplierId",
                table: "ShoppingCartItems",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Categories_CategoryId",
                table: "ShoppingCartItems",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Suppliers_SupplierId",
                table: "ShoppingCartItems",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
