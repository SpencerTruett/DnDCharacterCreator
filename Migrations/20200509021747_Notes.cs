using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDCharacterCreator.Migrations
{
    public partial class Notes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Character",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "154f3c58-2e1c-40ca-a83e-f2fc9731407a", "AQAAAAEAACcQAAAAED9uc7GRQQjnlJqP2LWo1JD20exfl3yrBmYoMTvomL3nM5MKhOuCKUkU6kCp9tmhIA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Character");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "583203bc-9b18-48ad-84a0-2f501d4197b8", "AQAAAAEAACcQAAAAEHGvpjJkWdzdQ/dGVN22xvtAQ6GvvK5SHiAHFAZH9X7MHgf/23yT3oVAMMrhiPI4vQ==" });
        }
    }
}
