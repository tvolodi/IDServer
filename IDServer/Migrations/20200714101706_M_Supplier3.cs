using Microsoft.EntityFrameworkCore.Migrations;

namespace IDServer.Migrations
{
    public partial class M_Supplier3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Suppliers");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Suppliers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Suppliers");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Suppliers",
                type: "text",
                nullable: true);
        }
    }
}
