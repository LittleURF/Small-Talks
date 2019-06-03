using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallTalks.Data.Migrations
{
    public partial class Changingnameofparentcomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChildComments_Comments_CommentId",
                table: "ChildComments");

            migrationBuilder.DropColumn(
                name: "ParentCommentId",
                table: "ChildComments");

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "ChildComments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChildComments_Comments_CommentId",
                table: "ChildComments",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChildComments_Comments_CommentId",
                table: "ChildComments");

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "ChildComments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ParentCommentId",
                table: "ChildComments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ChildComments_Comments_CommentId",
                table: "ChildComments",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
