using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcWIthAPi.Migrations
{
    public partial class rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Flag",
                table: "Camps",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AverageRating",
                table: "Camps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserCounter",
                table: "Camps",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Camps");

            migrationBuilder.DropColumn(
                name: "UserCounter",
                table: "Camps");

            migrationBuilder.AlterColumn<string>(
                name: "Flag",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
