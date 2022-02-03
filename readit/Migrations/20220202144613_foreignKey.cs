using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace readit.Migrations
{
    public partial class foreignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ForumModelId",
                table: "General",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_General_ForumModelId",
                table: "General",
                column: "ForumModelId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_General_Forums_ForumModelId",
                table: "General",
                column: "ForumModelId",
                principalTable: "Forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_General_Forums_ForumModelId",
                table: "General");

            migrationBuilder.DropIndex(
                name: "IX_General_ForumModelId",
                table: "General");

            migrationBuilder.DropColumn(
                name: "ForumModelId",
                table: "General");
        }
    }
}
