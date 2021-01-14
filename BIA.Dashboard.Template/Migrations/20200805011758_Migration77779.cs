using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Migration77779 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentGroup",
                table: "PersonnelInformation");

            migrationBuilder.DropColumn(
                name: "JobGrade",
                table: "PersonnelInformation");

            migrationBuilder.AddColumn<string>(
                name: "GlobalGrade",
                table: "PersonnelInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "PersonnelInformation",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EducationDetail",
                columns: table => new
                {
                    EducationDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Education = table.Column<string>(nullable: true),
                    Institution = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    PersonnelInformationPersonnelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDetail", x => x.EducationDetailId);
                    table.ForeignKey(
                        name: "FK_EducationDetail_PersonnelInformation_PersonnelInformationPersonnelId",
                        column: x => x.PersonnelInformationPersonnelId,
                        principalTable: "PersonnelInformation",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalQualification",
                columns: table => new
                {
                    ProfessionalQualificationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    PersonnelInformationPersonnelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalQualification", x => x.ProfessionalQualificationId);
                    table.ForeignKey(
                        name: "FK_ProfessionalQualification_PersonnelInformation_PersonnelInformationPersonnelId",
                        column: x => x.PersonnelInformationPersonnelId,
                        principalTable: "PersonnelInformation",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetail_PersonnelInformationPersonnelId",
                table: "EducationDetail",
                column: "PersonnelInformationPersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalQualification_PersonnelInformationPersonnelId",
                table: "ProfessionalQualification",
                column: "PersonnelInformationPersonnelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationDetail");

            migrationBuilder.DropTable(
                name: "ProfessionalQualification");

            migrationBuilder.DropColumn(
                name: "GlobalGrade",
                table: "PersonnelInformation");

            migrationBuilder.DropColumn(
                name: "Group",
                table: "PersonnelInformation");

            migrationBuilder.AddColumn<string>(
                name: "CurrentGroup",
                table: "PersonnelInformation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobGrade",
                table: "PersonnelInformation",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
