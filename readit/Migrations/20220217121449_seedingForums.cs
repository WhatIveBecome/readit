using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace readit.Migrations
{
    public partial class seedingForums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Description", "Name", "NumberOfTopics" },
                values: new object[,]
                {
                    { 2, "Forum inteded for the C programming language", "C", 0 },
                    { 3, "Forum inteded for the C++ programming language", "C++", 0 },
                    { 4, "Forum inteded for the C# programming language", "C#", 0 },
                    { 5, "Forum inteded for the HyperText Markup Language", "HTML", 0 },
                    { 6, "Forum inteded for the Cascading Style Sheets", "CSS", 0 },
                    { 7, "Forum inteded for the JavaScript programming language", "JS", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
