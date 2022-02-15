using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace readit.Migrations
{
    public partial class NumberOfTopics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NoTopics",
                table: "Forums",
                newName: "NumberOfTopics");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfTopics",
                table: "Forums",
                newName: "NoTopics");
        }
    }
}
