using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStore.Migrations
{
    public partial class AddShippedField2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OrderShipped",
                table: "Purchases",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderShipped",
                table: "Purchases");
        }
    }
}
