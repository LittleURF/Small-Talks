using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallTalks.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {



            migrationBuilder.DropColumn(
                name: "BannedById",
                table: "Bans");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentBanId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CurrentBanId",
                table: "AspNetUsers",
                column: "CurrentBanId",
                unique: true,
                filter: "[CurrentBanId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Bans_CurrentBanId",
                table: "AspNetUsers",
                column: "CurrentBanId",
                principalTable: "Bans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Bans_CurrentBanId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CurrentBanId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "BannedById",
                table: "Bans",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrentBanId",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
