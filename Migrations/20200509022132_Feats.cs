using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDCharacterCreator.Migrations
{
    public partial class Feats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Feats",
                table: "Character",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9fc0063a-ba45-4e40-bc55-e51750d256ee", "AQAAAAEAACcQAAAAEIwzgax92dq9kvkA01AT7eYAhfpxl/zGqTypW+qImPKjWaxVxMxWLc8zUOW1GLWNTQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Feats",
                table: "Character");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "154f3c58-2e1c-40ca-a83e-f2fc9731407a", "AQAAAAEAACcQAAAAED9uc7GRQQjnlJqP2LWo1JD20exfl3yrBmYoMTvomL3nM5MKhOuCKUkU6kCp9tmhIA==" });
        }
    }
}
