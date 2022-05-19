using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleBlogID",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleBlogID",
                table: "Comments",
                column: "ArticleBlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Articles_ArticleBlogID",
                table: "Comments",
                column: "ArticleBlogID",
                principalTable: "Articles",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Articles_ArticleBlogID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ArticleBlogID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ArticleBlogID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Comments");
        }
    }
}
