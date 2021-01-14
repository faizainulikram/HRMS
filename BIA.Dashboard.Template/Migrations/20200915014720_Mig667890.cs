using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Mig667890 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_ProfessionalQualification_PersonnelInformationUser_PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification");

            migrationBuilder.DropIndex(
                name: "IX_ProfessionalQualification_PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification");

            migrationBuilder.DropIndex(
                name: "IX_FamilyInformation_PersonnelInformationUserPersonnelId",
                table: "FamilyInformation");

            migrationBuilder.DropIndex(
                name: "IX_EmergencyContact_PersonnelInformationUserPersonnelId",
                table: "EmergencyContact");

            migrationBuilder.DropIndex(
                name: "IX_EducationDetail_PersonnelInformationUserPersonnelId",
                table: "EducationDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileOnDatabaseMode",
                table: "FileOnDatabaseMode");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationUserPersonnelId",
                table: "FamilyInformation");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationUserPersonnelId",
                table: "EmergencyContact");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationUserPersonnelId",
                table: "EducationDetail");

            migrationBuilder.RenameTable(
                name: "FileOnDatabaseMode",
                newName: "FileOnDatabaseModel");

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "PersonnelInformationUser",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "PersonnelInformationUser",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationUserId",
                table: "FileOnFileSystemModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationUserId",
                table: "FileOnDatabaseModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileOnDatabaseModel",
                table: "FileOnDatabaseModel",
                column: "FileAttachmentId");

            migrationBuilder.CreateTable(
                name: "EducationDetailUser",
                columns: table => new
                {
                    EducationDetailUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Education = table.Column<string>(nullable: true),
                    Institution = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    PersonnelInformationUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDetailUser", x => x.EducationDetailUserId);
                    table.ForeignKey(
                        name: "FK_EducationDetailUser_PersonnelInformationUser_PersonnelInformationUserId",
                        column: x => x.PersonnelInformationUserId,
                        principalTable: "PersonnelInformationUser",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContactUser",
                columns: table => new
                {
                    EmergencyContactUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Relationship = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    PersonnelInformationUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContactUser", x => x.EmergencyContactUserId);
                    table.ForeignKey(
                        name: "FK_EmergencyContactUser_PersonnelInformationUser_PersonnelInformationUserId",
                        column: x => x.PersonnelInformationUserId,
                        principalTable: "PersonnelInformationUser",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyInformationUser",
                columns: table => new
                {
                    FamilyInformationUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IdentityCardNumber = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Employer = table.Column<string>(nullable: true),
                    Relationship = table.Column<string>(nullable: true),
                    PersonnelInformationUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyInformationUser", x => x.FamilyInformationUserId);
                    table.ForeignKey(
                        name: "FK_FamilyInformationUser_PersonnelInformationUser_PersonnelInformationUserId",
                        column: x => x.PersonnelInformationUserId,
                        principalTable: "PersonnelInformationUser",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalQualificationUser",
                columns: table => new
                {
                    ProfessionalQualificationUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    PersonnelInformationUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalQualificationUser", x => x.ProfessionalQualificationUserId);
                    table.ForeignKey(
                        name: "FK_ProfessionalQualificationUser_PersonnelInformationUser_PersonnelInformationUserId",
                        column: x => x.PersonnelInformationUserId,
                        principalTable: "PersonnelInformationUser",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetailUser_PersonnelInformationUserId",
                table: "EducationDetailUser",
                column: "PersonnelInformationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContactUser_PersonnelInformationUserId",
                table: "EmergencyContactUser",
                column: "PersonnelInformationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInformationUser_PersonnelInformationUserId",
                table: "FamilyInformationUser",
                column: "PersonnelInformationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalQualificationUser_PersonnelInformationUserId",
                table: "ProfessionalQualificationUser",
                column: "PersonnelInformationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationDetailUser");

            migrationBuilder.DropTable(
                name: "EmergencyContactUser");

            migrationBuilder.DropTable(
                name: "FamilyInformationUser");

            migrationBuilder.DropTable(
                name: "ProfessionalQualificationUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileOnDatabaseModel",
                table: "FileOnDatabaseModel");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "PersonnelInformationUser");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "PersonnelInformationUser");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationUserId",
                table: "FileOnFileSystemModel");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationUserId",
                table: "FileOnDatabaseModel");

            migrationBuilder.RenameTable(
                name: "FileOnDatabaseModel",
                newName: "FileOnDatabaseMode");

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationUserPersonnelId",
                table: "FamilyInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationUserPersonnelId",
                table: "EmergencyContact",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationUserPersonnelId",
                table: "EducationDetail",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileOnDatabaseMode",
                table: "FileOnDatabaseMode",
                column: "FileAttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalQualification_PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification",
                column: "PersonnelInformationUserPersonnelId");

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
                name: "FK_ProfessionalQualification_PersonnelInformationUser_PersonnelInformationUserPersonnelId",
                table: "ProfessionalQualification",
                column: "PersonnelInformationUserPersonnelId",
                principalTable: "PersonnelInformationUser",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
