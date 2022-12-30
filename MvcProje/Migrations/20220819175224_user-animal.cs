using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcProje.Migrations
{
    public partial class useranimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_UserID",
                table: "Animals",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Users_UserID",
                table: "Animals",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Users_UserID",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_UserID",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Animals");
        }
    }
}
