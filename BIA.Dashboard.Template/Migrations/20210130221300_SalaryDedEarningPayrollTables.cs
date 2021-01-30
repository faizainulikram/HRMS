using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class SalaryDedEarningPayrollTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeductionPayrollAdvices",
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
                    Deduction = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionPayrollAdvices", x => x.PayrollAdviceId);
                    table.ForeignKey(
                        name: "FK_DeductionPayrollAdvices_PayrollLedger_PayrollLedgerId",
                        column: x => x.PayrollLedgerId,
                        principalTable: "PayrollLedger",
                        principalColumn: "PayrollLedgerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeductionPayrollAdvices_PersonnelInformation_PersonnelInformationId",
                        column: x => x.PersonnelInformationId,
                        principalTable: "PersonnelInformation",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EarningPayrollAdvices",
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
                    Earning = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EarningPayrollAdvices", x => x.PayrollAdviceId);
                    table.ForeignKey(
                        name: "FK_EarningPayrollAdvices_PayrollLedger_PayrollLedgerId",
                        column: x => x.PayrollLedgerId,
                        principalTable: "PayrollLedger",
                        principalColumn: "PayrollLedgerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EarningPayrollAdvices_PersonnelInformation_PersonnelInformationId",
                        column: x => x.PersonnelInformationId,
                        principalTable: "PersonnelInformation",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalaryPayrollAdvices",
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
                    Salary = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryPayrollAdvices", x => x.PayrollAdviceId);
                    table.ForeignKey(
                        name: "FK_SalaryPayrollAdvices_PayrollLedger_PayrollLedgerId",
                        column: x => x.PayrollLedgerId,
                        principalTable: "PayrollLedger",
                        principalColumn: "PayrollLedgerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalaryPayrollAdvices_PersonnelInformation_PersonnelInformationId",
                        column: x => x.PersonnelInformationId,
                        principalTable: "PersonnelInformation",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeductionPayrollAdvices_PayrollLedgerId",
                table: "DeductionPayrollAdvices",
                column: "PayrollLedgerId");

            migrationBuilder.CreateIndex(
                name: "IX_DeductionPayrollAdvices_PersonnelInformationId",
                table: "DeductionPayrollAdvices",
                column: "PersonnelInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_EarningPayrollAdvices_PayrollLedgerId",
                table: "EarningPayrollAdvices",
                column: "PayrollLedgerId");

            migrationBuilder.CreateIndex(
                name: "IX_EarningPayrollAdvices_PersonnelInformationId",
                table: "EarningPayrollAdvices",
                column: "PersonnelInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryPayrollAdvices_PayrollLedgerId",
                table: "SalaryPayrollAdvices",
                column: "PayrollLedgerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryPayrollAdvices_PersonnelInformationId",
                table: "SalaryPayrollAdvices",
                column: "PersonnelInformationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeductionPayrollAdvices");

            migrationBuilder.DropTable(
                name: "EarningPayrollAdvices");

            migrationBuilder.DropTable(
                name: "SalaryPayrollAdvices");
        }
    }
}
