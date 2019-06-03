using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallTalks.Data.Migrations
{
    public partial class ModifyingCommentsDBStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsParentComment",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ParentCommentId",
                table: "Comments");

            migrationBuilder.CreateTable(
                name: "ChildComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatorId = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false),
                    ParentCommentId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CommentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChildComments_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChildComments_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChildComments_CommentId",
                table: "ChildComments",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_ChildComments_CreatorId",
                table: "ChildComments",
                column: "CreatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildComments");

            migrationBuilder.AddColumn<bool>(
                name: "IsParentComment",
                table: "Comments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ParentCommentId",
                table: "Comments",
                nullable: true);
        }
    }
}
