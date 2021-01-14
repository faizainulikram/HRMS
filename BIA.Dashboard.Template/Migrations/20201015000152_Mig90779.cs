using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Mig90779 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayrollAdvice_PersonnelInformation_PersonnelInformationId",
                table: "PayrollAdvice");

            migrationBuilder.DropColumn(
                name: "DeductionAmount",
                table: "PayrollAdvice");

            migrationBuilder.DropColumn(
                name: "Ledger",
                table: "PayrollAdvice");

            migrationBuilder.DropColumn(
                name: "LoanBalance",
                table: "PayrollAdvice");

            migrationBuilder.DropColumn(
                name: "LoanEntitlement",
                table: "PayrollAdvice");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "PayrollAdvice");

            migrationBuilder.AlterColumn<int>(
                name: "PersonnelInformationId",
                table: "PayrollAdvice",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ICNumber",
                table: "PayrollAdvice",
                type: "char(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdviceNumber",
                table: "PayrollAdvice",
                type: "char(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(6)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Deduction",
                table: "PayrollAdvice",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PayrollLedgerId",
                table: "PayrollAdvice",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PayrollAdvice_PayrollLedgerId",
                table: "PayrollAdvice",
                column: "PayrollLedgerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PayrollAdvice_PayrollLedger_PayrollLedgerId",
                table: "PayrollAdvice",
                column: "PayrollLedgerId",
                principalTable: "PayrollLedger",
                principalColumn: "PayrollLedgerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PayrollAdvice_PersonnelInformation_PersonnelInformationId",
                table: "PayrollAdvice",
                column: "PersonnelInformationId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayrollAdvice_PayrollLedger_PayrollLedgerId",
                table: "PayrollAdvice");

            migrationBuilder.DropForeignKey(
                name: "FK_PayrollAdvice_PersonnelInformation_PersonnelInformationId",
                table: "PayrollAdvice");

            migrationBuilder.DropIndex(
                name: "IX_PayrollAdvice_PayrollLedgerId",
                table: "PayrollAdvice");

            migrationBuilder.DropColumn(
                name: "Deduction",
                table: "PayrollAdvice");

            migrationBuilder.DropColumn(
                name: "PayrollLedgerId",
                table: "PayrollAdvice");

            migrationBuilder.AlterColumn<int>(
                name: "PersonnelInformationId",
                table: "PayrollAdvice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ICNumber",
                table: "PayrollAdvice",
                type: "char(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(10)");

            migrationBuilder.AlterColumn<string>(
                name: "AdviceNumber",
                table: "PayrollAdvice",
                type: "char(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(6)");

            migrationBuilder.AddColumn<decimal>(
                name: "DeductionAmount",
                table: "PayrollAdvice",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Ledger",
                table: "PayrollAdvice",
                type: "char(10)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LoanBalance",
                table: "PayrollAdvice",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LoanEntitlement",
                table: "PayrollAdvice",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "PayrollAdvice",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_PayrollAdvice_PersonnelInformation_PersonnelInformationId",
                table: "PayrollAdvice",
                column: "PersonnelInformationId",
                principalTable: "PersonnelInformation",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
