using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ComCh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "eventmodelId",
                table: "Comment",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_eventmodelId",
                table: "Comment",
                column: "eventmodelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Event_eventmodelId",
                table: "Comment",
                column: "eventmodelId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Event_eventmodelId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_eventmodelId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "eventmodelId",
                table: "Comment");
        }
    }
}
