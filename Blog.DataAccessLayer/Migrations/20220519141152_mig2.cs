using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryID",
                table: "Articles",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Catogries_CategoryID",
                table: "Articles",
                column: "CategoryID",
                principalTable: "Catogries",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Catogries_CategoryID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategoryID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Articles");
        }
    }
}
