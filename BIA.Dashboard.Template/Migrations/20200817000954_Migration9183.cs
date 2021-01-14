using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Migration9183 : Migration
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
                name: "FK_HealthDeclaration_PersonnelInformation_PersonnelInformationRef",
                table: "HealthDeclaration");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalQualification_PersonnelInformation_PersonnelInformationPersonnelId",
                table: "ProfessionalQualification");

            migrationBuilder.DropIndex(
                name: "IX_ProfessionalQualification_PersonnelInformationPersonnelId",
                table: "ProfessionalQualification");

            migrationBuilder.DropIndex(
                name: "IX_HealthDeclaration_PersonnelInformationRef",
                table: "HealthDeclaration");

            migrationBuilder.DropIndex(
                name: "IX_FamilyInformation_PersonnelInformationPersonnelId",
                table: "FamilyInformation");

            migrationBuilder.DropIndex(
                name: "IX_EmergencyContact_PersonnelInformationPersonnelId",
                table: "EmergencyContact");

            migrationBuilder.DropIndex(
                name: "IX_EducationDetail_PersonnelInformationPersonnelId",
                table: "EducationDetail");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationPersonnelId",
                table: "ProfessionalQualification");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationRef",
                table: "HealthDeclaration");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationPersonnelId",
                table: "FamilyInformation");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationPersonnelId",
                table: "EmergencyContact");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationPersonnelId",
                table: "EducationDetail");

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationId",
                table: "ProfessionalQualification",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationId",
                table: "HealthDeclaration",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationId",
                table: "FamilyInformation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationId",
                table: "EmergencyContact",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationId",
                table: "EducationDetail",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalQualification_PersonnelInformationId",
                table: "ProfessionalQualification",
                column: "PersonnelInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthDeclaration_PersonnelInformationId",
                table: "HealthDeclaration",
                column: "PersonnelInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInformation_PersonnelInformationId",
                table: "FamilyInformation",
                column: "PersonnelInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContact_PersonnelInformationId",
                table: "EmergencyContact",
                column: "PersonnelInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetail_PersonnelInformationId",
                table: "EducationDetail",
                column: "PersonnelInformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDetail_PersonnelInformation_PersonnelInformationId",
                table: "EducationDetail",
                column: "PersonnelInformationId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmergencyContact_PersonnelInformation_PersonnelInformationId",
                table: "EmergencyContact",
                column: "PersonnelInformationId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyInformation_PersonnelInformation_PersonnelInformationId",
                table: "FamilyInformation",
                column: "PersonnelInformationId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthDeclaration_PersonnelInformation_PersonnelInformationId",
                table: "HealthDeclaration",
                column: "PersonnelInformationId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalQualification_PersonnelInformation_PersonnelInformationId",
                table: "ProfessionalQualification",
                column: "PersonnelInformationId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationDetail_PersonnelInformation_PersonnelInformationId",
                table: "EducationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_EmergencyContact_PersonnelInformation_PersonnelInformationId",
                table: "EmergencyContact");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInformation_PersonnelInformation_PersonnelInformationId",
                table: "FamilyInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthDeclaration_PersonnelInformation_PersonnelInformationId",
                table: "HealthDeclaration");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalQualification_PersonnelInformation_PersonnelInformationId",
                table: "ProfessionalQualification");

            migrationBuilder.DropIndex(
                name: "IX_ProfessionalQualification_PersonnelInformationId",
                table: "ProfessionalQualification");

            migrationBuilder.DropIndex(
                name: "IX_HealthDeclaration_PersonnelInformationId",
                table: "HealthDeclaration");

            migrationBuilder.DropIndex(
                name: "IX_FamilyInformation_PersonnelInformationId",
                table: "FamilyInformation");

            migrationBuilder.DropIndex(
                name: "IX_EmergencyContact_PersonnelInformationId",
                table: "EmergencyContact");

            migrationBuilder.DropIndex(
                name: "IX_EducationDetail_PersonnelInformationId",
                table: "EducationDetail");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationId",
                table: "ProfessionalQualification");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationId",
                table: "HealthDeclaration");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationId",
                table: "FamilyInformation");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationId",
                table: "EmergencyContact");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationId",
                table: "EducationDetail");

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationPersonnelId",
                table: "ProfessionalQualification",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationRef",
                table: "HealthDeclaration",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationPersonnelId",
                table: "FamilyInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationPersonnelId",
                table: "EmergencyContact",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationPersonnelId",
                table: "EducationDetail",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalQualification_PersonnelInformationPersonnelId",
                table: "ProfessionalQualification",
                column: "PersonnelInformationPersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthDeclaration_PersonnelInformationRef",
                table: "HealthDeclaration",
                column: "PersonnelInformationRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInformation_PersonnelInformationPersonnelId",
                table: "FamilyInformation",
                column: "PersonnelInformationPersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContact_PersonnelInformationPersonnelId",
                table: "EmergencyContact",
                column: "PersonnelInformationPersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetail_PersonnelInformationPersonnelId",
                table: "EducationDetail",
                column: "PersonnelInformationPersonnelId");

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
                name: "FK_HealthDeclaration_PersonnelInformation_PersonnelInformationRef",
                table: "HealthDeclaration",
                column: "PersonnelInformationRef",
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
    }
}
