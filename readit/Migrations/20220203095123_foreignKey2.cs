using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace readit.Migrations
{
    public partial class foreignKey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_General_ForumModelId",
                table: "General");

            migrationBuilder.CreateIndex(
                name: "IX_General_ForumModelId",
                table: "General",
                column: "ForumModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_General_ForumModelId",
                table: "General");

            migrationBuilder.CreateIndex(
                name: "IX_General_ForumModelId",
                table: "General",
                column: "ForumModelId",
                unique: true);
        }
    }
}
