using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallTalks.Data.Migrations
{
    public partial class ModifiedUserandBanmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Bans");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Bans");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Bans_CurrentBanId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CurrentBanId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Bans",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Bans",
                nullable: true);
        }
    }
}
