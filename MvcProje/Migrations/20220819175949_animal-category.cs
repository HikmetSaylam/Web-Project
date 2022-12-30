using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcProje.Migrations
{
    public partial class animalcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CategoryID",
                table: "Animals",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Categories_CategoryID",
                table: "Animals",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Categories_CategoryID",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_CategoryID",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Animals");
        }
    }
}
