using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Migg7574a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelInformationAuditLog_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "PersonnelInformationAuditLog");

            migrationBuilder.DropIndex(
                name: "IX_PersonnelInformationAuditLog_PersonnelInformationPersonnelId",
                table: "PersonnelInformationAuditLog");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationPersonnelId",
                table: "PersonnelInformationAuditLog");

            migrationBuilder.AlterColumn<int>(
                name: "PersonnelInformationId",
                table: "PersonnelInformationAuditLog",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelInformationAuditLog_PersonnelInformationId",
                table: "PersonnelInformationAuditLog",
                column: "PersonnelInformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelInformationAuditLog_PersonnelInformation_PersonnelInformationId",
                table: "PersonnelInformationAuditLog",
                column: "PersonnelInformationId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelInformationAuditLog_PersonnelInformation_PersonnelInformationId",
                table: "PersonnelInformationAuditLog");

            migrationBuilder.DropIndex(
                name: "IX_PersonnelInformationAuditLog_PersonnelInformationId",
                table: "PersonnelInformationAuditLog");

            migrationBuilder.AlterColumn<string>(
                name: "PersonnelInformationId",
                table: "PersonnelInformationAuditLog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationPersonnelId",
                table: "PersonnelInformationAuditLog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelInformationAuditLog_PersonnelInformationPersonnelId",
                table: "PersonnelInformationAuditLog",
                column: "PersonnelInformationPersonnelId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelInformationAuditLog_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "PersonnelInformationAuditLog",
                column: "PersonnelInformationPersonnelId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
