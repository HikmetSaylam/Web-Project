using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcProje.Migrations
{
    public partial class create_databasee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Abouts_AboutId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_AboutId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Animals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Animals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AboutId",
                table: "Animals",
                column: "AboutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Abouts_AboutId",
                table: "Animals",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "AboutId");
        }
    }
}
