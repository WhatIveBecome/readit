using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace readit.Migrations
{
    public partial class replyForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ForumModelId",
                table: "Replies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Replies_ForumModelId",
                table: "Replies",
                column: "ForumModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Forums_ForumModelId",
                table: "Replies",
                column: "ForumModelId",
                principalTable: "Forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Forums_ForumModelId",
                table: "Replies");

            migrationBuilder.DropIndex(
                name: "IX_Replies_ForumModelId",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "ForumModelId",
                table: "Replies");
        }
    }
}
