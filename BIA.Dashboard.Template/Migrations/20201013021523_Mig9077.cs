using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Mig9077 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelInformationUser_AspNetUsers_ApplicationUserId",
                table: "PersonnelInformationUser");

            migrationBuilder.AddColumn<int>(
                name: "PersonnelInformationId",
                table: "PayrollAdvice",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PayrollBankBranch",
                columns: table => new
                {
                    PayrollBankBranchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bank = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    Branch = table.Column<string>(nullable: true),
                    BranchName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollBankBranch", x => x.PayrollBankBranchId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PayrollAdvice_PersonnelInformationId",
                table: "PayrollAdvice",
                column: "PersonnelInformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_PayrollAdvice_PersonnelInformation_PersonnelInformationId",
                table: "PayrollAdvice",
                column: "PersonnelInformationId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelInformationUser_AspNetUsers_ApplicationUserId",
                table: "PersonnelInformationUser",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayrollAdvice_PersonnelInformation_PersonnelInformationId",
                table: "PayrollAdvice");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelInformationUser_AspNetUsers_ApplicationUserId",
                table: "PersonnelInformationUser");

            migrationBuilder.DropTable(
                name: "PayrollBankBranch");

            migrationBuilder.DropIndex(
                name: "IX_PayrollAdvice_PersonnelInformationId",
                table: "PayrollAdvice");

            migrationBuilder.DropColumn(
                name: "PersonnelInformationId",
                table: "PayrollAdvice");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelInformationUser_AspNetUsers_ApplicationUserId",
                table: "PersonnelInformationUser",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
