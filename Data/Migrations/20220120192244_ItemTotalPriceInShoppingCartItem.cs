using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ItemTotalPriceInShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ItemTotalPrice",
                table: "ShoppingCartItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemTotalPrice",
                table: "ShoppingCartItems");
        }
    }
}
