using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcProje.Migrations
{
    public partial class addusermail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserMail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserMail",
                table: "Users");
        }
    }
}
