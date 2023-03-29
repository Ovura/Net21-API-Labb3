using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Net21_API_Labb3.Migrations
{
    /// <inheritdoc />
    public partial class Editrelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Websites",
                columns: new[] { "InterestId", "UserId", "WebsiteAddress" },
                values: new object[,]
                {
                    { 2, 1, "www.testing.com" },
                    { 3, 1, "www.tester.com" },
                    { 3, 2, "www.check.net" },
                    { 1, 3, "www.hahaha.net" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumns: new[] { "InterestId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumns: new[] { "InterestId", "UserId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumns: new[] { "InterestId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumns: new[] { "InterestId", "UserId" },
                keyValues: new object[] { 1, 3 });
        }
    }
}
