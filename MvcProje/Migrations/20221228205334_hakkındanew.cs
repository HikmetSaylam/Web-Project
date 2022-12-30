using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcProje.Migrations
{
    public partial class hakkındanew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutStatus",
                table: "Abouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AboutStatus",
                table: "Abouts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
