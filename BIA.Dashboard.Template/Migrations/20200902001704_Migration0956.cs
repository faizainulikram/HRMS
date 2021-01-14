using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Migration0956 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PersonnelInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtensionNumber",
                table: "PersonnelInformation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonnelInformationId",
                table: "AspNetUsers",
                column: "PersonnelInformationId",
                unique: true,
                filter: "[PersonnelInformationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PersonnelInformation_PersonnelInformationId",
                table: "AspNetUsers",
                column: "PersonnelInformationId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PersonnelInformation_PersonnelInformationId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonnelInformationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PersonnelInformation");

            migrationBuilder.DropColumn(
                name: "ExtensionNumber",
                table: "PersonnelInformation");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
