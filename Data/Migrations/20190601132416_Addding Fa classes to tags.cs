using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallTalks.Data.Migrations
{
    public partial class AdddingFaclassestotags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_CreatorId",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "FaClasses",
                table: "Tags",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatorId",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_CreatorId",
                table: "Posts",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_CreatorId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "FaClasses",
                table: "Tags");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatorId",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_CreatorId",
                table: "Posts",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
