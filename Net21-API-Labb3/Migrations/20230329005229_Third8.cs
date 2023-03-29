using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net21_API_Labb3.Migrations
{
    /// <inheritdoc />
    public partial class Third8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Websites",
                table: "Websites");

            migrationBuilder.DropIndex(
                name: "IX_Websites_UserId",
                table: "Websites");

            migrationBuilder.DropColumn(
                name: "WebsiteId",
                table: "Websites");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Websites",
                table: "Websites",
                columns: new[] { "UserId", "InterestId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Websites",
                table: "Websites");

            migrationBuilder.AddColumn<int>(
                name: "WebsiteId",
                table: "Websites",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Websites",
                table: "Websites",
                column: "WebsiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Websites_UserId",
                table: "Websites",
                column: "UserId");
        }
    }
}
