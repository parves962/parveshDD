using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcWIthAPi.Migrations
{
    public partial class u : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OverallRating",
                table: "Camps",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OverallRating",
                table: "Camps");
        }
    }
}
