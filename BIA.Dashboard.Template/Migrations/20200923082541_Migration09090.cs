using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Migration09090 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PayrollAdvice",
                columns: table => new
                {
                    PayrollAdviceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdviceNumber = table.Column<string>(type: "char(6)", nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    ICNumber = table.Column<string>(type: "char(10)", nullable: true),
                    Remarks = table.Column<string>(type: "char(30)", nullable: true),
                    Earning = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TransactionStartDate = table.Column<DateTime>(nullable: false),
                    TransactionEndDate = table.Column<DateTime>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Ledger = table.Column<string>(type: "char(10)", nullable: true),
                    Status = table.Column<string>(type: "char(1)", nullable: false),
                    StatusDate = table.Column<DateTime>(nullable: false),
                    DeductionAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    DDEA = table.Column<int>(nullable: false),
                    BankCode = table.Column<string>(type: "char(3)", nullable: true),
                    BranchCode = table.Column<string>(type: "char(3)", nullable: true),
                    BankAccountType = table.Column<string>(type: "char(1)", nullable: true),
                    AccountNumber = table.Column<string>(type: "char(17)", nullable: true),
                    AccountName = table.Column<string>(type: "char(50)", nullable: true),
                    LoanEntitlement = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    LoanBalance = table.Column<decimal>(type: "decimal(12,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollAdvice", x => x.PayrollAdviceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayrollAdvice");
        }
    }
}
