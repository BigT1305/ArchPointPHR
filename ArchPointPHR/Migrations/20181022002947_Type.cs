using Microsoft.EntityFrameworkCore.Migrations;

namespace ArchPointPHR.Migrations
{
    public partial class Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Medication",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Medication");
        }
    }
}
