using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Mig77779 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayrollAdvice_PayrollLedger_PayrollLedgerId",
                table: "PayrollAdvice");

            migrationBuilder.AlterColumn<int>(
                name: "PayrollLedgerId",
                table: "PayrollAdvice",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PayrollAdvice_PayrollLedger_PayrollLedgerId",
                table: "PayrollAdvice",
                column: "PayrollLedgerId",
                principalTable: "PayrollLedger",
                principalColumn: "PayrollLedgerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayrollAdvice_PayrollLedger_PayrollLedgerId",
                table: "PayrollAdvice");

            migrationBuilder.AlterColumn<int>(
                name: "PayrollLedgerId",
                table: "PayrollAdvice",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PayrollAdvice_PayrollLedger_PayrollLedgerId",
                table: "PayrollAdvice",
                column: "PayrollLedgerId",
                principalTable: "PayrollLedger",
                principalColumn: "PayrollLedgerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
