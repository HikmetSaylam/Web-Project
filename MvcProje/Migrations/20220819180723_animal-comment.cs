using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcProje.Migrations
{
    public partial class animalcomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AnimalID",
                table: "Comments",
                column: "AnimalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Animals_AnimalID",
                table: "Comments",
                column: "AnimalID",
                principalTable: "Animals",
                principalColumn: "AnimalID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Animals_AnimalID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AnimalID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AnimalID",
                table: "Comments");
        }
    }
}
