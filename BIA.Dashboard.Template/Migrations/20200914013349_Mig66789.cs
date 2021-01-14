using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Mig66789 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PersonnelInformation_PersonnelInformationId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonnelInformationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "PersonnelInformation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationUserPersonnelId",
                table: "FamilyInformation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationUserPersonnelId",
                table: "EmergencyContact",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationUserPersonnelId",
                table: "EducationDetail",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PersonnelInformationUser",
                columns: table => new
                {
                    PersonnelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileImageName = table.Column<string>(nullable: true),
                    PersonnelNumber = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IdentityCardNumber = table.Column<string>(nullable: true),
                    IdentityCardColor = table.Column<string>(nullable: true),
                    Race = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    HomeNumber = table.Column<string>(maxLength: 15, nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    EmploymentStatus = table.Column<string>(nullable: true),
                    ReportingDate = table.Column<DateTime>(nullable: true),
                    ConfirmedDate = table.Column<DateTime>(nullable: true),
                    ServiceDuration = table.Column<string>(nullable: true),
                    PositionReportingDate = table.Column<DateTime>(nullable: true),
                    DepartmentReportingDate = table.Column<DateTime>(nullable: true),
                    MandatoryRetirementDate = table.Column<DateTime>(nullable: true),
                    CurrentPosition = table.Column<string>(nullable: true),
                    GlobalGrade = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    Division = table.Column<string>(nullable: true),
                    ExtensionNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    HealthDeclarationId = table.Column<int>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelInformationUser", x => x.PersonnelId);
                    table.ForeignKey(
                        name: "FK_PersonnelInformationUser_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonnelInformationUser_HealthDeclaration_HealthDeclarationId",
                        column: x => x.HealthDeclarationId,
                        principalTable: "HealthDeclaration",
                        principalColumn: "HealthDeclarationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalQualification_PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification",
                column: "PersonnelInformationUserPersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelInformation_ApplicationUserId",
                table: "PersonnelInformation",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInformation_PersonnelInformationUserPersonnelId",
                table: "FamilyInformation",
                column: "PersonnelInformationUserPersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContact_PersonnelInformationUserPersonnelId",
                table: "EmergencyContact",
                column: "PersonnelInformationUserPersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetail_PersonnelInformationUserPersonnelId",
                table: "EducationDetail",
                column: "PersonnelInformationUserPersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelInformationUser_ApplicationUserId",
                table: "PersonnelInformationUser",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelInformationUser_HealthDeclarationId",
                table: "PersonnelInformationUser",
                column: "HealthDeclarationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDetail_PersonnelInformationUser_PersonnelInformationUserPersonnelId",
                table: "EducationDetail",
                column: "PersonnelInformationUserPersonnelId",
                principalTable: "PersonnelInformationUser",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmergencyContact_PersonnelInformationUser_PersonnelInformationUserPersonnelId",
                table: "EmergencyContact",
                column: "PersonnelInformationUserPersonnelId",
                principalTable: "PersonnelInformationUser",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyInformation_PersonnelInformationUser_PersonnelInformationUserPersonnelId",
                table: "FamilyInformation",
                column: "PersonnelInformationUserPersonnelId",
                principalTable: "PersonnelInformationUser",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelInformation_AspNetUsers_ApplicationUserId",
                table: "PersonnelInformation",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalQualification_PersonnelInformationUser_PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification",
                column: "PersonnelInformationUserPersonnelId",
                principalTable: "PersonnelInformationUser",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationDetail_PersonnelInformationUser_PersonnelInformationUserPersonnelId",
                table: "EducationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_EmergencyContact_PersonnelInformationUser_PersonnelInformationUserPersonnelId",
                table: "EmergencyContact");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInformation_PersonnelInformationUser_PersonnelInformationUserPersonnelId",
                table: "FamilyInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelInformation_AspNetUsers_ApplicationUserId",
                table: "PersonnelInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalQualification_PersonnelInformationUser_PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification");

            migrationBuilder.DropTable(
                name: "PersonnelInformationUser");

            migrationBuilder.DropIndex(
                name: "IX_ProfessionalQualification_PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification");

            migrationBuilder.DropIndex(
                name: "IX_PersonnelInformation_ApplicationUserId",
                table: "PersonnelInformation");

            migrationBuilder.DropIndex(
                name: "IX_FamilyInformation_PersonnelInformationUserPersonnelId",
                table: "FamilyInformation");

            migrationBuilder.DropIndex(
                name: "IX_EmergencyContact_PersonnelInformationUserPersonnelId",
                table: "EmergencyContact");

            migrationBuilder.DropIndex(
                name: "IX_EducationDetail_PersonnelInformationUserPersonnelId",
                table: "EducationDetail");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "PersonnelInformation");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationUserPersonnelId",
                table: "FamilyInformation");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationUserPersonnelId",
                table: "EmergencyContact");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationUserPersonnelId",
                table: "EducationDetail");

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationId",
                table: "AspNetUsers",
                type: "int",
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
    }
}
