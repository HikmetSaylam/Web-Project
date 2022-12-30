using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcProje.Migrations
{
    public partial class database_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Categories_CategoryID1",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Users_UserID1",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Animals_AnimalID1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AnimalID1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Animals_CategoryID1",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_UserID1",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "AnimalID1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CategoryID1",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "Animals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalID1",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID1",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID1",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AnimalID1",
                table: "Comments",
                column: "AnimalID1");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CategoryID1",
                table: "Animals",
                column: "CategoryID1");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_UserID1",
                table: "Animals",
                column: "UserID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Categories_CategoryID1",
                table: "Animals",
                column: "CategoryID1",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Users_UserID1",
                table: "Animals",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Animals_AnimalID1",
                table: "Comments",
                column: "AnimalID1",
                principalTable: "Animals",
                principalColumn: "AnimalID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
