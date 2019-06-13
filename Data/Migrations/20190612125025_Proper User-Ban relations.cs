using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallTalks.Data.Migrations
{
    public partial class ProperUserBanrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Bans_CurrentBanId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CurrentBanId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Bans",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BannedById",
                table: "Bans",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bans_BannedById",
                table: "Bans",
                column: "BannedById");

            migrationBuilder.CreateIndex(
                name: "IX_Bans_UserId",
                table: "Bans",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bans_AspNetUsers_BannedById",
                table: "Bans",
                column: "BannedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bans_AspNetUsers_UserId",
                table: "Bans",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bans_AspNetUsers_BannedById",
                table: "Bans");

            migrationBuilder.DropForeignKey(
                name: "FK_Bans_AspNetUsers_UserId",
                table: "Bans");

            migrationBuilder.DropIndex(
                name: "IX_Bans_BannedById",
                table: "Bans");

            migrationBuilder.DropIndex(
                name: "IX_Bans_UserId",
                table: "Bans");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Bans",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BannedById",
                table: "Bans",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CurrentBanId",
                table: "AspNetUsers",
                column: "CurrentBanId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Bans_CurrentBanId",
                table: "AspNetUsers",
                column: "CurrentBanId",
                principalTable: "Bans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
