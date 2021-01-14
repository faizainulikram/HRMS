using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Migration689 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationDetail_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "EducationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_EmergencyContact_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "EmergencyContact");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInformation_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "FamilyInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalQualification_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "ProfessionalQualification");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDetail_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "EducationDetail",
                column: "PersonnelInformationPersonnelId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmergencyContact_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "EmergencyContact",
                column: "PersonnelInformationPersonnelId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyInformation_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "FamilyInformation",
                column: "PersonnelInformationPersonnelId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalQualification_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "ProfessionalQualification",
                column: "PersonnelInformationPersonnelId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationDetail_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "EducationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_EmergencyContact_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "EmergencyContact");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInformation_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "FamilyInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalQualification_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "ProfessionalQualification");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDetail_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "EducationDetail",
                column: "PersonnelInformationPersonnelId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmergencyContact_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "EmergencyContact",
                column: "PersonnelInformationPersonnelId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyInformation_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "FamilyInformation",
                column: "PersonnelInformationPersonnelId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalQualification_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "ProfessionalQualification",
                column: "PersonnelInformationPersonnelId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
