using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelCompany.Web.Migrations
{
    public partial class variousChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesType_ExpensesType_ExpensesTypeEntityid",
                table: "ExpensesType");

            migrationBuilder.DropIndex(
                name: "IX_ExpensesType_ExpensesTypeEntityid",
                table: "ExpensesType");

            migrationBuilder.DropColumn(
                name: "ExpensesTypeEntityid",
                table: "ExpensesType");

            migrationBuilder.AddColumn<int>(
                name: "ExpensesTypeEntityid",
                table: "Expenses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpensesTypeEntityid",
                table: "Expenses",
                column: "ExpensesTypeEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpensesType_ExpensesTypeEntityid",
                table: "Expenses",
                column: "ExpensesTypeEntityid",
                principalTable: "ExpensesType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpensesType_ExpensesTypeEntityid",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExpensesTypeEntityid",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExpensesTypeEntityid",
                table: "Expenses");

            migrationBuilder.AddColumn<int>(
                name: "ExpensesTypeEntityid",
                table: "ExpensesType",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesType_ExpensesTypeEntityid",
                table: "ExpensesType",
                column: "ExpensesTypeEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesType_ExpensesType_ExpensesTypeEntityid",
                table: "ExpensesType",
                column: "ExpensesTypeEntityid",
                principalTable: "ExpensesType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
