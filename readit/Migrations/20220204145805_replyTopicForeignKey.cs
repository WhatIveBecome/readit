using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace readit.Migrations
{
    public partial class replyTopicForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Forums_ForumModelId",
                table: "Replies");

            migrationBuilder.RenameColumn(
                name: "ForumModelId",
                table: "Replies",
                newName: "TopicModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_ForumModelId",
                table: "Replies",
                newName: "IX_Replies_TopicModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Topics_TopicModelId",
                table: "Replies",
                column: "TopicModelId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Topics_TopicModelId",
                table: "Replies");

            migrationBuilder.RenameColumn(
                name: "TopicModelId",
                table: "Replies",
                newName: "ForumModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_TopicModelId",
                table: "Replies",
                newName: "IX_Replies_ForumModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Forums_ForumModelId",
                table: "Replies",
                column: "ForumModelId",
                principalTable: "Forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
