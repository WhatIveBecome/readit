using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace readit.Migrations
{
    public partial class cleaning2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumListingModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForumListingModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForumModelId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfTopics = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumListingModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumListingModel_Forums_ForumModelId",
                        column: x => x.ForumModelId,
                        principalTable: "Forums",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForumListingModel_ForumModelId",
                table: "ForumListingModel",
                column: "ForumModelId");
        }
    }
}
