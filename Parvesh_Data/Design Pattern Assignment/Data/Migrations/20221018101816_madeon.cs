using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class madeon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Comment_EventId",
                table: "Comment",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Event_EventId",
                table: "Comment",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Event_EventId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_EventId",
                table: "Comment");

            migrationBuilder.AddColumn<int>(
                name: "eventmodelId",
                table: "Comment",
                type: "int",
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
    }
}
