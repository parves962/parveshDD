using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcWIthAPi.Migrations
{
    public partial class kl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Camps",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Campname = table.Column<string>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    Desciption = table.Column<string>(nullable: true),
                    TotalStay = table.Column<int>(nullable: false),
                    Flag = table.Column<string>(nullable: true),
                    Checkin = table.Column<DateTime>(nullable: false),
                    Checkout = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camps", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Camps");
        }
    }
}
