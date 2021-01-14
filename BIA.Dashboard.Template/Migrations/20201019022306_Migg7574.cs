using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Migg7574 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonnelInformationAuditLog",
                columns: table => new
                {
                    PersonnelInformationAuditLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true),
                    PersonnelInformationId = table.Column<string>(nullable: true),
                    PersonnelInformationPersonnelId = table.Column<int>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    StatusDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelInformationAuditLog", x => x.PersonnelInformationAuditLogId);
                    table.ForeignKey(
                        name: "FK_PersonnelInformationAuditLog_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonnelInformationAuditLog_PersonnelInformation_PersonnelInformationPersonnelId",
                        column: x => x.PersonnelInformationPersonnelId,
                        principalTable: "PersonnelInformation",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelInformationAuditLog_ApplicationUserId",
                table: "PersonnelInformationAuditLog",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelInformationAuditLog_PersonnelInformationPersonnelId",
                table: "PersonnelInformationAuditLog",
                column: "PersonnelInformationPersonnelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonnelInformationAuditLog");
        }
    }
}
