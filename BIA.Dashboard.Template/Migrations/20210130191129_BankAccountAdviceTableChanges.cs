using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class BankAccountAdviceTableChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayrollAdvice");

            migrationBuilder.CreateTable(
                name: "BankAccountPayrollAdvice",
                columns: table => new
                {
                    PayrollAdviceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonnelInformationId = table.Column<int>(nullable: false),
                    AdviceNumber = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ICNumber = table.Column<string>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    TransactionStartDate = table.Column<DateTime>(nullable: false),
                    TransactionEndDate = table.Column<DateTime>(nullable: false),
                    PayrollLedgerId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StatusDate = table.Column<DateTime>(nullable: false),
                    BankCode = table.Column<string>(nullable: true),
                    BranchCode = table.Column<string>(nullable: true),
                    BankAccountType = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    AccountName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccountPayrollAdvice", x => x.PayrollAdviceId);
                    table.ForeignKey(
                        name: "FK_BankAccountPayrollAdvice_PayrollLedger_PayrollLedgerId",
                        column: x => x.PayrollLedgerId,
                        principalTable: "PayrollLedger",
                        principalColumn: "PayrollLedgerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankAccountPayrollAdvice_PersonnelInformation_PersonnelInformationId",
                        column: x => x.PersonnelInformationId,
                        principalTable: "PersonnelInformation",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccountPayrollAdvice_PayrollLedgerId",
                table: "BankAccountPayrollAdvice",
                column: "PayrollLedgerId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccountPayrollAdvice_PersonnelInformationId",
                table: "BankAccountPayrollAdvice",
                column: "PersonnelInformationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccountPayrollAdvice");

            migrationBuilder.CreateTable(
                name: "PayrollAdvice",
                columns: table => new
                {
                    PayrollAdviceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "char(50)", nullable: true),
                    AccountNumber = table.Column<string>(type: "char(17)", nullable: true),
                    AdviceNumber = table.Column<string>(type: "char(6)", nullable: false),
                    BankAccountType = table.Column<string>(type: "char(1)", nullable: true),
                    BankCode = table.Column<string>(type: "char(3)", nullable: true),
                    BranchCode = table.Column<string>(type: "char(3)", nullable: true),
                    DDEA = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deduction = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Earning = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ICNumber = table.Column<string>(type: "char(10)", nullable: false),
                    PayrollLedgerId = table.Column<int>(type: "int", nullable: true),
                    PersonnelInformationId = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "char(30)", nullable: true),
                    Status = table.Column<string>(type: "char(1)", nullable: false),
                    StatusDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionStartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollAdvice", x => x.PayrollAdviceId);
                    table.ForeignKey(
                        name: "FK_PayrollAdvice_PayrollLedger_PayrollLedgerId",
                        column: x => x.PayrollLedgerId,
                        principalTable: "PayrollLedger",
                        principalColumn: "PayrollLedgerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PayrollAdvice_PersonnelInformation_PersonnelInformationId",
                        column: x => x.PersonnelInformationId,
                        principalTable: "PersonnelInformation",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PayrollAdvice_PayrollLedgerId",
                table: "PayrollAdvice",
                column: "PayrollLedgerId");

            migrationBuilder.CreateIndex(
                name: "IX_PayrollAdvice_PersonnelInformationId",
                table: "PayrollAdvice",
                column: "PersonnelInformationId");
        }
    }
}
