using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class BankTableChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bank",
                table: "PayrollBankBranch");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "PayrollBankBranch");

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "PayrollBankBranch");

            migrationBuilder.AddColumn<string>(
                name: "BranchCode",
                table: "PayrollBankBranch",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PayrollBankId",
                table: "PayrollBankBranch",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PayrollBanks",
                columns: table => new
                {
                    PayrollBankId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankCode = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollBanks", x => x.PayrollBankId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PayrollBankBranch_PayrollBankId",
                table: "PayrollBankBranch",
                column: "PayrollBankId");

            migrationBuilder.AddForeignKey(
                name: "FK_PayrollBankBranch_PayrollBanks_PayrollBankId",
                table: "PayrollBankBranch",
                column: "PayrollBankId",
                principalTable: "PayrollBanks",
                principalColumn: "PayrollBankId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayrollBankBranch_PayrollBanks_PayrollBankId",
                table: "PayrollBankBranch");

            migrationBuilder.DropTable(
                name: "PayrollBanks");

            migrationBuilder.DropIndex(
                name: "IX_PayrollBankBranch_PayrollBankId",
                table: "PayrollBankBranch");

            migrationBuilder.DropColumn(
                name: "BranchCode",
                table: "PayrollBankBranch");

            migrationBuilder.DropColumn(
                name: "PayrollBankId",
                table: "PayrollBankBranch");

            migrationBuilder.AddColumn<string>(
                name: "Bank",
                table: "PayrollBankBranch",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "PayrollBankBranch",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "PayrollBankBranch",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
