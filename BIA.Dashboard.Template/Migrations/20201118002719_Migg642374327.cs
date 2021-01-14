using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Migg642374327 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Locked",
                table: "PersonnelInformationUser",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Locked",
                table: "PersonnelInformation",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Locked",
                table: "PersonnelInformationUser");

            migrationBuilder.DropColumn(
                name: "Locked",
                table: "PersonnelInformation");
        }
    }
}
