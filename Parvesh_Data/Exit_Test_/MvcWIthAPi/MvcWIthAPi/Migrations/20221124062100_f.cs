using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcWIthAPi.Migrations
{
    public partial class f : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "AverageRating",
                table: "Camps",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AverageRating",
                table: "Camps",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
