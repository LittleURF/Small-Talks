using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallTalks.Data.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CurrentBanId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "BannedById",
                table: "Bans",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CurrentBanId",
                table: "AspNetUsers",
                column: "CurrentBanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CurrentBanId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BannedById",
                table: "Bans");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CurrentBanId",
                table: "AspNetUsers",
                column: "CurrentBanId",
                unique: true,
                filter: "[CurrentBanId] IS NOT NULL");
        }
    }
}
